using Bb.Http;
using Bb.Interceptors;
using Bb.Services;
using RestSharp;
using RestSharp.Authenticators;

namespace Bb.Helpers
{
    /// <summary>
    /// Provides extension methods for configuring and enhancing <see cref="RestRequest"/> and <see cref="RestClientOptions"/>.
    /// </summary>
    public static class RestRequestExtension
    {
        /// <summary>
        /// Adds a bearer token to the request headers.
        /// </summary>
        /// <param name="self">The <see cref="RestRequest"/> instance to configure. Must not be null.</param>
        /// <param name="token">The <see cref="TokenResponse"/> containing the access token. Must not be null.</param>
        /// <returns>The configured <see cref="RestRequest"/> instance.</returns>
        /// <remarks>
        /// This method adds an "Authorization" header with the bearer token to the request.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var request = new RestRequest("api/resource", Method.GET);
        /// request.WithBearer(new TokenResponse { AccessToken = "your-token" });
        /// </code>
        /// </example>
        public static RestRequest WithBearer(this RestRequest self, TokenResponse token)
        {
            self.AddHeader("Authorization", $"Bearer {token.AccessToken}");
            return self;
        }

        /// <summary>
        /// Adds a "Content-Type" header to the request.
        /// </summary>
        /// <param name="self">The <see cref="RestRequest"/> instance to configure. Must not be null.</param>
        /// <param name="contentType">The <see cref="ContentType"/> to set. Must not be null.</param>
        /// <returns>The configured <see cref="RestRequest"/> instance.</returns>
        /// <remarks>
        /// This method sets the "Content-Type" header for the request.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var request = new RestRequest("api/resource", Method.POST);
        /// request.WithContentType(ContentType.Json);
        /// </code>
        /// </example>
        public static RestRequest WithContentType(this RestRequest self, ContentType contentType)
        {
            self.AddHeader("Content-Type", contentType);
            return self;
        }

        /// <summary>
        /// Creates a new <see cref="RestRequest"/> with the specified method, path, and optional data format.
        /// </summary>
        /// <param name="method">The HTTP method for the request. Must not be null.</param>
        /// <param name="path">The resource path for the request. Must not be null or empty.</param>
        /// <param name="format">The optional <see cref="DataFormat"/> for the request. Defaults to JSON if not specified.</param>
        /// <returns>A new <see cref="RestRequest"/> instance.</returns>
        /// <remarks>
        /// This method simplifies the creation of a new REST request with the specified parameters.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var request = Method.GET.NewRequest("api/resource");
        /// </code>
        /// </example>
        public static RestRequest NewRequest(this Method method, string path, DataFormat? format = null)
        {
            var request = new RestRequest(path, method) { RequestFormat = format.HasValue ? format.Value : DataFormat.Json };
            return request;
        }

        /// <summary>
        /// Configures the <see cref="RestClientOptions"/> to intercept HTTP requests.
        /// </summary>
        /// <param name="self">The <see cref="RestClientOptions"/> instance to configure. Must not be null.</param>
        /// <param name="interceptor">The action to execute for intercepting HTTP requests. Must not be null.</param>
        /// <returns>The configured <see cref="RestClientOptions"/> instance.</returns>
        /// <remarks>
        /// This method adds an interceptor to handle HTTP requests before they are sent.
        /// </remarks>
        /// <exception cref="NullReferenceException">
        /// Thrown if <paramref name="interceptor"/> is null.
        /// </exception>
        /// <example>
        /// <code lang="C#">
        /// var options = new RestClientOptions();
        /// options.InterceptRequest(request => Console.WriteLine(request.Method));
        /// </code>
        /// </example>
        public static RestClientOptions InterceptRequest(this RestClientOptions self, Action<HttpRequestMessage> interceptor)
        {
            if (interceptor != null)
                self.Interceptors.Add(new RequestMessageInterceptor(interceptor));
            return self;
        }

        /// <summary>
        /// Configures the <see cref="RestClientOptions"/> to intercept HTTP responses.
        /// </summary>
        /// <param name="self">The <see cref="RestClientOptions"/> instance to configure. Must not be null.</param>
        /// <param name="interceptor">The action to execute for intercepting HTTP responses. Must not be null.</param>
        /// <returns>The configured <see cref="RestClientOptions"/> instance.</returns>
        /// <remarks>
        /// This method adds an interceptor to handle HTTP responses after they are received.
        /// </remarks>
        /// <exception cref="NullReferenceException">
        /// Thrown if <paramref name="interceptor"/> is null.
        /// </exception>
        /// <example>
        /// <code lang="C#">
        /// var options = new RestClientOptions();
        /// options.InterceptResponse(response => Console.WriteLine(response.StatusCode));
        /// </code>
        /// </example>
        public static RestClientOptions InterceptResponse(this RestClientOptions self, Action<HttpResponseMessage> interceptor)
        {
            if (interceptor != null)
                self.Interceptors.Add(new ResponseMessageInterceptor(interceptor));
            return self;
        }

        /// <summary>
        /// Configures the <see cref="RestClientOptions"/> to intercept cookies from HTTP responses.
        /// </summary>
        /// <param name="self">The <see cref="RestClientOptions"/> instance to configure. Must not be null.</param>
        /// <param name="bag">An output parameter to store intercepted cookies.</param>
        /// <returns>The configured <see cref="RestClientOptions"/> instance.</returns>
        /// <remarks>
        /// This method adds an interceptor to capture cookies from HTTP response headers.
        /// </remarks>
        /// <exception cref="NullReferenceException">
        /// Thrown if the interceptor cannot be added.
        /// </exception>
        /// <example>
        /// <code lang="C#">
        /// var options = new RestClientOptions();
        /// options.InterceptCookies(out var cookies);
        /// </code>
        /// </example>
        public static RestClientOptions InterceptCookies(this RestClientOptions self, out Bag<List<KeyValuePair<string, IEnumerable<string>>>> bag)
        {
            var cookies = new Bag<List<KeyValuePair<string, IEnumerable<string>>>>();

            Action<HttpResponseMessage> interceptor = response =>
            {
                cookies.Value = response.Headers
                    .Where(header => header.Key.Equals("Set-Cookie", StringComparison.OrdinalIgnoreCase))
                    .Select(header => new KeyValuePair<string, IEnumerable<string>>(header.Key, header.Value))
                    .ToList();
            };

            bag = cookies;
            self.Interceptors.Add(new ResponseMessageInterceptor(interceptor));

            return self;
        }

        /// <summary>
        /// Configures the <see cref="RestClientOptions"/> to use basic HTTP authentication.
        /// </summary>
        /// <param name="self">The <see cref="RestClientOptions"/> instance to configure. Must not be null.</param>
        /// <param name="userName">The userName for authentication. Must not be null or empty.</param>
        /// <param name="password">The password for authentication. Must not be null or empty.</param>
        /// <returns>The configured <see cref="RestClientOptions"/> instance.</returns>
        /// <remarks>
        /// This method sets up basic HTTP authentication for the REST client.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var options = new RestClientOptions();
        /// options.WithBasicHttp("username", "password");
        /// </code>
        /// </example>
        public static RestClientOptions WithBasicHttp(this RestClientOptions self, string userName, string password)
        {
            self.Authenticator = new HttpBasicAuthenticator(userName, password);
            return self;
        }
    }
}
