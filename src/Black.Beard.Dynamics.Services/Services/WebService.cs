using Bb.ComponentModel;
using Bb.ComponentModel.Factories;
using Bb.Extensions;
using Bb.Interfaces;

namespace Bb.Services
{

    /// <summary>
    /// Initializes and configures a web service using ASP.NET Core.
    /// </summary>
    /// <remarks>
    /// Initializes a new instance of the <see cref="WebService"/> class.
    /// </remarks>
    /// <param name="args">An array of strings representing the command-line arguments. Must not be null.</param>
    /// <remarks>
    /// This constructor initializes the web service with default settings, including assembly paths, startup actions, and host configurations.
    /// </remarks>
    /// <example>
    /// <code lang="C#">
    /// var webService = new WebService(args);
    /// webService.WithHttp(5000).Build().Run();
    /// </code>
    /// </example>
    public class WebService(params string[] args) : IDisposable, IServiceProvider
    {


        /// <summary>
        /// Configures the web service to use a specified startup class.
        /// </summary>
        /// <typeparam name="T">The type of the startup class.</typeparam>
        /// <param name="action">An optional action to configure the startup instance. Can be null.</param>
        /// <returns>The configured <see cref="WebService"/> instance.</returns>
        /// <remarks>
        /// This method ensures that the specified startup class contains the required "ConfigureServices" and "Configure" methods, and registers it for dependency injection.
        /// </remarks>
        /// <exception cref="InvalidOperationException">
        /// Thrown if the startup class does not contain the required methods.
        /// </exception>
        /// <example>
        /// <code lang="C#">
        /// var webService = new WebService(args);
        /// webService.UseStartup&lt;Startup&gt;();
        /// </code>
        /// </example>
        public WebService UseStartup<T>(Action<T>? action = null)
               where T : class
        {

            if (typeof(T).GetMethod("ConfigureServices") == null)
                throw new InvalidOperationException("The startup class must have a method called ConfigureServices");

            if (typeof(T).GetMethod("Configure") == null)
                throw new InvalidOperationException("The startup class must have a method called Configure");

            _startups.Add(typeof(T));

            Prepare(c =>
            {
                var i = Resolve<T>();
                action?.Invoke(i);
                c.UseStartup(i, _services);
            });

            Configure(c =>
            {
                c.UseStartupConfigure(Resolve<T>(), _services);
            });

            return this;

        }

        /// <summary>
        /// Resolves an instance of the specified type from the service provider.
        /// </summary>
        /// <typeparam name="T">The type of the instance to resolve.</typeparam>
        /// <returns>An instance of the specified type.</returns>
        /// <remarks>
        /// This method retrieves an instance of the specified type from the service provider, caching it for future use.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var instance = webService.Resolve&lt;MyService&gt;();
        /// </code>
        /// </example>
        protected T Resolve<T>()
               where T : class
        {
            if (_dicStartup.TryGetValue(typeof(T), out object? value))
                return (T)value;

            else
            {
                var instance = _services.GetService<T>();
                if (instance != default(T))
                    _dicStartup.Add(typeof(T), instance);
                return instance;
            }
        }

        #region prepare

        /// <summary>
        /// Prepares the web application builder with a specified configuration action.
        /// </summary>
        /// <typeparam name="T">The type of the configuration builder.</typeparam>
        /// <param name="configure">An action to configure the <typeparamref name="T"/> instance. Must not be null.</param>
        /// <returns>The configured <see cref="WebService"/> instance.</returns>
        /// <remarks>
        /// This method allows custom configuration of the web application builder using a specific builder type.
        /// </remarks>
        /// <exception cref="ArgumentNullException">
        /// Thrown if <paramref name="configure"/> is null.
        /// </exception>
        /// <example>
        /// <code lang="C#">
        /// webService.Prepare(builder => builder.AddCustomConfiguration());
        /// </code>
        /// </example>
        public WebService Prepare<T>(Action<T> configure)
            where T : InjectBuilder<WebApplicationBuilder>
        {
            void action(WebApplicationBuilder builder, IServiceProvider service)
            {
                var instance = service.GetService<T>();
                if (instance != null)
                {
                    configure?.Invoke(instance);
                    instance.Execute(builder);
                }
            }

            _actionbuilders.Add(action);

            return this;
        }

        private WebApplicationBuilder Prepare()
        {

            var builder = WebApplication
                .CreateBuilder(_args)
                .Initialize()
                ;

            foreach (var item in _actionbuilders)
            {
                _services = new LocalServiceProvider(true, builder.Services.BuildServiceProvider());
                _services.Add(this.GetType(), this);
                _services.Add(typeof(IServiceCollection), builder.Services);
                _services.Add(typeof(WebApplicationBuilder), builder);
                item(builder, _services);
            }

            return builder;

        }

        /// <summary>
        /// Prepares the web application builder with the specified configuration action.
        /// </summary>
        /// <param name="configure">An action to configure the <see cref="WebApplicationBuilder"/>. Must not be null.</param>
        /// <returns>The configured <see cref="WebService"/> instance.</returns>
        /// <remarks>
        /// This method allows custom configuration of the web application builder before building the application.
        /// </remarks>
        /// <exception cref="ArgumentNullException">
        /// Thrown if <paramref name="configure"/> is null.
        /// </exception>
        /// <example>
        /// <code lang="C#">
        /// webService.Prepare(builder => builder.Services.AddControllers());
        /// </code>
        /// </example>
        public WebService Prepare(Action<WebApplicationBuilder> configure)
        {

            ArgumentNullException.ThrowIfNull(configure, nameof(configure));
            void action(WebApplicationBuilder builder, IServiceProvider service)
            {
                configure(builder);
            }

            _actionbuilders.Add(action);

            return this;

        }

        #endregion prepare

        #region Configure

        /// <summary>
        /// Configures the web application with the specified action.
        /// </summary>
        /// <param name="configure">An action to configure the <see cref="WebApplication"/>. Must not be null.</param>
        /// <returns>The configured <see cref="WebService"/> instance.</returns>
        /// <remarks>
        /// This method allows custom configuration of the web application after it has been built.
        /// </remarks>
        /// <exception cref="ArgumentNullException">
        /// Thrown if <paramref name="configure"/> is null.
        /// </exception>
        /// <example>
        /// <code lang="C#">
        /// webService.Configure(app => app.UseRouting());
        /// </code>
        /// </example>
        public WebService Configure(Action<WebApplication> configure)
        {
            ArgumentNullException.ThrowIfNull(configure, nameof(configure));
            void action(WebApplication application)
            {
                configure?.Invoke(application);
            }

            _actions.Add(action);

            return this;

        }

        /// <summary>
        /// Configures the web application with the specified action.
        /// </summary>
        /// <typeparam name="TInjectBuilder">inject Builder</typeparam>
        /// <param name="configure">An action to configure the <see cref="WebApplication"/>. Must not be null.</param>
        /// <returns>The configured <see cref="WebService"/> instance.</returns>
        /// <exception cref="ArgumentNullException"></exception>
        public WebService Configure<TInjectBuilder>(Action<TInjectBuilder> configure)
            where TInjectBuilder : InjectBuilder<WebApplication>
        {

            ArgumentNullException.ThrowIfNull(configure, nameof(configure));
            void action(WebApplication application)
            {
                var instance = application.Services.GetService<TInjectBuilder>();
                if (instance != null)
                {
                    configure?.Invoke(instance);
                    instance.Execute(application);
                }
            }

            _actions.Add(action);

            return this;

        }

        #endregion Configure

        /// <summary>
        /// Builds the web application and applies all configured actions.
        /// </summary>
        /// <param name="configure">An optional action to configure the <see cref="WebApplication"/> after it is built. Can be null.</param>
        /// <returns>The configured <see cref="WebService"/> instance.</returns>
        /// <remarks>
        /// This method builds the web application by applying all prepared actions and configurations.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// webService.Build(app => app.UseEndpoints(endpoints => endpoints.MapControllers()));
        /// </code>
        /// </example>
        public WebService Build(Action<WebApplication>? configure = null)
        {

            _app = Prepare()
                .Build()
                .Initialize()
                ;

            foreach (var item in _actions)
            {
                _services = new LocalServiceProvider(true, _app.Services);
                _services.Add(this.GetType(), this);
                _services.Add(typeof(WebApplication), _app);
                _services.Add(typeof(IWebHostEnvironment), _app.Environment);
                item(_app);
            }

            configure?.Invoke(_app);

            GlobalSettings.CreateFactory = () => _app.Services.GetService<IRestClientFactory>();

            return this;

        }


        /// <summary>
        /// Runs the web application.
        /// </summary>
        /// <remarks>
        /// This method starts the web application and blocks the calling thread until the application is stopped.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// webService.Run();
        /// </code>
        /// </example>
        public void Run()
        {
            _app.Run();
        }


        /// <summary>
        /// Runs the web application asynchronously.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        /// <remarks>
        /// This method starts the web application and returns a task that completes when the application is stopped.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// await webService.RunAsync();
        /// </code>
        /// </example>        
        public WebService RunAsync(bool continueOnCapturedContext = true)
        {
            _currentTask = _app.RunAsync();
            _currentTask.ConfigureAwait(continueOnCapturedContext);
            return this;
        }


        #region Ports & urls


        /// <summary>
        /// Configures the web service to use HTTP with an optional port.
        /// </summary>
        /// <param name="port">The port number for HTTP. Defaults to 80 if not specified.</param>
        /// <returns>The configured <see cref="WebService"/> instance.</returns>
        /// <remarks>
        /// This method adds an HTTP host configuration to the web service.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// webService.WithHttp(5000);
        /// </code>
        /// </example>
        public WebService WithHTTP(int? port = null)
        {
            return WithHTTP(Localhost, port);
        }

        /// <summary>
        /// Configures the web service to use HTTP with a specified host and optional port.
        /// </summary>
        /// <param name="host">The host name for the HTTP configuration. Must not be null or empty.</param>
        /// <param name="port">The port number for HTTP. Defaults to 80 if not specified.</param>
        /// <returns>The configured <see cref="WebService"/> instance.</returns>
        /// <remarks>
        /// This method adds an HTTP host configuration to the web service, allowing it to listen on the specified host and port.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var webService = new WebService(args);
        /// webService.WithHttp("localhost", 5000);
        /// </code>
        /// </example>
        public WebService WithHTTP(string host, int? port = null)
        {
            _hosts.Add(("http", host, port ?? 80));
            return this;
        }

        /// <summary>
        /// Configures the web service to use HTTP dynamically with the default host.
        /// </summary>
        /// <returns>The configured <see cref="WebService"/> instance.</returns>
        /// <remarks>
        /// This method adds a dynamic HTTP host configuration to the web service, allowing it to listen on the default host without specifying a port.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var webService = new WebService(args);
        /// webService.WithDynamicHttp();
        /// </code>
        /// </example>
        public WebService WithDynamicHTTP()
        {
            return WithDynamicHTTP(Localhost);
        }

        /// <summary>
        /// Configures the web service to use HTTP dynamically with a specified host.
        /// </summary>
        /// <param name="host">The host name for the dynamic HTTP configuration. Must not be null or empty.</param>
        /// <returns>The configured <see cref="WebService"/> instance.</returns>
        /// <remarks>
        /// This method adds a dynamic HTTP host configuration to the web service, allowing it to listen on the specified host without specifying a port.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var webService = new WebService(args);
        /// webService.WithDynamicHttp("example.com");
        /// </code>
        /// </example>
        public WebService WithDynamicHTTP(string host)
        {
            _hosts.Add(("http", host, null));
            return this;
        }

        /// <summary>
        /// Configures the web service to use HTTPS with an optional port.
        /// </summary>
        /// <param name="port">The port number for HTTPS. Defaults to 443 if not specified.</param>
        /// <returns>The configured <see cref="WebService"/> instance.</returns>
        /// <remarks>
        /// This method adds an HTTPS host configuration to the web service.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// webService.WithHttps(5001);
        /// </code>
        /// </example>
        public WebService WithHTTPS(int? port = null)
        {
            return WithHTTPS(Localhost, port);
        }

        /// <summary>
        /// Configures the web service to use HTTPS with a specified host and optional port.
        /// </summary>
        /// <param name="host">The host name for the HTTPS configuration. Must not be null or empty.</param>
        /// <param name="port">The port number for HTTPS. Defaults to 443 if not specified.</param>
        /// <returns>The configured <see cref="WebService"/> instance.</returns>
        /// <remarks>
        /// This method adds an HTTPS host configuration to the web service, allowing it to listen on the specified host and port.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var webService = new WebService(args);
        /// webService.WithHttps("localhost", 5001);
        /// </code>
        /// </example>
        public WebService WithHTTPS(string host, int? port = null)
        {
            _hosts.Add(("https", host, port ?? 443));
            return this;
        }

        /// <summary>
        /// Configures the web service to use HTTPS dynamically with the default host.
        /// </summary>
        /// <returns>The configured <see cref="WebService"/> instance.</returns>
        /// <remarks>
        /// This method adds a dynamic HTTPS host configuration to the web service, allowing it to listen on the default host without specifying a port.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var webService = new WebService(args);
        /// webService.WithDynamicHttps();
        /// </code>
        /// </example>
        public WebService WithDynamicHTTPS()
        {
            return WithDynamicHTTPS(Localhost);
        }

        /// <summary>
        /// Configures the web service to use HTTPS dynamically with a specified host.
        /// </summary>
        /// <param name="host">The host name for the dynamic HTTPS configuration. Must not be null or empty.</param>
        /// <returns>The configured <see cref="WebService"/> instance.</returns>
        /// <remarks>
        /// This method adds a dynamic HTTPS host configuration to the web service, allowing it to listen on the specified host without specifying a port.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var webService = new WebService(args);
        /// webService.WithDynamicHttps("example.com");
        /// </code>
        /// </example>
        public WebService WithDynamicHTTPS(string host)
        {
            _hosts.Add(("https", host, null));
            return this;
        }


        #endregion Ports & urls



        /// <summary>
        /// Retrieves a service object of the specified type from the service provider.
        /// </summary>
        /// <param name="serviceType">The type of the service object to retrieve. Must not be null.</param>
        /// <returns>An object of the specified type, or null if the service is not available.</returns>
        /// <remarks>
        /// This method resolves a service from the application's service provider.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var service = webService.GetService(typeof(IMyService));
        /// </code>
        /// </example>
        public object? GetService(Type serviceType)
        {
            return _app.Services.GetService(serviceType);
        }

        /// <summary>
        /// Retrieves a service object of the specified generic type from the service provider.
        /// </summary>
        /// <typeparam name="T">The type of the service object to retrieve.</typeparam>
        /// <returns>An object of the specified type, or null if the service is not available.</returns>
        /// <remarks>
        /// This method resolves a service from the application's service provider using a generic type parameter.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var myService = webService.GetService&lt;IMyService&gt;();
        /// </code>
        /// </example>
        public T? GetService<T>()
        {
            return _app.Services.GetService<T>();
        }

        /// <summary>
        /// Retrieves the built web application instance.
        /// </summary>
        /// <returns>The configured <see cref="WebApplication"/> instance.</returns>
        /// <remarks>
        /// This method provides access to the underlying web application instance for further customization or inspection.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var app = webService.GetApplication();
        /// </code>
        /// </example>
        public WebApplication GetApplication()
        {
            return _app;
        }

        private readonly List<Action<WebApplicationBuilder, IServiceProvider>> _actionbuilders = [];
        private readonly List<Action<WebApplication>> _actions = [];
        private readonly HashSet<Type> _startups = [];
        private readonly Dictionary<Type, object> _dicStartup = [];
        private readonly string[] _args = args;
        private WebApplication _app;
        private LocalServiceProvider _services;
        private const string Localhost = "localhost";

        internal List<(string, string, int?)> _hosts = [];
        private bool disposedValue;
        private Task? _currentTask;

        #region IDisposable Support

        /// <summary>
        /// Disposes the web application and releases resources.
        /// </summary>
        /// <param name="disposing">if the call come from dispose or not</param>
        protected virtual async Task Dispose(bool disposing)
        {
            if (!disposedValue)
            {

                if (disposing)
                {
                    
                    if (_currentTask != null)
                    {
                        var t = _app.StopAsync();
                        await t.ConfigureAwait(true);
                        _currentTask = null;
                    }

                    _app?.DisposeAsync()
                         .ConfigureAwait(true);

                }

                disposedValue = true;

            }
        }

        /// <summary>
        /// Disposes the web application and releases resources.
        /// </summary>
        /// <remarks>
        /// This method disposes of the web application asynchronously and ensures proper cleanup of resources.
        /// </remarks>
        public void Dispose()
        {
            // Ne changez pas ce code. Placez le code de nettoyage dans la méthode 'Dispose(bool disposing)'
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        #endregion IDisposable Support


    }

}



