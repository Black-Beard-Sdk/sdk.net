// Ignore Spelling: Ioc

using Bb.ComponentModel.Attributes;
using Bb.ComponentModel.Factories;
using Bb.Configurations;
using Site.Services;
using System.Diagnostics;
using System.Reflection;

namespace Bb.Extensions
{


    /// <summary>
    /// Provides extension methods for discovering and registering types exposed by attributes in the context of dependency injection.
    /// </summary>
    public static class IocAutoDiscoverExtension
    {

        static IocAutoDiscoverExtension()
        {
            var bindings = BindingFlags.NonPublic | BindingFlags.Static;
            _methodRegister = typeof(IocAutoDiscoverExtension).GetMethod(nameof(AddType), bindings);
            _methodOptionConfiguration = typeof(IocAutoDiscoverExtension).GetMethod(nameof(BindConfiguration), bindings);            
        }

        /// <summary>
        /// Discovers types exposed by attributes in the specified context and applies an action to each type.
        /// </summary>
        /// <param name="contextKey">The context key used to filter exposed types. Must not be null.</param>
        /// <param name="action">An optional action to apply to each discovered type. Can be null.</param>
        /// <remarks>
        /// This method retrieves all types exposed by attributes in the specified context and optionally applies a user-defined action to each type.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// "MyContext".DiscoverTypeExposedByAttribute(type => Console.WriteLine(type.Name));
        /// </code>
        /// </example>
        public static void DiscoverTypeExposedByAttribute(this string contextKey, Action<Type>? action = null)
        {

            if (action != null)
                foreach (var type in GetExposedTypes(contextKey))
                    action(type);

        }

        /// <summary>
        /// Registers types exposed by attributes in the specified context into the service collection.
        /// </summary>
        /// <param name="services">The <see cref="IServiceCollection"/> to register the types into. Must not be null.</param>
        /// <param name="configuration">The application configuration. Must not be null.</param>
        /// <param name="contextKey">The context key used to filter exposed types. Must not be null.</param>
        /// <param name="filter">A filter function to determine which types to register. Can be null.</param>
        /// <param name="action">An optional action to apply to each registered type. Can be null.</param>
        /// <returns>The updated <see cref="IServiceCollection"/> instance.</returns>
        /// <remarks>
        /// This method discovers types exposed by attributes in the specified context, applies an optional filter, and registers them into the service collection.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var services = new ServiceCollection();
        /// services.UseTypeExposedByAttribute(configuration, "MyContext", (type, context) => true, type => Console.WriteLine($"Registered: {type.Name}"));
        /// </code>
        /// </example>
        public static IServiceCollection UseTypeExposedByAttribute(this IServiceCollection services, IConfiguration configuration, string contextKey, Func<Type, string, bool> filter, Action<Type>? action = null)
        {

            if (filter == null)
                filter = (c, d) => true;

            contextKey.DiscoverTypeExposedByAttribute(type =>
            {

                if (filter(type, contextKey))
                {

                    _methodRegister?.MakeGenericMethod(type).Invoke(null, new object[] { services, configuration });

                    if (action != null)
                        action(type);
                }

            });

            return services;

        }

        /// <summary>
        /// Binds a configuration section to a specified options type.
        /// </summary>
        /// <param name="self">The <see cref="IServiceCollection"/> to bind the configuration to. Must not be null.</param>
        /// <param name="type">The type of the options to bind. Must not be null.</param>
        /// <param name="configuration">The application configuration. Must not be null.</param>
        /// <returns>The updated <see cref="IServiceCollection"/> instance.</returns>
        /// <remarks>
        /// This method binds a configuration section to a specified options type and validates the data annotations.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var services = new ServiceCollection();
        /// services.BindConfiguration(typeof(MyOptions), configuration);
        /// </code>
        /// </example>
        public static IServiceCollection BindConfiguration(this IServiceCollection self, Type type, IConfiguration configuration)
        {
            _methodOptionConfiguration?.MakeGenericMethod(type)
                .Invoke(self, new object[] { self, configuration });
            return self;
        }

        /// <summary>
        /// Gets the exposed types in loaded assemblies filtered by a context name.
        /// </summary>
        /// <param name="contextName">The name of the context to filter exposed types. Must not be null.</param>
        /// <returns>An enumerable of <see cref="Type"/> objects representing the exposed types.</returns>
        /// <remarks>
        /// This method retrieves all types in loaded assemblies that are exposed by the <see cref="ExposeClassAttribute"/> and match the specified context name.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var types = IocAutoDiscoverExtension.GetExposedTypes("MyContext");
        /// foreach (var type in types)
        /// {
        ///     Console.WriteLine(type.Name);
        /// }
        /// </code>
        /// </example>
        public static IEnumerable<Type> GetExposedTypes(string contextName)
        {
            var items = ComponentModel.TypeDiscovery.Instance
                .GetTypesWithAttributes<ExposeClassAttribute>(typeof(object), c => c.Context == contextName);
            return items;
        }

        /// <summary>
        /// Gets the exposed types in loaded assemblies filtered by a custom filter function.
        /// </summary>
        /// <param name="filter">A filter function to apply to the <see cref="ExposeClassAttribute"/>. Must not be null.</param>
        /// <returns>An enumerable of <see cref="Type"/> objects representing the exposed types.</returns>
        /// <remarks>
        /// This method retrieves all types in loaded assemblies that are exposed by the <see cref="ExposeClassAttribute"/> and match the specified filter.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var types = IocAutoDiscoverExtension.GetExposedTypes(attr => attr.Context == "MyContext");
        /// foreach (var type in types)
        /// {
        ///     Console.WriteLine(type.Name);
        /// }
        /// </code>
        /// </example>
        public static IEnumerable<Type> GetExposedTypes(Func<ExposeClassAttribute, bool> filter)
        {
            var items = ComponentModel.TypeDiscovery.Instance
                .GetTypesWithAttributes<ExposeClassAttribute>(typeof(object), c => filter(c));
            return items;
        }


        private static void BindConfiguration<TOptions>(this IServiceCollection self, IConfiguration configuration)
            where TOptions : class
        {

            configuration.ResolveConfiguration(typeof(TOptions), (type, sectionName, section) =>
            {

                if (section != null)
                {
                    var opt = self.AddOptions<TOptions>();
                    opt.Bind(section)
                       .ValidateDataAnnotations();
                }

                else
                    Trace.TraceWarning("section {0} not found", sectionName);

            });

        }

        /// <summary>
        /// Resolves a configuration section for a specified type and applies an action to it.
        /// </summary>
        /// <param name="configuration">configuration that provide the section for resolve the mapping</param>
        /// <param name="type"></param>
        /// <param name="action"></param>
        public static void ResolveConfiguration(this IConfiguration configuration, Type type, Action<Type, string, IConfigurationSection> action)
        {

            SchemaGenerator.GenerateSchema(type);

            var id = new Uri("http://example.com/schema/TestGeneratedSchema");
            var schema = type.GenerateSchemaForConfiguration(id);

            var attribute = type.GetCustomAttribute<ExposeClassAttribute>();
            var sectionName = !string.IsNullOrEmpty(attribute?.Name) ? attribute.Name : type.Name;

            var section = configuration.GetSection(sectionName);

            action(type, sectionName, section);

        }

        private static void AddType<T>(this IServiceCollection services, IConfiguration configuration)
            where T : class
        {

            var attribute = typeof(T).GetCustomAttribute<ExposeClassAttribute>();
            if (attribute != null)
            {
                var exposed = attribute.ExposedType ?? typeof(T);
                var i = typeof(IInitialize).IsAssignableFrom(typeof(T));
                var c = IocConstructorAttribute.GetMethods(typeof(T)).Any();

                if (i || c)
                {
                    var serviceBuilder = ObjectCreatorByIoc.GetActivator<T>();
                    Func<IServiceProvider, T> _func = (serviceProvider) => serviceBuilder.Call(null, serviceProvider);
                    services.RegisterType(_func, attribute.LifeCycle, exposed);
                }
                else
                    services.RegisterType<T>(attribute.LifeCycle, exposed);

                Trace.TraceInformation($"registered {attribute.Context} {typeof(T).Name} exposed by {exposed.Name} with life-cycle {attribute.LifeCycle.ToString()}");

            }
        }

        private static void RegisterType<T>(this IServiceCollection services, Func<IServiceProvider, T> func, IocScope lifeCycle, Type exposedType)
            where T : class
        {

            switch (lifeCycle)
            {

                case IocScope.Scoped:
                    services.AddScoped(exposedType, func);
                    break;

                case IocScope.Singleton:
                    services.AddSingleton(exposedType, func);
                    break;

                default:
                case IocScope.Transiant:
                    services.AddTransient(exposedType, func);
                    break;

            }


        }

        private static void RegisterType<T>(this IServiceCollection services, IocScope lifeCycle, Type exposedType)
            where T : class
        {

            switch (lifeCycle)
            {

                case IocScope.Singleton:
                    services.AddSingleton(exposedType, typeof(T));
                    break;

                case IocScope.Scoped:
                    services.AddScoped(exposedType, typeof(T));
                    break;

                case IocScope.Transiant:
                default:
                    services.AddTransient(exposedType, typeof(T));
                    break;

            }

        }

        private static readonly MethodInfo? _methodRegister;
        private static readonly MethodInfo? _methodOptionConfiguration;


    }


}
