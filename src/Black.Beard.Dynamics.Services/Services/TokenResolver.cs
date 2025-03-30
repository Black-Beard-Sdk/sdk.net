using Bb.Helpers;
using Bb.ComponentModel.Attributes;
using Bb.Http;
using RestSharp;

namespace Bb.Services
{
    public class TokenResolver
    {


        public TokenResolver(IRestClientFactory restfactory)
        {
            _restFactory = restfactory;
        }


        public async Task<TokenResponse> GeTokenAsync(string username, string password)
        {

            if (_httpClient == null)
                Initialize();

            var tokenResponse = await _httpClient.GetTokenAsync(Url, ClientId, ClientSecret, username, password);
            if (tokenResponse == null)
                throw new InvalidOperationException("Failed to fetch token");

            return tokenResponse;
        
        }

        private void Initialize()
        {
            
            if (string.IsNullOrEmpty(Url))
                throw new InvalidOperationException($" {nameof(Url)} is not defined");

            if (string.IsNullOrEmpty(ClientId))
                throw new InvalidOperationException($" {nameof(ClientId)} is not defined");

            var client = _restFactory.Create(new Uri(Url));

            _httpClient = client;

        }

        [InjectValueByIoc("TokenResolver:url")]
        public string Url { get; set; }

        [InjectValueByIoc("TokenResolver:clientId")]
        public string ClientId { get; set; }

        [InjectValueByIoc("TokenResolver:clientSecret")]
        public string ClientSecret { get; set; }



        private RestClient _httpClient;
        private readonly IRestClientFactory _restFactory;
    }



}
