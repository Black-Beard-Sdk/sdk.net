// Ignore Spelling: Ioc

using Bb.ComponentModel;
using Bb.ComponentModel.Factories;
using Bb.ComponentModel.Loaders;
using Bb.Loaders.Extensions;

namespace Bb.Extensions
{

    /// <summary>
    /// Extension methods for configuring types in a web application.
    /// </summary>
    public static class TypesExtension
    {

        /// <summary>
        /// Appends configuration settings by discovering types exposed by attributes.
        /// </summary>
        /// <param name="configuration">The <see cref="ConfigurationManager"/> instance to append configuration to. Must not be null.</param>
        /// <param name="serviceProvider">The <see cref="LocalServiceProvider"/> used to resolve dependencies. Must not be null.</param>
        /// <remarks>
        /// This method discovers types exposed by attributes and resolves their configurations using the provided service provider.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var configuration = new ConfigurationManager();
        /// var serviceProvider = new LocalServiceProvider();
        /// configuration.AppendConfiguration(serviceProvider);
        /// </code>
        /// </example>
        public static void AppendConfiguration(this ConfigurationManager configuration, LocalServiceProvider serviceProvider)
        {
            ConstantsCore.Configuration.DiscoverTypeExposedByAttribute(type =>
            {
                configuration.ResolveConfiguration(type, (t, n, c) =>
                {
                });
            });
        }

        /// <summary>
        /// Configures the web application builder by setting up dependency injection for all discovered types.
        /// </summary>
        /// <param name="builder">The <see cref="WebApplicationBuilder"/> instance to configure. Must not be null.</param>
        /// <param name="filter">A filter function to determine which types to register. Must not be null.</param>
        /// <returns>The configured <see cref="WebApplicationBuilder"/> instance.</returns>
        /// <remarks>
        /// This method discovers all types with the <c>[ExposeClass]</c> attribute, binds their configurations, and registers them in the dependency injection container.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var builder = WebApplication.CreateBuilder(args);
        /// builder.SetAllIoc((type, context) => true);
        /// var app = builder.Build();
        /// app.Run();
        /// </code>
        /// </example>
        public static WebApplicationBuilder SetAllIoc(this WebApplicationBuilder builder, Func<Type, string, bool> filter)
        {

            var services = builder.Services;

            services.AddOptions();
            services.AddSingleton(typeof(OptionsServices), new OptionsServices(services));


            // Auto discover all types with attribute [ExposeClass] and register in ioc.
            services.UseTypeExposedByAttribute(builder.Configuration, ConstantsCore.Configuration, filter, c =>
            {
                services.BindConfiguration(c, builder.Configuration); // Bind the configuration before register the type in the ioc
            });

            services.UseTypeExposedByAttribute(builder.Configuration, ConstantsCore.Model, filter, c =>
            {

            });

            services.UseTypeExposedByAttribute(builder.Configuration, ConstantsCore.Service, filter, c =>
            {

            });

            services.AutoConfigure(null, ConstantsCore.Initialization);

            return builder;

        }

    }

}
