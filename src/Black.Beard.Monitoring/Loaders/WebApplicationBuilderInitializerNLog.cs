using Bb.ComponentModel;
using Bb.ComponentModel.Attributes;
using Bb.Configurations;
using Bb.Monitoring;
using NLog;
using NLog.Web;
using System.Diagnostics;

namespace Bb.Loaders
{


    /// <summary>
    /// Initializes NLog for a web application builder.
    /// </summary>
    [ExposeClass(ConstantsCore.Initialization, ExposedType = typeof(IInjectBuilder<WebApplicationBuilder>), LifeCycle = IocScope.Transiant)]
    public class WebApplicationBuilderInitializerNLog : InjectBuilder<WebApplicationBuilder>
    {

        /// <summary>
        /// Executes the NLog initializer for the web application builder.
        /// </summary>
        /// <param name="builder">The <see cref="WebApplicationBuilder"/> instance to configure. Must not be null.</param>
        /// <returns><see langword="null"/> after configuring the builder.</returns>
        /// <remarks>
        /// This method initializes NLog for the application by loading the configuration file, setting up logging options, and adding an NLog trace listener if none exists.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var builder = WebApplication.CreateBuilder(args);
        /// var initializer = new WebApplicationBuilderInitializerNLog();
        /// initializer.Execute(builder);
        /// var app = builder.Build();
        /// app.Run();
        /// </code>
        /// </example>
        public override void Execute(WebApplicationBuilder builder)
        {

            var folder = StaticContainer.Get<GlobalConfiguration>()[GlobalConfiguration.Configuration];

            FileInfo? file = null;
            var paths = folder.GetPaths();
            if (paths.Length > 0)
                file = GetFile(paths);

            // resolve and ensure the configuration file exits
            file ??= CreateDefaultFile(ref paths);
            Loggers.InitializeLogger(file);

            if (!HasListener()) // all traces System.Diagnostics are redirect on NLog
                Trace.Listeners.Add(new NLogTraceListener());

            var options = new NLogAspNetCoreOptions()
            {
                IncludeScopes = true,
                IncludeActivityIdsWithBeginScope = true,
            };

            builder.WebHost.UseNLog(options);

        }


        /// <summary>
        /// Creates a default NLog configuration file if none exists.
        /// </summary>
        /// <param name="paths">An array of paths where the configuration file should be created. Must not be null or empty.</param>
        /// <returns>The created <see cref="FileInfo"/> object representing the default configuration file.</returns>
        /// <remarks>
        /// This method generates a default NLog configuration file in the specified directory if no configuration file is found.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var paths = new[] { "C:\\Logs" };
        /// var initializer = new WebApplicationBuilderInitializerNLog();
        /// var file = initializer.CreateDefaultFile(ref paths);
        /// Console.WriteLine($"Default NLog configuration created at: {file.FullName}");
        /// </code>
        /// </example>
        private static FileInfo CreateDefaultFile(ref string[] paths)
        {
            FileInfo file;
            DirectoryInfo dir;
            dir = paths[0].AsDirectory();
            Trace.TraceInformation("NLog configuration file not found. Loading default configuration");
            file = dir.Combine("nlog.config").AsFile();
            file.Save(Res.ResourceReader.ReadEmbeddedResource("Bb.Res.nlog.config"));
            return file;
        }

        /// <summary>
        /// Retrieves the NLog configuration file from the specified paths.
        /// </summary>
        /// <param name="paths">An array of paths to search for the configuration file. Must not be null or empty.</param>
        /// <returns>The <see cref="FileInfo"/> object representing the configuration file, or <see langword="null"/> if no file is found.</returns>
        /// <remarks>
        /// This method searches the specified directories for an NLog configuration file named "nlog.config".
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var paths = new[] { "C:\\Logs", "D:\\Configs" };
        /// var initializer = new WebApplicationBuilderInitializerNLog();
        /// var file = initializer.GetFile(paths);
        /// if (file != null)
        /// {
        ///     Console.WriteLine($"NLog configuration found at: {file.FullName}");
        /// }
        /// else
        /// {
        ///     Console.WriteLine("No NLog configuration file found.");
        /// }
        /// </code>
        /// </example>
        private static FileInfo? GetFile(string[] paths)
        {

            FileInfo? file = null;
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

        /// <summary>
        /// Retrieves the NLog configuration file from a specific directory.
        /// </summary>
        /// <param name="dir">The <see cref="DirectoryInfo"/> object representing the directory to search. Must not be null.</param>
        /// <returns>The <see cref="FileInfo"/> object representing the configuration file, or <see langword="null"/> if no file is found.</returns>
        /// <remarks>
        /// This method searches the specified directory and its subdirectories for an NLog configuration file named "nlog.config".
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var dir = new DirectoryInfo("C:\\Logs");
        /// var initializer = new WebApplicationBuilderInitializerNLog();
        /// var file = initializer.GetFile(dir);
        /// if (file != null)
        /// {
        ///     Console.WriteLine($"NLog configuration found at: {file.FullName}");
        /// }
        /// else
        /// {
        ///     Console.WriteLine("No NLog configuration file found in the directory.");
        /// }
        /// </code>
        /// </example>
        private static FileInfo? GetFile(DirectoryInfo dir)
        {
            if (dir.Exists)
            {
                var test = dir.GetFiles("nlog.config", System.IO.SearchOption.AllDirectories).FirstOrDefault();
                return test;
            }

            return null;

        }

        /// <summary>
        /// Checks if an NLog trace listener is already added to the trace listeners collection.
        /// </summary>
        /// <returns><see langword="true"/> if an NLog trace listener exists; otherwise, <see langword="false"/>.</returns>
        /// <remarks>
        /// This method iterates through the trace listeners collection to determine if an NLog trace listener is already present.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var initializer = new WebApplicationBuilderInitializerNLog();
        /// bool hasListener = initializer.HasListener();
        /// Console.WriteLine($"NLog trace listener exists: {hasListener}");
        /// </code>
        /// </example>
        private static bool HasListener()
        {
            foreach (var item in Trace.Listeners)
                if (item.GetType() == typeof(NLogTraceListener))
                    return true;
            return false;
        }
        

    }

}
