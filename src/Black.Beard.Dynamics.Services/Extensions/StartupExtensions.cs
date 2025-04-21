using Bb.ComponentModel.Factories;
using ICSharpCode.Decompiler.CSharp.Syntax;

namespace Bb.Extensions
{

    /// <summary>
    /// Extension methods for configuring the startup process of a web application.
    /// </summary>
    public static class StartupExtensions
    {
        /// <summary>
        /// Checks if a specific service type exists in the service collection.
        /// </summary>
        /// <typeparam name="T">The type of the service to check for.</typeparam>
        /// <param name="self">The <see cref="IServiceCollection"/> to check. Must not be null.</param>
        /// <returns><see langword="true"/> if the service type exists; otherwise, <see langword="false"/>.</returns>
        /// <remarks>
        /// This method iterates through the service collection to determine if a specific service type has been registered.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var services = new ServiceCollection();
        /// bool exists = services.TestExist&lt;IMyService&gt;();
        /// Console.WriteLine($"Service exists: {exists}");
        /// </code>
        /// </example>
        public static bool TestExist<T>(this IServiceCollection self)
        {
            return self.Any(c => c.ServiceType == typeof(T));
        }

        /// <summary>
        /// Configures the web application builder using a specified startup class.
        /// </summary>
        /// <typeparam name="TStartup">The type of the startup class.</typeparam>
        /// <param name="builder">The <see cref="WebApplicationBuilder"/> instance to configure. Must not be null.</param>
        /// <param name="startup">The instance of the startup class. Must not be null.</param>
        /// <param name="serviceProvider">The local service provider to resolve dependencies. Must not be null.</param>
        /// <returns>The configured <see cref="WebApplicationBuilder"/> instance.</returns>
        /// <remarks>
        /// This method invokes the "ConfigureServices" method of the specified startup class to configure services for the application.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var builder = WebApplication.CreateBuilder(args);
        /// var startup = new MyStartup();
        /// builder.UseStartup(startup, new LocalServiceProvider());
        /// var app = builder.Build();
        /// app.Run();
        /// </code>
        /// </example>
        public static WebApplicationBuilder UseStartup<TStartup>(this WebApplicationBuilder builder, TStartup startup, LocalServiceProvider serviceProvider)
        {
            var configureServicesMethod = typeof(TStartup).GetMethod("ConfigureServices");
            if (configureServicesMethod != null)
            {
                var args = ResolveParameters(serviceProvider, configureServicesMethod);
                configureServicesMethod.Invoke(startup, args);
            }
            return builder;
        }

        /// <summary>
        /// Configures the web application using a specified startup class.
        /// </summary>
        /// <typeparam name="TStartup">The type of the startup class.</typeparam>
        /// <param name="application">The <see cref="WebApplication"/> instance to configure. Must not be null.</param>
        /// <param name="startup">The instance of the startup class. Must not be null.</param>
        /// <param name="serviceProvider">The local service provider to resolve dependencies. Must not be null.</param>
        /// <returns>The configured <see cref="WebApplication"/> instance.</returns>
        /// <remarks>
        /// This method invokes the "Configure" method of the specified startup class to configure the application's request pipeline.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var builder = WebApplication.CreateBuilder(args);
        /// var application = builder.Build();
        /// var startup = new MyStartup();
        /// application.UseStartupConfigure(startup, new LocalServiceProvider());
        /// application.Run();
        /// </code>
        /// </example>
        public static WebApplication UseStartupConfigure<TStartup>(this WebApplication application, TStartup startup, LocalServiceProvider serviceProvider)
        {
            var configureMethod = typeof(TStartup).GetMethod("Configure");
            if (configureMethod != null)
            {
                var args = ResolveParameters(serviceProvider, configureMethod);
                configureMethod.Invoke(startup, new object[] { application, application.Environment });
            }
            return application;
        }

        /// <summary>
        /// Resolves the parameters required by a method using the local service provider.
        /// </summary>
        /// <param name="serviceProvider">The local service provider to resolve dependencies. Must not be null.</param>
        /// <param name="configureServicesMethod">The method whose parameters need to be resolved. Must not be null.</param>
        /// <returns>An array of resolved parameter objects.</returns>
        /// <remarks>
        /// This method resolves the parameters of a method by retrieving the required services from the local service provider.
        /// </remarks>
        /// <exception cref="InvalidOperationException">
        /// Thrown if a required service cannot be resolved.
        /// </exception>
        private static object?[] ResolveParameters(LocalServiceProvider serviceProvider, System.Reflection.MethodInfo configureServicesMethod)
        {
            var parameters = configureServicesMethod.GetParameters();
            List<object?> args = new List<object?>(parameters.Length);
            foreach (var item in parameters)
            {
                object? srv = serviceProvider.GetService(item.ParameterType);
                args.Add(srv);
            }
            return args.ToArray();
        }
    }
}
