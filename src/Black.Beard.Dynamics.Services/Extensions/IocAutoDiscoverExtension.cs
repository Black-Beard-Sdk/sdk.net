using Bb.ComponentModel.Attributes;
using Bb.ComponentModel.Factories;
using Bb.Configurations;
using Site.Services;
using System.Diagnostics;
using System.Reflection;

namespace Bb.Extensions
{


    public static class IocAutoDiscoverExtension
    {

        static IocAutoDiscoverExtension()
        {
            _methodRegister = typeof(IocAutoDiscoverExtension).GetMethod(nameof(AddType), BindingFlags.NonPublic | BindingFlags.Static);
            _methodOptionConfiguration = typeof(IocAutoDiscoverExtension).GetMethod(nameof(BindConfiguration), BindingFlags.NonPublic | BindingFlags.Static);            
        }

        public static void DiscoverTypeExposedByAttribute(this string contextKey, Action<Type> action = null)
        {

            if (action != null)
                foreach (var type in GetExposedTypes(contextKey))
                    action(type);

        }

        public static IServiceCollection UseTypeExposedByAttribute(this IServiceCollection services, IConfiguration configuration, string contextKey, Func<Type, string, bool> filter, Action<Type> action = null)
        {

            if (filter == null)
                filter = (c, d) => true;

            contextKey.DiscoverTypeExposedByAttribute(type =>
            {

                if (filter(type, contextKey))
                {

                    _methodRegister.MakeGenericMethod(type).Invoke(null, new object[] { services, configuration });

                    if (action != null)
                        action(type);
                }

            });

            return services;

        }

        public static IServiceCollection BindConfiguration(this IServiceCollection self, Type type, IConfiguration configuration)
        {
            _methodOptionConfiguration.MakeGenericMethod(type)
                .Invoke(self, new object[] { self, configuration });
            return self;
        }

        /// <summary>
        /// Gets the exposed types in loaded assemblies.
        /// </summary>
        /// <param name="contextName">Name of the context.</param>
        /// <returns></returns>
        public static IEnumerable<Type> GetExposedTypes(string contextName)
        {
            var items = ComponentModel.TypeDiscovery.Instance
                .GetTypesWithAttributes<ExposeClassAttribute>(typeof(object), c => c.Context == contextName);
            return items;
        }

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
            var exposed = attribute?.ExposedType ?? typeof(T);
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

        private static void RegisterType<T>(this IServiceCollection services, Func<IServiceProvider, T> func, IocScopeEnum lifeCycle, Type exposedType)
            where T : class
        {

            switch (lifeCycle)
            {

                case IocScopeEnum.Scoped:
                    services.AddScoped(exposedType, func);
                    break;

                case IocScopeEnum.Singleton:
                    services.AddSingleton(exposedType, func);
                    break;

                default:
                case IocScopeEnum.Transiant:
                    services.AddTransient(exposedType, func);
                    break;

            }


        }

        private static void RegisterType<T>(this IServiceCollection services, IocScopeEnum lifeCycle, Type exposedType)
            where T : class
        {

            switch (lifeCycle)
            {

                case IocScopeEnum.Singleton:
                    services.AddSingleton(exposedType, typeof(T));
                    break;

                case IocScopeEnum.Scoped:
                    services.AddScoped(exposedType, typeof(T));
                    break;

                case IocScopeEnum.Transiant:
                default:
                    services.AddTransient(exposedType, typeof(T));
                    break;

            }

        }

        private static readonly MethodInfo? _methodRegister;
        private static readonly MethodInfo? _methodOptionConfiguration;
        private static readonly MethodInfo? _methodConfiguration;
        private static readonly MethodInfo? _methodModel;
        private static readonly MethodInfo? _methodService;

    }


}
