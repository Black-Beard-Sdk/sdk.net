
using Bb.ComponentModel;
using Bb.ComponentModel.Factories;
using Bb.Extensions;
using Bb.Models;

namespace Bb.Services
{


    public class WebService : IDisposable, IServiceProvider
    {

        public WebService(params string[] args)
        {
            _args = args;
            AssemblyPaths = new HashSet<string>();
            _actionbuilders = new List<Action<WebApplicationBuilder, IServiceProvider>>();
            _actions = new List<Action<WebApplication>>();
            _startups = new HashSet<Type>();
            _dicStartup = new Dictionary<Type, object>();
            _hosts = new List<(string, string, int?)>();
        }



        public HashSet<string> AssemblyPaths { get; }

        public WebService UseStartup<T>(Action<T> action = null)
        {

            if (typeof(T).GetMethod("ConfigureServices") == null)
                throw new InvalidOperationException("The startup class must have a method called ConfigureServices");

            if (typeof(T).GetMethod("Configure") == null)
                throw new InvalidOperationException("The startup class must have a method called Configure");

            _startups.Add(typeof(T));

            Prepare(c =>
            {
                var i = Resolve<T>();
                if (action != null)
                    action(i);
                c.UseStartup(i, _services);
            });

            Configure(c =>
            {
                c.UseStartupConfigure(Resolve<T>(), _services);
            });

            return this;

        }

        protected T Resolve<T>()
        {
            if (_dicStartup.TryGetValue(typeof(T), out object value))
                return (T)value;

            else
            {
                var instance = _services.GetService<T>();
                _dicStartup.Add(typeof(T), instance);
                return instance;
            }
        }

        public WebService Prepare(Action<WebApplicationBuilder> configure)
        {

            if (configure == null)
                throw new ArgumentNullException(nameof(configure));

            Action<WebApplicationBuilder, IServiceProvider> action = (builder, service) =>
            {
                configure(builder);
            };

            _actionbuilders.Add(action);

            return this;

        }

        public WebService Configure(Action<WebApplication> configure)
        {

            if (configure == null)
                throw new ArgumentNullException(nameof(configure));

            Action<WebApplication> action = (application) =>
            {
                configure?.Invoke(application);
            };

            _actions.Add(action);

            return this;

        }

        public WebService Configure<T>(Action<T> configure)
            where T : InjectBuilder<WebApplication>
        {

            if (configure == null)
                throw new ArgumentNullException(nameof(configure));

            Action<WebApplication> action = (application) =>
            {
                var instance = application.Services.GetService<T>();
                configure?.Invoke(instance);
                instance.Execute(application);
            };

            _actions.Add(action);

            return this;

        }

        public WebService Prepare<T>(Action<T> configure)
            where T : InjectBuilder<WebApplicationBuilder>
        {

            Action<WebApplicationBuilder, IServiceProvider> action = (builder, service) =>
            {
                var instance = service.GetService<T>();
                configure?.Invoke(instance);
                instance.Execute(builder);
            };

            _actionbuilders.Add(action);

            return this;

        }

        private WebApplicationBuilder Prepare()
        {

            InitializerExtension.LoadAssemblies(AssemblyPaths.ToArray());

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

        public WebService Build(Action<WebApplication> configure = null)
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

            if (configure != null)
                configure(_app);

            return this;

        }


        public void Run()
        {
            _app.Run();
        }


        public async Task<WebService> RunAsync()
        {

            await _app.RunAsync()
                .ConfigureAwait(false);

            return this;

        }


        #region Ports & urls


        public WebService WithHttp(int? port = null)
        {
            return WithHttp("localhost", port);
        }

        public WebService WithHttp(string host, int? port = null)
        {
            _hosts.Add(("http", host, port ?? 80));
            return this;
        }



        public WebService WithDynamicHttp()
        {
            return WithDynamicHttp("localhost");
        }

        public WebService WithDynamicHttp(string host)
        {
            _hosts.Add(("http", host, null));
            return this;
        }



        public WebService WithHttps(int? port = null)
        {
            return WithHttps("localhost", port);
        }

        public WebService WithHttps(string host, int? port = null)
        {
            _hosts.Add(("https", host, port ?? 443));
            return this;
        }



        public WebService WithDynamicHttps()
        {
            return WithDynamicHttps("localhost");
        }

        public WebService WithDynamicHttps(string host)
        {
            _hosts.Add(("https", host, null));
            return this;
        }


        #endregion Ports & urls


        public async void Dispose()
        {
            _app?.DisposeAsync();
            _app.ConfigureAwait(true);
        }

        public object? GetService(Type serviceType)
        {
            return _app.Services.GetService(serviceType);
        }

        public T GetService<T>()
        {
            return _app.Services.GetService<T>();
        }

        public WebApplication GetApplication()
        {
            return _app;
        }

        private readonly List<Action<WebApplicationBuilder, IServiceProvider>> _actionbuilders;
        private readonly List<Action<WebApplication>> _actions;
        private readonly HashSet<Type> _startups;
        private readonly Dictionary<Type, object> _dicStartup;
        private readonly string[] _args;
        private WebApplication _app;
        private LocalServiceProvider _services;

        internal List<(string, string, int?)> _hosts;


    }

}



