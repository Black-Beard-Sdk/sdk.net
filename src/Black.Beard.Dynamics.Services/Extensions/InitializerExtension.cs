
using Bb.ComponentModel.Factories;
using Bb.ComponentModel.Attributes;
using Bb.ComponentModel.Loaders;
using Bb.ComponentModel;
using Microsoft.AspNetCore.Components;
using Site.Services;
using System.Reflection;
using Bb;
using Bb.Loaders.Extensions;
using Bb.Configurations;
using Bb.Models;
using Bb.Services;

namespace Bb.Extensions
{

    public static class InitializerExtension
    {

        static InitializerExtension()
        {

            ObjectCreatorByIoc.SetInjectionAttribute<InjectAttribute>();

        }

        public static void LoadAssemblies(params string[] paths)
        {

            StartupConfiguration startupConfiguration = ResolveConfiguration();

            AppendFoldersToDiscovers(paths, startupConfiguration);
            LoadAssemblies(startupConfiguration);
            LoadPackages(startupConfiguration);

            // Ensure all required assemblies are loaded
            var search = new AddonsResolver()
                    .WithReference(typeof(ExposeClassAttribute))
                    .SearchAssemblies()
                    .ToList()
                    .EnsureIsLoaded()
                    ;

        }

        private static void LoadPackages(StartupConfiguration startupConfiguration)
        {
            if (startupConfiguration.Packages != null)
            {

                var manager = new PackageManager(null)
                    .WithReference(typeof(ExposeClassAttribute))
                    ;

                var repNuget = StaticContainer.Get<GlobalConfiguration>()[GlobalConfiguration.Nuget];
                var nugetPaths = repNuget.GetPaths();
                if (nugetPaths.Length > 0)
                    manager.SetTarget(nugetPaths[0]);
                manager.Resolve(startupConfiguration.Packages).Wait();
                manager.Assemblies.ToList();

            }
        }

        private static void LoadAssemblies(StartupConfiguration startupConfiguration)
        {
            if (startupConfiguration.AssemblyNames != null && startupConfiguration.AssemblyNames.Count > 0)
                foreach (var assemblyName in startupConfiguration.AssemblyNames)
                    AssemblyLoader.Instance.LoadAssemblyName(assemblyName);
        }

        private static void AppendFoldersToDiscovers(string[] paths, StartupConfiguration startupConfiguration)
        {
            if (paths != null || paths.Length > 0)
                AssemblyDirectoryResolver.Instance.AddDirectories(paths);
            if (startupConfiguration.Folders != null && startupConfiguration.Folders.Count > 0)
                foreach (var assemblyName in startupConfiguration.Folders)
                    AssemblyDirectoryResolver.Instance.AddDirectories(startupConfiguration.Folders);
        }

        private static StartupConfiguration ResolveConfiguration()
        {
            StartupConfiguration startupConfiguration;
            var o = StaticContainer.Get<GlobalConfiguration>()[GlobalConfiguration.Configuration];
            var _files = o.GetFiles("StartupConfiguration.json").ToArray();
            if (_files.Any())
                startupConfiguration = _files[0].LoadFromFileAndDeserializeConfiguration<StartupConfiguration>();
            else
                startupConfiguration = new StartupConfiguration();
            return startupConfiguration;
        }

        public static WebApplicationBuilder Initialize(this WebApplicationBuilder self)
        {

            var SchemasPaths = Assembly.GetExecutingAssembly().GetDirectory().Combine("schemas");
            var idTemplate = "http://Black.Beard.com/schema/{0}";
            SchemaGenerator.Initialize(SchemasPaths, idTemplate);


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

        public static WebApplication Initialize(this WebApplication self)
        {

            self.AutoConfigure
            (
                self.Services,
                ConstantsCore.Initialization,
                c =>
                {
                    //c.WithInjectValue(name => self.Configuration.GetValue<string>(name));
                },
                d =>
                {
                    //d.WithInjectValue(name => self.Configuration.GetValue<string>(name));
                },
                e =>
                {
                    e.WithInjectValue(name => self.Configuration.GetValue<string>(name));
                }
                );

            return self;
        }

    }

}
