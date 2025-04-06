using Bb.Helpers;
using Bb.Interfaces;
using Bb.Urls;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using RestSharp;
using System.Xml.Linq;

namespace Bb.Services
{

    /// <summary>
    /// Factory class for creating and configuring <see cref="RestClientOptions"/> instances.
    /// </summary>
    public class OptionClientFactory : IOptionClientFactory
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="OptionClientFactory"/> class using a service provider.
        /// </summary>
        /// <param name="serviceProvider">The <see cref="IServiceProvider"/> instance to resolve dependencies. Must not be null.</param>
        /// <remarks>
        /// This constructor initializes the factory with a default configuration and sets the debug mode based on whether a debugger is attached.
        /// </remarks>
        public OptionClientFactory(IServiceProvider serviceProvider)
        {
            this._services = serviceProvider;
            _configuration = new ClientRestOption();
            this.Debug = System.Diagnostics.Debugger.IsAttached;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OptionClientFactory"/> class using configuration options.
        /// </summary>
        /// <param name="configuration">The <see cref="IOptions{TOptions}"/> instance containing the client configuration. Can be null.</param>
        /// <remarks>
        /// This constructor initializes the factory with the provided configuration or a default configuration if none is provided.
        /// </remarks>
        public OptionClientFactory(IOptions<ClientRestOption> configuration)
        {
            _configuration = configuration?.Value ?? new ClientRestOption();
        }

        /// <summary>
        /// Creates a <see cref="RestClientOptions"/> instance based on the specified name.
        /// </summary>
        /// <param name="name">The name or URL used to create the client options. Must not be null or empty.</param>
        /// <returns>A configured <see cref="RestClientOptions"/> instance.</returns>
        /// <remarks>
        /// This method creates and configures a <see cref="RestClientOptions"/> instance using the provided name or URL. 
        /// If debug mode is enabled, the options are logged.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var factory = new OptionClientFactory(serviceProvider);
        /// var options = factory.Create("https://example.com");
        /// </code>
        /// </example>
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

        /// <summary>
        /// Configures the <see cref="RestClientOptions"/> for a specific URL.
        /// </summary>
        /// <param name="url">The <see cref="Url"/> instance to configure. Must not be null.</param>
        /// <param name="action">The action to configure the options. Must not be null.</param>
        /// <remarks>
        /// This method associates a configuration action with a specific URL.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// factory.Configure(new Url("https://example.com"), options => options.Timeout = TimeSpan.FromSeconds(30));
        /// </code>
        /// </example>
        public void Configure(Url url, Action<RestClientOptions> action)
        {
            var name = url.Root;
            if (_config.ContainsKey(name))
                _config[name] = action;
            else
                _config.Add(name, action);
        }

        /// <summary>
        /// Configures the <see cref="RestClientOptions"/> for a specific URI.
        /// </summary>
        /// <param name="uri">The <see cref="Uri"/> instance to configure. Must not be null.</param>
        /// <param name="action">The action to configure the options. Must not be null.</param>
        /// <remarks>
        /// This method associates a configuration action with a specific URI.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// factory.Configure(new Uri("https://example.com"), options => options.Timeout = TimeSpan.FromSeconds(30));
        /// </code>
        /// </example>
        public void Configure(Uri uri, Action<RestClientOptions> action)
        {
            Configure(new Url(uri), action);
        }

        /// <summary>
        /// Configures the <see cref="RestClientOptions"/> for a specific name or URL.
        /// </summary>
        /// <param name="name">The name or URL to configure. Must not be null or empty.</param>
        /// <param name="action">The action to configure the options. Must not be null.</param>
        /// <remarks>
        /// This method associates a configuration action with a specific name or URL.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// factory.Configure("https://example.com", options => options.Timeout = TimeSpan.FromSeconds(30));
        /// </code>
        /// </example>
        public void Configure(string name, Action<RestClientOptions> action)
        {
            Configure(new Url(name), action);
        }

        /// <summary>
        /// Logs the <see cref="RestClientOptions"/> if a logger is available.
        /// </summary>
        /// <param name="options">The <see cref="RestClientOptions"/> instance to log. Must not be null.</param>
        /// <remarks>
        /// This method logs the client options using the configured logger, if available.
        /// </remarks>
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

        private readonly Dictionary<string, Action<RestClientOptions>> _config
            = new Dictionary<string, Action<RestClientOptions>>();
        private readonly IServiceProvider _services;
        private readonly ClientRestOption _configuration;

        /// <summary>
        /// Gets or sets a value indicating whether debug mode is enabled.
        /// </summary>
        /// <value><c>true</c> if debug mode is enabled; otherwise, <c>false</c>.</value>
        /// <remarks>
        /// When debug mode is enabled, additional logging is performed.
        /// </remarks>
        public bool Debug { get; set; }

    }
}
