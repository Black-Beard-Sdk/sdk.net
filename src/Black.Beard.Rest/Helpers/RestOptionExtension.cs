// Ignore Spelling: Auth Jwt

using Bb.Interceptors;
using Microsoft.Extensions.Logging;
using RestSharp;
using RestSharp.Authenticators;
using RestSharp.Authenticators.OAuth2;
using Bb.Services;

namespace Bb.Helpers
{


    /// <summary>
    /// Extension methods for configuring RestClientOptions in the BlackBeard library.
    /// </summary>
    public static class RestOptionExtension
    {


        #region interceptors

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
            self.Interceptors.Add(new RequestMessageInterceptor(interceptor ?? throw new ArgumentNullException(nameof(interceptor))));
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
            self.Interceptors.Add(new ResponseMessageInterceptor(interceptor ?? throw new ArgumentNullException(nameof(interceptor))));
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

            self.Interceptors.Add(new ResponseMessageInterceptor(interceptor ?? throw new InvalidOperationException(nameof(interceptor))));

            return self;
        }

        #endregion interceptors


        #region Authentication

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
        /// options.WithBasicHttp("userName", "password");
        /// </code>
        /// </example>
        public static RestClientOptions WithBasicHttp(this RestClientOptions self, string userName, string password)
        {
            self.Authenticator = new HttpBasicAuthenticator(userName, password);
            return self;
        }

        /// <summary>
        /// Use jwt token
        /// </summary>
        /// <param name="self"><see cref="RestClientOptions"/></param>
        /// <param name="accessToken"></param>
        /// <returns></returns>
        public static RestClientOptions WithJwt(this RestClientOptions self, string accessToken)
        {
            self.Authenticator = new JwtAuthenticator(accessToken);
            return self;
        }

        /// <summary>
        /// Use authentication Oauth1
        /// </summary>
        /// <param name="self"><see cref="RestClientOptions"/></param>
        /// <param name="consumerKey"></param>
        /// <param name="consumerSecret"></param>
        /// <returns></returns>
        public static RestClientOptions WithAuth1(this RestClientOptions self, string consumerKey, string consumerSecret)
        {
            self.Authenticator = OAuth1Authenticator.ForRequestToken(consumerKey, consumerSecret);
            return self;
        }

        /// <summary>
        /// Use authentication Oauth2
        /// </summary>
        /// <param name="self"><see cref="RestClientOptions"/></param>
        /// <param name="accessToken">access token to use </param>
        /// <returns></returns>
        public static RestClientOptions WithOAuth2(this RestClientOptions self, string accessToken)
        {
            var authenticator = new OAuth2AuthorizationRequestHeaderAuthenticator(accessToken, "Bearer");
            self.Authenticator = authenticator;
            return self;
        }

        #endregion Authentication


        #region logs

        /// <summary>
        /// Adds logging capabilities to the <see cref="RestClientOptions"/> instance.
        /// </summary>
        /// <param name="self"><see cref="RestClientOptions"/></param>
        /// <param name="logger">logger to use</param>
        /// <returns></returns>
        public static RestClientOptions WithLog(this RestClientOptions self, ILogger? logger = null)
        {

            var request = new LogConfiguration<HttpRequestMessage>()
                .LogStart()
                .LogAll();

            var response = new LogConfiguration<HttpResponseMessage>()
                .LogAll();

            self.Interceptors.Add(new LogInterceptor(request, response, logger));
            return self;
        }

        /// <summary>
        /// Adds logging capabilities to the <see cref="RestClientOptions"/> instance.
        /// </summary>
        /// <param name="self"><see cref="RestClientOptions"/></param>
        /// <param name="requestAction">Request action</param>
        /// <param name="logger">logger to use</param>
        /// <returns></returns>
        public static RestClientOptions WithLog(this RestClientOptions self,
            Action<LogConfiguration<HttpRequestMessage>> requestAction,
            ILogger? logger = null)
        {
            var request = new LogConfiguration<HttpRequestMessage>();
            requestAction?.Invoke(request);
            var response = new LogConfiguration<HttpResponseMessage>();
            self.Interceptors.Add(new LogInterceptor(request, response, logger));
            return self;
        }

        /// <summary>
        /// Adds logging capabilities to the <see cref="RestClientOptions"/> instance.
        /// </summary>
        /// <param name="self"><see cref="RestClientOptions"/></param>
        /// <param name="requestAction">Request action</param>
        /// <param name="responseAction"></param>
        /// <param name="logger">logger to use</param>
        /// <returns></returns>
        public static RestClientOptions WithLog(this RestClientOptions self,
            Action<LogConfiguration<HttpRequestMessage>> requestAction,
            Action<LogConfiguration<HttpResponseMessage>> responseAction,
            ILogger? logger = null)
        {

            var request = new LogConfiguration<HttpRequestMessage>();
            request.LogStart();
            requestAction?.Invoke(request);

            var response = new LogConfiguration<HttpResponseMessage>();
            responseAction?.Invoke(response);

            self.Interceptors.Add(new LogInterceptor(request, response, logger));
            return self;

        }

        #endregion logs


    }

}
