using Bb.ComponentModel.Factories;
using Bb.ComponentModel.Attributes;
using Bb.ComponentModel.Loaders;
using Bb.ComponentModel;
using Microsoft.AspNetCore.Components;
using Site.Services;
using System.Reflection;
using Bb.Configurations;
using Bb.Models;
using Bb.Services;

namespace Bb.Extensions
{

    /// <summary>
    /// Provides extension methods for initializing and configuring the application.
    /// </summary>
    public static class InitializerExtension
    {

        static InitializerExtension()
        {

            ObjectCreatorByIoc.SetInjectionAttribute<InjectAttribute>();

        }

        /// <summary>
        /// Loads assemblies and packages based on the provided paths and configuration.
        /// </summary>
        /// <param name="paths">An array of folder paths to search for assemblies. Can be null.</param>
        /// <remarks>
        /// This method resolves the startup configuration, appends folders to the discovery process, and loads assemblies and packages.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// InitializerExtension.LoadAssemblies("C:\\MyAssemblies", "D:\\MoreAssemblies");
        /// </code>
        /// </example>
        public static void LoadAssemblies(params string[] paths)
        {

            StartupConfiguration startupConfiguration = ResolveConfiguration();

            AppendFoldersToDiscovers(paths, startupConfiguration);
            LoadAssemblies(startupConfiguration);
            LoadPackages(startupConfiguration);

            // Ensure all required assemblies are loaded
            new AddonsResolver()
                    .WithReference(typeof(ExposeClassAttribute))
                    .SearchAssemblies()
                    .AsEnumerable()
                    .EnsureIsLoaded()
                    ;

        }

        /// <summary>
        /// Loads packages specified in the startup configuration.
        /// </summary>
        /// <param name="startupConfiguration">The startup configuration containing package information. Must not be null.</param>
        /// <remarks>
        /// This method resolves and loads packages using the package manager and ensures that all required assemblies are loaded.
        /// </remarks>
        private static void LoadPackages(StartupConfiguration startupConfiguration)
        {

            if (startupConfiguration.Packages != null)
            {

                var manager = new PackageManager(null)
                    .WithReference(typeof(ExposeClassAttribute))
                    ;

                var repNuget = StaticContainer
                    .Get<GlobalConfiguration>()[GlobalConfiguration.Nuget];
                var nugetPaths = repNuget.GetPaths();
                if (nugetPaths.Length > 0)
                    manager.SetTarget(nugetPaths[0]);
                manager.Resolve(startupConfiguration.Packages).Wait();

                var item = manager.Assemblies.Where(c => !c.IsLoaded && c.Assembly == null).ToArray();
                item.EnsureIsLoaded();

            }


        }

        /// <summary>
        /// Loads assemblies specified in the startup configuration.
        /// </summary>
        /// <param name="startupConfiguration">The startup configuration containing assembly names. Must not be null.</param>
        /// <remarks>
        /// This method loads assemblies by their names as specified in the startup configuration.
        /// </remarks>
        private static void LoadAssemblies(StartupConfiguration startupConfiguration)
        {
            if (startupConfiguration.AssemblyNames != null && startupConfiguration.AssemblyNames.Count > 0)
                foreach (var assemblyName in startupConfiguration.AssemblyNames)
                    AssemblyLoader.Instance.LoadAssemblyName(assemblyName);
        }

        /// <summary>
        /// Appends folders to the assembly discovery process.
        /// </summary>
        /// <param name="paths">An array of folder paths to add. Can be null.</param>
        /// <param name="startupConfiguration">The startup configuration containing additional folders. Must not be null.</param>
        /// <remarks>
        /// This method adds the specified paths and folders from the startup configuration to the assembly directory resolver.
        /// </remarks>
        private static void AppendFoldersToDiscovers(string[] paths, StartupConfiguration startupConfiguration)
        {
            if (paths != null && paths.Length > 0)
                AssemblyDirectoryResolver.Instance.AddDirectories(paths);
            if (startupConfiguration.Folders != null && startupConfiguration.Folders.Count > 0)
                AssemblyDirectoryResolver.Instance.AddDirectories(startupConfiguration.Folders);
        }

        /// <summary>
        /// Resolves the startup configuration from the global configuration.
        /// </summary>
        /// <returns>A <see cref="StartupConfiguration"/> object containing the resolved configuration.</returns>
        /// <remarks>
        /// This method retrieves the startup configuration document from the global configuration or creates a new one if not found.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var config = InitializerExtension.ResolveConfiguration();
        /// Console.WriteLine($"Configuration loaded: {config}");
        /// </code>
        /// </example>
        private static StartupConfiguration ResolveConfiguration()
        {
            var o = StaticContainer.Get<GlobalConfiguration>();
            var startupConfiguration = o.GetDocument<StartupConfiguration>(GlobalConfiguration.Configuration)
                ?? new StartupConfiguration();
            return startupConfiguration;
        }

        /// <summary>
        /// Initializes the application builder with custom configurations.
        /// </summary>
        /// <param name="self">The <see cref="WebApplicationBuilder"/> instance to initialize. Must not be null.</param>
        /// <returns>The configured <see cref="WebApplicationBuilder"/> instance.</returns>
        /// <remarks>
        /// This method sets up schema generation, auto-configuration, and trace configuration for the application builder.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var builder = WebApplication.CreateBuilder(args);
        /// builder.Initialize();
        /// var app = builder.Build();
        /// app.Run();
        /// </code>
        /// </example>
        public static WebApplicationBuilder Initialize(this WebApplicationBuilder self)
        {


            #region initialize Schema

            ContentFolder contentFolder = StaticContainer.Get<GlobalConfiguration>()[GlobalConfiguration.Schema];
            if (!contentFolder.Any)
            {
                var SchemasPaths = Assembly.GetExecutingAssembly()
                    .GetDirectory().Combine("Schemas");
                contentFolder.AddDirectory(SchemasPaths);
            }
            var path = contentFolder.GetPaths().First();
            var idTemplate = "http://Black.Beard.com/schema/{0}";
            SchemaGenerator.Initialize(path, idTemplate);

            #endregion initialize Schema

            self.LoadConfiguration(null, null);

            self.AutoConfigure
            (
                self.Services.BuildServiceProvider(),
                ConstantsCore.Initialization,
                c =>
                {
                    c.WithInjectValue(name => self.Configuration.GetValue<string>(name));
                },
                d =>
                {

                },
                e =>
                {
                }
                );


            new AddonsResolver()
             .WithReference(typeof(ExposeClassAttribute))
             .SearchAssemblies()
             .EnsureIsLoaded()
             ;

            self.ConfigureTrace();

            return self;

        }

        /// <summary>
        /// Initializes the web application with custom configurations.
        /// </summary>
        /// <param name="self">The <see cref="WebApplication"/> instance to initialize. Must not be null.</param>
        /// <returns>The configured <see cref="WebApplication"/> instance.</returns>
        /// <remarks>
        /// This method sets up auto-configuration for the web application.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var builder = WebApplication.CreateBuilder(args);
        /// var app = builder.Build();
        /// app.Initialize();
        /// app.Run();
        /// </code>
        /// </example>
        public static WebApplication Initialize(this WebApplication self)
        {

            self.AutoConfigure
            (
                self.Services,
                ConstantsCore.Initialization, null, null,
                  e =>
                  {
                      e.WithInjectValue(name => self.Configuration.GetValue<string>(name));
                  }
                );

            return self;
        }

    }

}
