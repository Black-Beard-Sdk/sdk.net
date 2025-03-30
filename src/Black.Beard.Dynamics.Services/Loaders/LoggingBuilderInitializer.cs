using Bb.ComponentModel;
using Bb.ComponentModel.Attributes;
using System.Diagnostics;

namespace Bb.Loaders
{


    [ExposeClass(ConstantsCore.Initialization, ExposedType = typeof(IInjectBuilder<ILoggingBuilder>), LifeCycle = IocScopeEnum.Transiant)]
    public class LoggingBuilderInitializer : InjectBuilder<ILoggingBuilder>
    {

        public override object Execute(ILoggingBuilder context)
        {

            var a = Trace.Listeners;

            context.ClearProviders();
            context.SetMinimumLevel(LogLevel.Trace);

            context.AddConsole();
            if (Debugger.IsAttached)
                context.AddDebug();

            return context;
        }

    }

}
