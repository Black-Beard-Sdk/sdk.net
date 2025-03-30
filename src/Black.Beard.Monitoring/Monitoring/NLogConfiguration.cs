using Bb.ComponentModel.Attributes;
using Bb.ComponentModel;

// https://learn.microsoft.com/fr-fr/dotnet/core/diagnostics/observability-prgrja-example
// https://learn.microsoft.com/fr-fr/dotnet/core/diagnostics/metrics-instrumentation#create-a-custom-metric
// https://zipkin.io/pages/quickstart
// docker run -d -p 9411:9411 openzipkin/zipkin
// http://localhost:9411/zipkin/

namespace Bb.Monitoring
{

    [ExposeClass(ConstantsCore.Configuration, LifeCycle = IocScopeEnum.Singleton)]
    public class NLogConfiguration
    {

        public bool ExportConsole { get; set; }

        //public ExporterConfiguration Zipkin { get; set; }

    }
}
