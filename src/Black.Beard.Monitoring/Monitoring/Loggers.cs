using NLog;
using NLog.Config;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace Bb.Monitoring
{

    /// <summary>
    /// Load and initialize the logger
    /// </summary>
    public static class Loggers
    {

        static Loggers()
        {
            DirectoryToTrace = Directory.GetCurrentDirectory().Combine("Logs");
        }

        public static void InitializeLogger(FileInfo file)
        {

            string web_log_directory = "web_log_directory";

            //// target folder where store logs
            //DirectoryToTrace.CreateFolderIfNotExists();
            //GlobalDiagnosticsContext.Set(web_log_directory, DirectoryToTrace);
            //var configLogPath = Directory.GetCurrentDirectory().Combine("nlog.config");

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
                        Trace.WriteLine($"the variable '{variableName}' in the configuration file {file.FullName} can't be resolved");
                
                }

                LogManager.Configuration = new XmlLoggingConfiguration(file.FullName);

            }

        }

        public static string DirectoryToTrace { get; set; }

    }
}
