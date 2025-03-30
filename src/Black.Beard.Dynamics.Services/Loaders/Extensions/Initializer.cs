
using Bb.ComponentModel.Factories;
using Bb.ComponentModel.Attributes;
using Bb.ComponentModel.Loaders;
using Bb.ComponentModel;
using Microsoft.AspNetCore.Components;

namespace Bb.Loaders.Extensions
{

    public static class _Initializer
    {

        static _Initializer()
        {

            ObjectCreatorByIoc.SetInjectionAttribute<InjectAttribute>();

        }


        public static void LoadAssemblies(params string[] paths)
        {

            if (paths == null || paths.Length == 0)
                paths = [];

            var configPaths = ConfigurationFolder.GetPaths();

            var file = Assemblies.Resolve("ExposedAssemblyRepositories.json", configPaths);

            // Ensure all required assemblies are loaded
            var files = new AddonsResolver(paths)
                .With(file)
                .WithReference(typeof(ExposeClassAttribute))
                .SearchAssemblies()
                .ToList()
                ;

            files
                .EnsureIsLoaded()
                ;

        }

        public static WebApplicationBuilder Initialize(this WebApplicationBuilder self)
        {


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
