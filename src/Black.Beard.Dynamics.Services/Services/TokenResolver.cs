using Bb.Helpers;
using Bb.ComponentModel.Attributes;
using Bb.Http;
using RestSharp;
using Bb.Models;
using Bb.Interfaces;

namespace Bb.Services
{

    /// <summary>
    /// Provides functionality to resolve and retrieve authentication tokens.
    /// </summary>
    public class TokenResolver
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TokenResolver"/> class.
        /// </summary>
        /// <param name="restfactory">The factory to create REST clients. Must not be null.</param>
        /// <param name="configuration">The startup configuration containing REST client options. Must not be null.</param>
        /// <remarks>
        /// This constructor sets up the token resolver with the necessary REST client factory and configuration.
        /// </remarks>
        public TokenResolver(IRestClientFactory restfactory, StartupConfiguration configuration)
        {
            _restFactory = restfactory;
            _configuration = configuration.RestClient;
        }

        /// <summary>
        /// Retrieves a token asynchronously using the provided username and password.
        /// </summary>
        /// <param name="username">The username for authentication. Must not be null or empty.</param>
        /// <param name="password">The password for authentication. Must not be null or empty.</param>
        /// <returns>A <see cref="Task{TResult}"/> representing the asynchronous operation, with a result of <see cref="TokenResponse"/> containing the token details.</returns>
        /// <remarks>
        /// This method fetches a token from the configured token URL using the provided credentials.
        /// </remarks>
        /// <exception cref="InvalidOperationException">
        /// Thrown if the token cannot be fetched or if the configuration is invalid.
        /// </exception>
        /// <example>
        /// <code lang="C#">
        /// var tokenResolver = new TokenResolver(restClientFactory, startupConfiguration);
        /// var tokenResponse = await tokenResolver.GeTokenAsync("username", "password");
        /// </code>
        /// </example>
        public async Task<TokenResponse> GeTokenAsync(string username, string password)
        {
            if (_client == null)
                Initialize();

            var tokenResponse = await _client.GetTokenAsync(_configuration.TokenUrl, _configuration.TokenClientId, _configuration.TokenClientSecret, username, password);
            if (tokenResponse == null)
                throw new InvalidOperationException("Failed to fetch token");

            return tokenResponse;
        }

        /// <summary>
        /// Initializes the REST client for token retrieval.
        /// </summary>
        /// <remarks>
        /// This method sets up the REST client using the configured token URL and client ID.
        /// </remarks>
        /// <exception cref="InvalidOperationException">
        /// Thrown if the token URL or client ID is not defined in the configuration.
        /// </exception>
        private void Initialize()
        {
            if (string.IsNullOrEmpty(_configuration.TokenUrl))
                throw new InvalidOperationException($" {nameof(_configuration.TokenUrl)} is not defined");

            if (string.IsNullOrEmpty(_configuration.TokenClientId))
                throw new InvalidOperationException($" {nameof(_configuration.TokenClientId)} is not defined");

            var client = _restFactory.Create(new Uri(_configuration.TokenUrl));

            _client = client;
        }

        private RestClient _client;
        private readonly IRestClientFactory _restFactory;
        private readonly Models.RestClientOptions _configuration;
    }
}
