using NLog;
using NLog.Config;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace Bb.Monitoring
{

    /// <summary>
    /// Load and initialize the logger
    /// </summary>
    internal static class Loggers
    {

        static Loggers()
        {
            DirectoryToTrace = Directory.GetCurrentDirectory().Combine("Logs");
        }

        /// <summary>
        /// Initializes the logger configuration from the specified file.
        /// </summary>
        /// <param name="file">file that contains configuration</param>
        public static void InitializeLogger(FileInfo file)
        {

            string web_log_directory = "web_log_directory";

            if (file.Exists)
            {

                var payload = file.LoadFromFile();
                var reg = new Regex("\\${gdc:\\w+}", RegexOptions.CultureInvariant | RegexOptions.Multiline);
                foreach (Match item in reg.Matches(payload))
                {
                    var variableName = item.Value.Substring(6, item.Value.Length - 7);
                    var v = Environment.GetEnvironmentVariable(variableName);
                    if (!string.IsNullOrEmpty(v))
                        GlobalDiagnosticsContext.Set(variableName, v);

                    else if (variableName != web_log_directory)
                        Trace.TraceInformation($"the variable '{variableName}' in the configuration file {file.FullName} can't be resolved");
                
                }

                LogManager.Configuration = new XmlLoggingConfiguration(file.FullName);

            }

        }

        /// <summary>
        /// Gets or sets the directory where logs are stored.
        /// </summary>
        public static string DirectoryToTrace { get; set; }

    }
}
