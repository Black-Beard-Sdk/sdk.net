using RestSharp;
using System;
using System.Collections.Concurrent;

namespace Bb.Services
{


    public class RestClientFactory : IRestClientFactory
    {

        public RestClientFactory(IOptionClientFactory optionFactory)
        {
            _optionFactory = optionFactory ?? throw new NullReferenceException(nameof(optionFactory));
        }

        public RestClient Create(Uri baseUrl)
        {

            var url = new Url(baseUrl).Root;

            if (_clients.TryGetValue(url, out var client))
                if (_clients.TryGetValue(url, out client))
                    _clients.TryAdd(url, client = new RestClient(_optionFactory.Create(url)));

            return client;

        }

        public RestClient Create(string name)
        {

            var url = new Url(name).Root;

            if (_clients.TryGetValue(url, out var client))
                if (_clients.TryGetValue(url, out client))
                    _clients.TryAdd(url, client = new RestClient(_optionFactory.Create(url)));

            return client;

        }

        public RestClient Create(Url name)
        {
            var url = name.Root;
            var client = _clients.GetOrAdd(url, c => new RestClient(_optionFactory.Create(url)));
            return client;
        }

        private readonly ConcurrentDictionary<string, RestClient> _clients
            = new ConcurrentDictionary<string, RestClient>();
        private readonly IOptionClientFactory _optionFactory;

    }



}
