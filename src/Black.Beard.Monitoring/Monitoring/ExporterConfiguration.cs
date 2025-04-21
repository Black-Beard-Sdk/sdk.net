// https://learn.microsoft.com/fr-fr/dotnet/core/diagnostics/observability-prgrja-example
// https://learn.microsoft.com/fr-fr/dotnet/core/diagnostics/metrics-instrumentation#create-a-custom-metric
// https://zipkin.io/pages/quickstart
// docker run -d -p 9411:9411 openzipkin/zipkin
// http://localhost:9411/zipkin/

namespace Bb.Monitoring
{
    /// <summary>
    /// Represents the configuration settings for an exporter used in monitoring and observability.
    /// </summary>
    /// <remarks>
    /// This class provides properties to configure the exporter, including activation status, protocol, port, and host.
    /// It is commonly used to configure exporters like Zipkin for tracing and metrics collection.
    /// </remarks>
    public class ExporterConfiguration
    {
        /// <summary>
        /// Gets or sets a value indicating whether the exporter is activated.
        /// </summary>
        /// <value>
        /// <see langword="true"/> if the exporter is activated; otherwise, <see langword="false"/>.
        /// </value>
        /// <remarks>
        /// When set to <see langword="true"/>, the exporter will be enabled and start collecting and exporting data.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var config = new ExporterConfiguration
        /// {
        ///     Activated = true,
        ///     Https = false,
        ///     Port = 9411,
        ///     Host = "localhost"
        /// };
        /// </code>
        /// </example>
        public bool Activated { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the exporter uses HTTPS.
        /// </summary>
        /// <value>
        /// <see langword="true"/> if HTTPS is used; otherwise, <see langword="false"/>.
        /// </value>
        /// <remarks>
        /// When set to <see langword="true"/>, the exporter will use HTTPS for secure communication.
        /// </remarks>
        public bool HTTPS { get; set; }

        /// <summary>
        /// Gets or sets the port number used by the exporter.
        /// </summary>
        /// <value>
        /// The port number. The default value is 9411.
        /// </value>
        /// <remarks>
        /// This property specifies the port on which the exporter will listen for incoming data.
        /// </remarks>
        public int Port { get; set; } = 9411;

        /// <summary>
        /// Gets or sets the host address of the exporter.
        /// </summary>
        /// <value>
        /// The host address. The default value is "localhost".
        /// </value>
        /// <remarks>
        /// This property specifies the host address where the exporter is running.
        /// </remarks>
        public string Host { get; set; } = "localhost";
    }
}
