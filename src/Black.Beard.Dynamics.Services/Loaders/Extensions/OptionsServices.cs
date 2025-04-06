using Bb.ComponentModel.Attributes;
using Microsoft.Extensions.Options;
using System.Reflection;

namespace Bb.Loaders.SiteExtensions
{


    /// <summary>
    /// Represents a service for managing options in a service collection.
    /// </summary>
    public class OptionsServices
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="OptionsServices"/> class.
        /// </summary>
        /// <param name="services">The <see cref="IServiceCollection"/> to manage options services. Must not be null.</param>
        /// <remarks>
        /// This constructor sets up the options services manager with the provided service collection.
        /// </remarks>
        public OptionsServices(IServiceCollection services)
        {
            _services = services;
        }

        /// <summary>
        /// Retrieves a collection of types based on the specified options enumeration.
        /// </summary>
        /// <param name="services">The <see cref="IServiceProvider"/> used to resolve service instances. Must not be null.</param>
        /// <param name="option">The <see cref="OptionsEnum"/> value to filter the types. Must not be null.</param>
        /// <returns>An enumerable of <see cref="Type"/> objects representing the filtered types.</returns>
        /// <remarks>
        /// This method discovers and filters types exposed by the <see cref="ExposeClassAttribute"/> and registered as options in the service collection.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var services = new ServiceCollection();
        /// var optionsServices = new OptionsServices(services);
        /// var types = optionsServices.Items(serviceProvider, OptionsEnum.Configuration);
        /// foreach (var type in types)
        /// {
        ///     Console.WriteLine($"Type: {type.FullName}");
        /// }
        /// </code>
        /// </example>
        public IEnumerable<Type> Items(IServiceProvider services, OptionsEnum option)
        {

            if (_services != null)
                lock (_lock)
                    if (_services != null)
                    {

                        _types = new List<(OptionsEnum, Type, Type)>();

                        foreach (var service in _services)
                            if (service.ServiceType.IsGenericType && service.ServiceType.GetGenericTypeDefinition() == typeof(IConfigureOptions<>))
                            {
                                var optionsType = service.ServiceType.GenericTypeArguments[0];

                                var attribute = optionsType.GetCustomAttribute<ExposeClassAttribute>();
                                if (attribute != null)
                                {

                                    var instance = services.GetService(service.ServiceType);
                                    if (instance != null)
                                        _types.Add((OptionsEnum.Configuration, service.ServiceType, optionsType));
                             
                                }
                            }

                        _services = null;
                    
                    }

            return _types.Where(c => c.Item1 == option).Select(c => c.Item2);

        }

        private IServiceCollection _services;
        private List<(OptionsEnum, Type, Type)> _types;
        private volatile object _lock = new object();

    }


    public enum OptionsEnum
    {

        /// <summary>
        /// Represents options related to configuration settings.
        /// </summary>
        Configuration,
    }

}
