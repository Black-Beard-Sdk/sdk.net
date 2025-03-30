//using Bb.ComponentModel;
//using Bb.ComponentModel.Attributes;
//using Bb.ComponentModel.Loaders;
//using Bb.Monitoring;
//using NLog;
//using System.Diagnostics;

//namespace Bb.Loaders
//{


//    [ExposeClass(ConstantsCore.Initialization, ExposedType = typeof(IInjectBuilder<Initializer>), LifeCycle = IocScopeEnum.Transiant)]
//    [Priority(2)]
//    public class NLogInitializer : InjectBuilder<Initializer>
//    {

//        public NLogInitializer(ILogger<NLogInitializer> logger)
//        {
//            _logger = logger;
//            //_tracer = TracerProvider.Default.GetTracer("ConfigLoggerInitializer");
//        }

//        public override object Execute(Initializer context)
//        {

//            FileInfo file = null;
//            var paths = ConfigurationFolder.GetPaths();
//            if (paths.Length > 0)
//                file = GetFile(paths);

//            if (file == null)
//                file = CreateDefaultFile(ref paths);

//            Loggers.InitializeLogger(file);

//            _logger.LogInformation("NLog initialized");

//            if (!HasListener())
//                Trace.Listeners.Add(new NLogTraceListener());

//            return null;
//        }

 
//    }
//}
