using Bb.ComponentModel.Attributes;
using Bb.ComponentModel;

// https://learn.microsoft.com/fr-fr/dotnet/core/diagnostics/observability-prgrja-example
// https://learn.microsoft.com/fr-fr/dotnet/core/diagnostics/metrics-instrumentation#create-a-custom-metric
// https://zipkin.io/pages/quickstart
// docker run -d -p 9411:9411 openzipkin/zipkin
// http://localhost:9411/zipkin/

namespace Bb.Monitoring
{

    /// <summary>
    /// Represents the configuration settings for NLog logging.
    /// </summary>
    /// <remarks>
    /// This class provides properties to configure NLog, including options for exporting logs to the console.
    /// It is registered as a singleton in the IoC container.
    /// </remarks>
    [ExposeClass(ConstantsCore.Configuration, LifeCycle = IocScope.Singleton)]
    public class NLogConfiguration
    {
        /// <summary>
        /// Gets or sets a value indicating whether logs should be exported to the console.
        /// </summary>
        /// <value>
        /// <see langword="true"/> if logs should be exported to the console; otherwise, <see langword="false"/>.
        /// </value>
        /// <remarks>
        /// When set to <see langword="true"/>, log messages will be written to the console output.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var config = new NLogConfiguration
        /// {
        ///     ExportConsole = true
        /// };
        /// </code>
        /// </example>
        public bool ExportConsole { get; set; }

    }
}
