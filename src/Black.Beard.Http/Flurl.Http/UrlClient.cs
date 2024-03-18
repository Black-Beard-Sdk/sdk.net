
using Bb.Http.Configuration;
using Bb.Http.Testing;
using Bb.Util;

namespace Bb.Http
{

    /// <summary>
    /// A reusable object for making HTTP calls.
    /// </summary>
    public class UrlClient : IUrlClient
    {

        /// <summary>
        /// Initializes a new instance of <see cref="UrlClient"/>.
        /// </summary>
        /// <param name="baseUrl">The base URL associated with this client.</param>
        public UrlClient(string baseUrl = null) :
            this(UrlHttp.GlobalSettings.FlurlClientFactory.CreateHttpClient(), baseUrl)
        { }

        /// <summary>
        /// Initializes a new instance of <see cref="UrlClient"/>, wrapping an existing HttpClient.
        /// Generally, you should let Flurl create and manage HttpClient instances for you, but you might, for
        /// example, have an HttpClient instance that was created by a 3rd-party library and you want to use
        /// Flurl to build and send calls with it. Be aware that if the HttpClient has an underlying
        /// HttpMessageHandler that processes cookies and automatic redirects (as is the case by default),
        /// Flurl's re-implementation of those features may not work properly.
        /// </summary>
        /// <param name="httpClient">The instantiated HttpClient instance.</param>
        /// <param name="baseUrl">The base URL associated with this client.</param>
        public UrlClient(HttpClient httpClient, string baseUrl = null)
        {
            HttpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
            BaseUrl = baseUrl ?? HttpClient.BaseAddress?.ToString();
        }

        /// <inheritdoc />
        public string BaseUrl { get; set; }

        /// <inheritdoc />
        public UrlHttpSettings Settings { get; } = new UrlHttpSettings();

        /// <inheritdoc />
        public INameValueList<string> Headers { get; } = new NameValueList<string>(false); // header names are case-insensitive https://stackoverflow.com/a/5259004/62600

        /// <inheritdoc />
        public HttpClient HttpClient { get; }

        /// <inheritdoc />
        public IUrlRequest Request(params object[] urlSegments) => new UrlRequest(this, urlSegments);

        /// <inheritdoc />
        public async Task<IUrlResponse> SendAsync(IUrlRequest request, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead, CancellationToken cancellationToken = default)
        {
            if (request == null)
                throw new ArgumentNullException(nameof(request));
            if (request.Url == null)
                throw new ArgumentException("Cannot send Request. Url property was not set.");
            if (!Url.IsValid(request.Url))
                throw new ArgumentException($"Cannot send Request. {request.Url} is a not a valid URL.");

            var settings = request.Settings;
            var reqMsg = new HttpRequestMessage(request.Verb, request.Url) { Content = request.Content };

            SyncHeaders(request, reqMsg);
            var call = new UrlCall
            {
                Request = request,
                HttpRequestMessage = reqMsg
            };

            await RaiseEventAsync(settings.BeforeCall, settings.BeforeCallAsync, call).ConfigureAwait(false);

            // in case URL or headers were modified in the handler above
            reqMsg.RequestUri = request.Url.ToUri();
            SyncHeaders(request, reqMsg);

            call.StartedUtc = DateTime.UtcNow;
            var ct = GetCancellationTokenWithTimeout(cancellationToken, settings.Timeout, out var cts);

            HttpTest.Current?.LogCall(call);

            try
            {
                call.HttpResponseMessage =
                    HttpTest.Current?.FindSetup(call)?.GetNextResponse() ??
                    await HttpClient.SendAsync(reqMsg, completionOption, ct).ConfigureAwait(false);

                call.HttpResponseMessage.RequestMessage = reqMsg;
                call.Response = new UrlResponse(call, request.CookieJar);

                if (call.Succeeded)
                {
                    var redirResponse = await ProcessRedirectAsync(call, completionOption, cancellationToken).ConfigureAwait(false);
                    return redirResponse ?? call.Response;
                }
                else
                    throw new UrlHttpException(call, null);
            }
            catch (Exception ex)
            {
                return await HandleExceptionAsync(call, ex, cancellationToken).ConfigureAwait(false);
            }
            finally
            {
                reqMsg.Dispose();
                cts?.Dispose();
                call.EndedUtc = DateTime.UtcNow;
                await RaiseEventAsync(settings.AfterCall, settings.AfterCallAsync, call).ConfigureAwait(false);
            }
        }

        private void SyncHeaders(IUrlRequest req, HttpRequestMessage reqMsg)
        {
            // copy any client-level (default) headers to FlurlRequest
            foreach (var header in this.Headers.Where(h => !req.Headers.Contains(h.Name)).ToList())
                req.Headers.Add(header.Name, header.Value);

            // copy headers from FlurlRequest to HttpRequestMessage
            foreach (var header in req.Headers)
                reqMsg.SetHeader(header.Name, header.Value.Trim(), false);

            // copy headers from HttpContent to FlurlRequest
            if (reqMsg.Content != null)
            {
                foreach (var header in reqMsg.Content.Headers)
                    req.Headers.AddOrReplace(header.Key, string.Join(",", header.Value));
            }
        }

        private async Task<IUrlResponse> ProcessRedirectAsync(UrlCall call, HttpCompletionOption completionOption, CancellationToken cancellationToken)
        {
            var settings = call.Request.Settings;
            if (settings.Redirects.Enabled)
                call.Redirect = GetRedirect(call);

            if (call.Redirect == null)
                return null;

            await RaiseEventAsync(settings.OnRedirect, settings.OnRedirectAsync, call).ConfigureAwait(false);

            if (call.Redirect.Follow != true)
                return null;

            var changeToGet = call.Redirect.ChangeVerbToGet;

            var redir = new UrlRequest(this)
            {
                Url = call.Redirect.Url,
                Verb = changeToGet ? HttpMethod.Get : call.HttpRequestMessage.Method,
                Content = changeToGet ? null : call.Request.Content,
                RedirectedFrom = call,
                Settings = { Defaults = settings }
            };

            if (call.Request.CookieJar != null)
                redir.CookieJar = call.Request.CookieJar;

            redir.WithHeaders(call.Request.Headers.Where(h =>
                h.Name.OrdinalEquals("Cookie", true) ? false : // never blindly forward Cookie header; CookieJar should be used to ensure rules are enforced
                h.Name.OrdinalEquals("Authorization", true) ? settings.Redirects.ForwardAuthorizationHeader :
                h.Name.OrdinalEquals("Transfer-Encoding", true) ? settings.Redirects.ForwardHeaders && !changeToGet :
                settings.Redirects.ForwardHeaders));

            var ct = GetCancellationTokenWithTimeout(cancellationToken, settings.Timeout, out var cts);
            try
            {
                return await SendAsync(redir, completionOption, ct).ConfigureAwait(false);
            }
            finally
            {
                cts?.Dispose();
            }
        }

        // partially lifted from https://github.com/dotnet/runtime/blob/master/src/libraries/System.Net.Http/src/System/Net/Http/SocketsHttpHandler/RedirectHandler.cs
        private static UrlRedirect GetRedirect(UrlCall call)
        {
            if (call.Response.StatusCode < 300 || call.Response.StatusCode > 399)
                return null;

            if (!call.Response.Headers.TryGetFirst("Location", out var location))
                return null;

            var redir = new UrlRedirect();

            if (Url.IsValid(location))
                redir.Url = new Url(location);
            else if (location.OrdinalStartsWith("//"))
                redir.Url = new Url(call.Request.Url.Scheme + ":" + location);
            else if (location.OrdinalStartsWith("/"))
                redir.Url = Url.Combine(call.Request.Url.Root, location);
            else
                redir.Url = Url.Combine(call.Request.Url.Root, call.Request.Url.Path, location);

            // Per https://tools.ietf.org/html/rfc7231#section-7.1.2, a redirect location without a
            // fragment should inherit the fragment from the original URI.
            if (string.IsNullOrEmpty(redir.Url.Fragment))
                redir.Url.Fragment = call.Request.Url.Fragment;

            redir.Count = 1 + (call.Request.RedirectedFrom?.Redirect?.Count ?? 0);

            var isSecureToInsecure = (call.Request.Url.IsSecureScheme && !redir.Url.IsSecureScheme);

            redir.Follow =
                new[] { 301, 302, 303, 307, 308 }.Contains(call.Response.StatusCode) &&
                redir.Count <= call.Request.Settings.Redirects.MaxAutoRedirects &&
                (call.Request.Settings.Redirects.AllowSecureToInsecure || !isSecureToInsecure);

            bool ChangeVerbToGetOn(int statusCode, HttpMethod verb)
            {
                switch (statusCode)
                {
                    // 301 and 302 are a bit ambiguous. The spec says to preserve the verb
                    // but most browsers rewrite it to GET. HttpClient stack changes it if
                    // only it's a POST, presumably since that's a browser-friendly verb.
                    // Seems odd, but sticking with that is probably the safest bet.
                    // https://github.com/dotnet/runtime/blob/master/src/libraries/System.Net.Http/src/System/Net/Http/SocketsHttpHandler/RedirectHandler.cs#L140
                    case 301:
                    case 302:
                        return verb == HttpMethod.Post;
                    case 303:
                        return true;
                    default: // 307 & 308 mainly
                        return false;
                }
            }

            redir.ChangeVerbToGet =
                redir.Follow &&
                ChangeVerbToGetOn(call.Response.StatusCode, call.Request.Verb);

            return redir;
        }

        private static Task RaiseEventAsync(Action<UrlCall> syncHandler, Func<UrlCall, Task> asyncHandler, UrlCall call)
        {
            syncHandler?.Invoke(call);
            if (asyncHandler != null)
                return asyncHandler(call);
            return Task.FromResult(0);
        }

        internal static async Task<IUrlResponse> HandleExceptionAsync(UrlCall call, Exception ex, CancellationToken token)
        {
            call.Exception = ex;
            await RaiseEventAsync(call.Request.Settings.OnError, call.Request.Settings.OnErrorAsync, call).ConfigureAwait(false);

            if (call.ExceptionHandled)
                return call.Response;

            if (ex is OperationCanceledException && !token.IsCancellationRequested)
                throw new UrlHttpTimeoutException(call, ex);

            if (ex is UrlHttpException)
                throw ex;

            throw new UrlHttpException(call, ex);
        }

        private static CancellationToken GetCancellationTokenWithTimeout(CancellationToken original, TimeSpan? timeout, out CancellationTokenSource timeoutTokenSource)
        {
            timeoutTokenSource = null;
            if (!timeout.HasValue)
                return original;

            timeoutTokenSource = CancellationTokenSource.CreateLinkedTokenSource(original);
            timeoutTokenSource.CancelAfter(timeout.Value);
            return timeoutTokenSource.Token;
        }

        /// <inheritdoc />
        public bool IsDisposed { get; private set; }

        /// <summary>
        /// Disposes the underlying HttpClient and HttpMessageHandler.
        /// </summary>
        public virtual void Dispose()
        {
            if (IsDisposed)
                return;

            HttpClient.Dispose();
            IsDisposed = true;
        }
    }
}