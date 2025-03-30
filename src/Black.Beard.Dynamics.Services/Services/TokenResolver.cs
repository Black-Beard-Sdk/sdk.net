using Bb.Helpers;
using Bb.ComponentModel.Attributes;
using Bb.Http;
using RestSharp;
using Bb.Models;

namespace Bb.Services
{


    public class TokenResolver
    {

        public TokenResolver(IRestClientFactory restfactory, StartupConfiguration configuration)
        {
            _restFactory = restfactory;
            _configuration = configuration.RestClient;
        }


        public async Task<TokenResponse> GeTokenAsync(string username, string password)
        {

            if (_client == null)
                Initialize();

            var tokenResponse = await _client.GetTokenAsync(_configuration.TokenUrl, _configuration.TokenClientId, _configuration.TokenClientSecret, username, password);
            if (tokenResponse == null)
                throw new InvalidOperationException("Failed to fetch token");

            return tokenResponse;
        
        }

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
