using Bb.Helpers;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using RestSharp;
using System.Xml.Linq;

namespace Bb.Services
{
    public class OptionClientFactory : IOptionClientFactory
    {


        public OptionClientFactory(IServiceProvider serviceProvider)
        {
            this._services = serviceProvider;
            _configuration = new ClientRestOption();
            this.Debug = System.Diagnostics.Debugger.IsAttached;
        }

        public OptionClientFactory(IOptions<ClientRestOption> configuration)
        {
            _configuration = configuration?.Value ?? new ClientRestOption();
        }

        public RestClientOptions Create(string name)
        {

            var n = new Url(name).Root;

            RestClientOptions options = new RestClientOptions(n)
            {
                Timeout = TimeSpan.FromSeconds(_configuration.Timeout),
            };

            if (Debug)
                Trace(options);

            if (_config.TryGetValue(n, out var action))
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


        private void Trace(RestClientOptions options)
        {
            ILogger<RestClientOptions> logger = null;
            if (_services != null)
            {
                var l = _services.GetService(typeof(ILogger<RestClientOptions>));
                logger = (ILogger<RestClientOptions>)l;
            }
            options.WithLog(logger);
        }

        private Dictionary<string, Action<RestClientOptions>> _config
            = new Dictionary<string, Action<RestClientOptions>>();
        private readonly IServiceProvider _services;
        private readonly ClientRestOption _configuration;
        public bool Debug { get; set; }

    }


}
