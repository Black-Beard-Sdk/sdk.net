using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using RestSharp;
using System.Xml.Linq;

namespace Bb.Services
{
    public class OptionClientFactory : IOptionClientFactory
    {

        public OptionClientFactory()
        {

            _configuration = new OptionConfiguration();

        }

        public OptionClientFactory(IOptions<OptionConfiguration> configuration)
        {
            _configuration = configuration?.Value ?? new OptionConfiguration();
        }

        public RestClientOptions Create(string name)
        {

            RestClientOptions options = new RestClientOptions(name)
            {
                Timeout = TimeSpan.FromSeconds(_configuration.Timeout),
            };


            if (_config.TryGetValue(name, out var action))
                action(options);

            else if (_config.TryGetValue(string.Empty, out action))
                action(options);

            return options;

        }

        public void Configure(Url url, Action<RestClientOptions> action)
        {
            var name = url.Root;
            if (_config.ContainsKey(name))
                _config[name] = action;
            else
                _config.Add(name, action);
        }

        public void Configure(Uri uri, Action<RestClientOptions> action)
        {
            Configure(new Url(uri), action);

        }

        public void Configure(string name, Action<RestClientOptions> action)
        {
            Configure(new Url(name), action);
        }


        private Dictionary<string, Action<RestClientOptions>> _config
            = new Dictionary<string, Action<RestClientOptions>>();

        private readonly OptionConfiguration _configuration;

    }


}
