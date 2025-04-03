using Bb.ComponentModel;
using Bb.ComponentModel.Attributes;
using Bb.Configurations;
using Bb.Monitoring;
using NLog;
using NLog.Web;
using System.Diagnostics;

namespace Bb.Loaders
{


    [ExposeClass(ConstantsCore.Initialization, ExposedType = typeof(IInjectBuilder<WebApplicationBuilder>), LifeCycle = IocScopeEnum.Transiant)]
    public class WebApplicationBuilderInitializerNLog : InjectBuilder<WebApplicationBuilder>
    {      

        public override object Execute(WebApplicationBuilder builder)
        {

            var folder = StaticContainer.Get<GlobalConfiguration>()[GlobalConfiguration.Configuration];

            FileInfo file = null;
            var paths = folder.GetPaths();
            if (paths.Length > 0)
                file = GetFile(paths);

            if (file == null)
                file = CreateDefaultFile(ref paths);

            Loggers.InitializeLogger(file);

            if (!HasListener())
                Trace.Listeners.Add(new NLogTraceListener());

            var options = new NLogAspNetCoreOptions()
            {
                IncludeScopes = true,
                IncludeActivityIdsWithBeginScope = true,                
            };

            builder.WebHost.UseNLog(options);
            return null;

        }


        private FileInfo CreateDefaultFile(ref string[] paths)
        {
            FileInfo file;
            DirectoryInfo dir;

            if (paths.Length == 0)
            {
                dir = Directory
                    .GetCurrentDirectory()
                    .Combine("Configs")
                    .CreateFolderIfNotExists();

                var folder = StaticContainer.Get<GlobalConfiguration>()[GlobalConfiguration.Configuration];
                paths = folder.GetPaths();
            }
            else
            {
                dir = paths[0].AsDirectory();
            }

            _logger.Error("NLog configuration file not found. Loading default configuration");
            file = dir.Combine("nlog.config").AsFile();
            file.Save(Res.ResourceReader.ReadEmbeddedResource("Bb.Res.nlog.config"));
            return file;
        }

        private FileInfo GetFile(string[] paths)
        {

            FileInfo file = null;
            foreach (var item in paths)
            {

                var dir = item.AsDirectory();
                dir.Refresh();

                file = GetFile(dir);
                if (file != null)
                    break;
            }

            return file;

        }

        private FileInfo GetFile(DirectoryInfo dir)
        {
            if (dir.Exists)
            {
                var test = dir.GetFiles("nlog.config", System.IO.SearchOption.AllDirectories).FirstOrDefault();
                return test;
            }

            return null;

        }

        private bool HasListener()
        {
            foreach (var item in Trace.Listeners)
                if (item.GetType() == typeof(NLogTraceListener))
                    return true;
            return false;
        }

        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();
        private Logger _logger;
    }

}
