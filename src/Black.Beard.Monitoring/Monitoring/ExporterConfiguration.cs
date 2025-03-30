// https://learn.microsoft.com/fr-fr/dotnet/core/diagnostics/observability-prgrja-example
// https://learn.microsoft.com/fr-fr/dotnet/core/diagnostics/metrics-instrumentation#create-a-custom-metric
// https://zipkin.io/pages/quickstart
// docker run -d -p 9411:9411 openzipkin/zipkin
// http://localhost:9411/zipkin/

namespace Bb.Monitoring
{
    public class ExporterConfiguration
    {

        public bool Activated { get; set; }

        public bool Https { get; set; }

        public int Port { get; set; } = 9411;

        // "http://192.168.10.47"
        public string Host { get; set; } = "localhost";


    }
}
