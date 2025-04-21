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

        public static WebService GetWebService(int port, Action<WebService>? initializer = null)
        {

            var name = Assembly.GetExecutingAssembly().GetName().Name;
            // create folder for config, schema and .nugets
            var conf = StaticContainer.Set(new GlobalConfiguration())
                .SetRoot(name.GetTempPath())
                .WithRelatedDirectory(GlobalConfiguration.Configuration,    ".configs")
                .WithRelatedDirectory(GlobalConfiguration.Schema,           ".schemas")
                .WithRelatedDirectory(GlobalConfiguration.Nuget,            ".nugets")
                .WithRelatedDirectory(GlobalConfiguration.Logs,             ".logs")
                ;

            // Environment.CurrentDirectory
            // Assembly.GetEntryAssembly().GetDirectory().FullName
            // Assembly.GetExecutingAssembly().GetDirectory().FullName

            conf.AppendDocument(GlobalConfiguration.Configuration,
                new StartupConfiguration()
                {
                    Packages = ["Black.Beard.ComponentModel"],
                });

            InitializerExtension.LoadAssemblies();

            var web = new WebService()
                            .WithHTTP(port)
                            .UseStartup<Startup>();

            web.Build();

            initializer?.Invoke(web);

            return web;

        }

    }


}
