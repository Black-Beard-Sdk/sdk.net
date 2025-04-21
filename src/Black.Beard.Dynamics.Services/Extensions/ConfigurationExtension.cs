using Bb.ComponentModel.Factories;
using Bb.ComponentModel.Loaders;
using Bb.ComponentModel;
using System.Reflection;
using System.Diagnostics;
using Bb.ComponentModel.Attributes;
using Bb.Configurations;
using Bb.Services;

namespace Bb.Extensions
{

    /// <summary>
    /// Extension methods for configuring types in a web application.
    /// </summary>
    public static class ConfigurationExtension
    {

        /// <summary>
        /// Load configuration and discover all methods for loading configuration
        /// </summary>
        /// <param name="builder"><see cref="IConfigurationBuilder"/> </param>
        /// <param name="filter">filter to validate files</param>
        /// <param name="pattern">pattern globing</param>
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
        public static WebApplicationBuilder LoadConfiguration(this WebApplicationBuilder builder, Func<FileInfo, bool>? filter = null, string? pattern = null)
        {
            builder.Configuration.LoadConfiguration(filter, pattern);
            builder.Configuration.ConfigureApplication(builder);
            return builder;
        }

        /// <summary>
        /// Load configurations file, secret keys, environment variables, ...
        /// </summary>
        /// <param name="builder">application builder <see href="IConfigurationBuilder" /></param>
        /// <param name="filter">filter to validate files</param>
        /// <param name="pattern">pattern globing</param>
        /// <returns><see href="IConfigurationBuilder" /></returns>
        private static IConfigurationBuilder LoadConfiguration(this IConfigurationBuilder builder, Func<FileInfo, bool>? filter, string? pattern = null)
        {

            builder.LoadConfigurationFiles(pattern, filter); // Load all files in the paths.

            Assembly? assembly = Assembly.GetEntryAssembly();
            if (assembly != null)
                builder.AddUserSecrets(assembly);

            builder.AddEnvironmentVariables()
                  .AddCommandLine(Environment.GetCommandLineArgs())
                  ;

            return builder;
        }


        #region Load configuration from files

        private static IConfigurationBuilder LoadConfigurationFiles(this IConfigurationBuilder config,
            string? pattern,
            Func<FileInfo, bool>? filter)
        {

            ContentFolder contentFolder = StaticContainer.Get<GlobalConfiguration>()[GlobalConfiguration.Configuration];
            ConfigurationLoader files = new ConfigurationLoader(pattern).AddFolders(contentFolder.GetPaths());

            foreach (var file in files)
            {

                var c = file.Count();
                FileInfo? f = null;
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

                if (f != null && (filter == null || filter(f)))
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


        private static IConfigurationBuilder ConfigureApplication(this IConfigurationBuilder config, WebApplicationBuilder builder)
        {

            var s = new LocalServiceProvider(builder.Services.BuildServiceProvider())
                //.Add(typeof(WebHostBuilderContext), hostingContext)
                ;

            // search in all loaded assemblies the class with the attribute ExposeClassAttribute and exposing IInjectBuilder<IConfigurationBuilder>
            config.AutoConfigure(s, ConstantsCore.Initialization);

            return config;

        }



    }

}
