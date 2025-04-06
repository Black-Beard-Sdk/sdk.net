using Bb.Http;
using Bb.Interceptors;
using Bb.Services;
using RestSharp;
using RestSharp.Authenticators;

namespace Bb.Helpers
{

    /// <summary>
    /// Extension methods for the <see cref="RestRequest"/> class.
    /// </summary>
    public static class RestRequestExtension
    {

        public static RestRequest WithBearer(this RestRequest self, TokenResponse token)
        {
            self.AddHeader("Authorization", $"Bearer {token.AccessToken}");
            return self;
        }

        public static RestRequest WithContentType(this RestRequest self, ContentType contentType)
        {
            self.AddHeader("Content-Type", contentType);
            return self;
        }

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
            self.Interceptors.Add(new RequestMessageInterceptor(interceptor ?? throw new NullReferenceException(nameof(interceptor))));
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
            self.Interceptors.Add(new ResponseMessageInterceptor(interceptor ?? throw new NullReferenceException(nameof(interceptor))));
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

            self.Interceptors.Add(new ResponseMessageInterceptor(interceptor ?? throw new NullReferenceException(nameof(interceptor))));

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
