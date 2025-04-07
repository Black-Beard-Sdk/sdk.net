using Bb.ComponentModel.Factories;
using Bb.ComponentModel.Loaders;
using Bb.ComponentModel;
using System.Reflection;
using System.Diagnostics;

namespace Bb.Extensions
{

    /// <summary>
    /// Extension methods for configuring types in a web application.
    /// </summary>
    public static class ConfigurationExtension
    {

        static ConfigurationExtension()
        {

        }

        /// <summary>
        /// Load configuration and discover all methods for loading configuration
        /// </summary>
        /// <param name="builder"><see cref="WebApplicationBuilder"/> </param>
        /// <example>
        /// <code lang="Csharp">
        /// var builder = WebApplication.CreateBuilder(args).LoadConfiguration();
        /// </code>
        /// If you want adding configuration, append a new class with the attribute <see cref="ExposeClassAttribute"/> and implement 
        /// the interface <see cref="IInjectBuilder{IConfigurationBuilder}"/>
        /// <code lang="Csharp">
        /// [ExposeClass(ConstantsCore.Initialization, ExposedType = typeof(IInjectBuilder&lt;IConfigurationBuilder>), LifeCycle = IocScopeEnum.Transiant)]
        /// public class ConfigurationInitializer : IInjectBuilder&lt;IConfigurationBuilder>
        /// {
        /// 
        ///     public string FriendlyName => typeof(ConfigurationInitializer).Name;
        ///     public Type Type => typeof(ConfigurationInitializer);
        ///     public object Execute(object context)
        ///     {
        ///         return Execute((IConfigurationBuilder) context);
        ///     }
        ///     
        ///     public bool CanExecute(object context)
        ///     {
        ///         return CanExecute((IConfigurationBuilder)context);
        ///     }
        /// 
        ///     public bool CanExecute(IConfigurationBuilder context)
        ///     {
        ///         var builtConfig = context.Build();
        ///         var canExecute = builtConfig["Initializer:" + FriendlyName];
        ///         if (canExecute != null)
        ///             if (!Convert.ToBoolean(canExecute))
        ///                 return false;
        ///         // place your code here
        ///         return true;
        ///     }
        /// 
        ///     public object Execute(IConfigurationBuilder context)
        ///     {
        ///         // place your code here
        ///         return context;
        ///     }
        ///     
        /// }
        /// </code>
        /// If you want deactivate a configuration loader, you can add a key in your configuration file like appsettings.json
        /// <code lang="json">
        /// "Initializer": {
        ///   "ConfigurationGitBuilderInitializer": true,
        ///   "ConfigurationVaultBuilderInitializer": true,
        /// },
        /// </code>
        /// </example>
        /// <returns></returns>
        public static WebApplicationBuilder LoadConfiguration(this WebApplicationBuilder builder, params string[] paths)
        {

            builder.WebHost.ConfigureAppConfiguration((hostingContext, config) =>
            {
                config.LoadConfiguration(paths, null, null);                   // Load all files in the paths.
                config.ConfigureApplication(hostingContext, builder);   // Resolve all injection class for loading configuration
            });

            return builder;

        }

        public static WebApplicationBuilder LoadConfiguration(this WebApplicationBuilder builder, string[] paths, Func<FileInfo, bool> filter)
        {

            builder.WebHost.ConfigureAppConfiguration((hostingContext, config) =>
            {
                config.LoadConfiguration(paths, filter, null);                   // Load all files in the paths.
                config.ConfigureApplication(hostingContext, builder);   // Resolve all injection class for loading configuration
            });

            return builder;

        }

        public static WebApplicationBuilder LoadConfiguration(this WebApplicationBuilder builder, string[] paths, Func<FileInfo, bool> filter, string pattern)
        {

            builder.WebHost.ConfigureAppConfiguration((hostingContext, config) =>
            {
                config.LoadConfiguration(paths, filter, pattern);                   // Load all files in the paths.
                config.ConfigureApplication(hostingContext, builder);   // Resolve all injection class for loading configuration
            });

            return builder;

        }

        public static IConfigurationBuilder LoadConfiguration(this IConfigurationBuilder builder, string[] paths, Func<FileInfo, bool> filter, string pattern)
        {

            builder.LoadConfigurationFile(paths, pattern, filter)   // Load all files in the paths.
                  .AddUserSecrets(Assembly.GetEntryAssembly())
                  .AddEnvironmentVariables()
                  .AddCommandLine(Environment.GetCommandLineArgs())
                  ;

            return builder;
        }


        #region Load configuration from files

        private static IConfigurationBuilder LoadConfigurationFile(this IConfigurationBuilder config,
            string[] paths,
            string pattern,
            Func<FileInfo, bool> filter)
        {

            var files = new ConfigurationLoader(pattern).AddFolders(paths);

            foreach (var file in files)
            {

                var c = file.Count();
                FileInfo f = null;
                if (c == 1)
                    f = file.FirstOrDefault().FileInfo;

                else if (c == 2) // one more it is because we have a file for environment and a file for all environment
                {

                    var f1 = file.FirstOrDefault(c => string.IsNullOrEmpty(c.Environment));
                    if (f1.FileInfo != null)
                        Load(config, f1.FileInfo);

                    var f2 = file.FirstOrDefault(c => !string.IsNullOrEmpty(c.Environment));
                    if (f2.FileInfo != null)
                        Load(config, f2.FileInfo);

                }

                if (f != null)
                    Load(config, f);

            }

            return config;

        }

        private static void Load(IConfigurationBuilder config, FileInfo f)
        {

            var type = FileContentTypeDetector.DetectFileType(f);
            switch (type)
            {

                case "JSON":
                    config.AddJsonFile(f.FullName, optional: false, reloadOnChange: false);
                    Trace.TraceInformation($"configuration file {f.FullName} is loaded.");
                    break;

                case "XML":
                    config.AddXmlFile(f.FullName, optional: false, reloadOnChange: false);
                    Trace.TraceInformation($"configuration file {f.FullName} is loaded.");
                    break;

                case "INI":
                    config.AddIniFile(f.FullName, optional: false, reloadOnChange: false);
                    Trace.TraceInformation($"configuration file {f.FullName} is loaded.");
                    break;

                case "PerKey":
                    config.AddKeyPerFile(f.FullName, optional: false, reloadOnChange: false);
                    Trace.TraceInformation($"configuration file {f.FullName} is loaded.");
                    break;

                default:
                    Trace.TraceWarning($"configuration file {f.FullName} is is not recognized.");
                    break;

            }
        }

        #endregion Load configuration from files


        private static IConfigurationBuilder ConfigureApplication(this IConfigurationBuilder config, WebHostBuilderContext hostingContext, WebApplicationBuilder builder)
        {

            var s = new LocalServiceProvider(builder.Services.BuildServiceProvider())
                .Add(typeof(WebHostBuilderContext), hostingContext);

            // search in all loaded assemblies the class with the attribute ExposeClassAttribute and exposing IInjectBuilder<IConfigurationBuilder>
            config.AutoConfigure(s, ConstantsCore.Initialization);

            return config;

        }



    }

}
