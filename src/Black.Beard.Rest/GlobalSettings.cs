using Bb.Interfaces;
using Bb.Services;

namespace Bb
{
    /// <summary>
    /// Provides global settings and factories for creating REST client instances and options.
    /// </summary>
    /// <remarks>
    /// This class manages the creation and configuration of REST client factories and option factories. 
    /// It provides static properties to access and modify these factories globally.
    /// </remarks>
    public class GlobalSettings
    {

        /// <summary>
        /// 
        /// </summary>
        protected GlobalSettings()
        {

        }


        /// <summary>
        /// Gets or sets the global <see cref="IRestClientFactory"/> instance.
        /// </summary>
        /// <value>
        /// The <see cref="IRestClientFactory"/> instance used for creating REST clients.
        /// </value>
        /// <remarks>
        /// If the factory is not already set, it is created using the <see cref="CreateFactory"/> function.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var factory = GlobalSettings.UrlClientFactory;
        /// var client = factory.CreateClient();
        /// </code>
        /// </example>
        public static IRestClientFactory UrlClientFactory
        {
            get
            {

                if (_factory == null)
                    _factory = CreateFactory()
                        ?? throw new InvalidOperationException("The factory is not set. Please set the factory using CreateFactory.");

                return _factory;
            }
            set
            {
                _factory = value;
                _ioptionFactory = null;
            }
        }


        /// <summary>
        /// Gets or sets the factory function for creating <see cref="IRestClientFactory"/> instances.
        /// </summary>
        /// <value>
        /// A function that returns an <see cref="IRestClientFactory"/> instance.
        /// </value>
        /// <remarks>
        /// By default, this property is initialized to create a new <see cref="RestClientFactory"/> using the <see cref="OptionFactory"/>.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// GlobalSettings.CreateFactory = () => new CustomRestClientFactory();
        /// var factory = GlobalSettings.CreateFactory();
        /// </code>
        /// </example>
        public static Func<IRestClientFactory?> CreateFactory { get; set; } = () =>
        {
            IHttpClientFactory? factory = null;
            if (ServiceProvider != null)
                factory = ServiceProvider.GetService(typeof(IHttpClientFactory)) as IHttpClientFactory;
            return new RestClientFactory(OptionFactory ?? throw new InvalidOperationException("GlobalSettings.OptionFactory"), factory);
        };


        /// <summary>
        /// Gets or sets the global <see cref="IOptionClientFactory"/> instance.
        /// </summary>
        /// <value>
        /// The <see cref="IOptionClientFactory"/> instance used for configuring REST client options.
        /// </value>
        /// <remarks>
        /// If the factory is not already set, it is initialized with a default <see cref="OptionClientFactory"/> instance.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var optionFactory = GlobalSettings.OptionFactory;
        /// var options = optionFactory.CreateOptions();
        /// </code>
        /// </example>
        public static IOptionClientFactory? OptionFactory
        {
            get
            {

                if (_ioptionFactory == null)
                {

                    if (ServiceProvider != null)
                    {
                        _ioptionFactory = ServiceProvider.GetService(typeof(IOptionClientFactory)) as IOptionClientFactory;
                        if (_ioptionFactory == null)
                            _ioptionFactory = new OptionClientFactory(ServiceProvider);
                    }

                    if (_ioptionFactory == null)
                        _ioptionFactory = new OptionClientFactory();

                }

                return _ioptionFactory;
            }
            set
            {
                _ioptionFactory = value;
                _factory = null;
            }
        }

        /// <summary>
        /// Gets or sets the global <see cref="IServiceProvider"/> instance.
        /// </summary>
        public static IServiceProvider? ServiceProvider { get; set; }

        private static IOptionClientFactory? _ioptionFactory;
        private static IRestClientFactory? _factory;
    }
}
