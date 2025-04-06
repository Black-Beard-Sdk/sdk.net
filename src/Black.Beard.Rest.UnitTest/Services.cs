using Bb.Services;
using Bb;
using Bb.Extensions;
using System.Reflection;
using Bb.Configurations;
using Bb.Models;

namespace Black.Beard.Rest.UnitTest
{
    internal static class Services
    {

        public static WebService GetWebService(int port, Action<WebService> initializer = null)
        {

            var name = Assembly.GetExecutingAssembly().GetName().Name;
            // create folder for config, schemas and .nugets
            var conf = StaticContainer.Set(new GlobalConfiguration())
                .SetRoot(name.GetTempPath())
                .WithRelatedDirectory(GlobalConfiguration.Configuration, "Configs")
                .WithRelatedDirectory(GlobalConfiguration.Schema, "Schemas")
                .WithRelatedDirectory(GlobalConfiguration.Nuget, ".nugets")
                .WithRelatedDirectory(GlobalConfiguration.Logs, "logs")
                ;

            conf.AppendDocument(GlobalConfiguration.Configuration,
                new StartupConfiguration()
                {
                    Packages = ["Black.Beard.ComponentModel"],
                });

            InitializerExtension.LoadAssemblies(null);

            var web = new WebService()
                            .WithHTTP(port)
                            .UseStartup<Startup>(c =>
                            {
                                //c.UseCertificate = "";
                                //c.UseSourceCertificate =  Bb.Loaders.SourceCertificate.File;
                                //c.UsePasswordCertificate = "password";
                            });
            web.Build();

            initializer?.Invoke(web);

            return web;

        }

    }


}
