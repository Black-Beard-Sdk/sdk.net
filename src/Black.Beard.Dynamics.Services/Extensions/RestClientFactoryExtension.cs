using Bb.Interfaces;
using Bb.Services;
using RestSharp;

namespace Bb.Extensions
{

    /// <summary>
    /// Extension methods for configuring the REST client factory in the BlackBeard library.
    /// </summary>
    public static class RestClientFactoryExtension
    {

        /// <summary>
        /// Adds the REST client factory services to the dependency injection container.
        /// </summary>
        /// <param name="services">The <see cref="IServiceCollection"/> to add the services to. Must not be null.</param>
        /// <returns>The updated <see cref="IServiceCollection"/> instance.</returns>
        /// <remarks>
        /// This method registers the <see cref="IOptionClientFactory"/> and <see cref="IRestClientFactory"/> as singleton services in the dependency injection container.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var services = new ServiceCollection();
        /// services.AddRestClientFactory();
        /// var serviceProvider = services.BuildServiceProvider();
        /// var restClientFactory = serviceProvider.GetRequiredService&lt;IRestClientFactory&gt;();
        /// </code>
        /// </example>
        public static IServiceCollection AddRestClientFactory(this IServiceCollection services)
        {
            services.AddSingleton<IOptionClientFactory, OptionClientFactory>();
            services.AddSingleton<IRestClientFactory, RestClientFactory>();
            return services;
        }

    }


}
