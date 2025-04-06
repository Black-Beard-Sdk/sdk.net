using Bb.ComponentModel;
using Bb.ComponentModel.Attributes;
using System.Diagnostics;

namespace Bb.Loaders
{


    /// <summary>
    /// Initializes the logging builder for a web application.
    /// </summary>
    [ExposeClass(ConstantsCore.Initialization, ExposedType = typeof(IInjectBuilder<ILoggingBuilder>), LifeCycle = IocScopeEnum.Transiant)]
    public class LoggingBuilderInitializer : InjectBuilder<ILoggingBuilder>
    {

        /// <summary>
        /// Executes the logging builder initializer to configure logging providers and levels.
        /// </summary>
        /// <param name="context">The <see cref="ILoggingBuilder"/> instance to configure. Must not be null.</param>
        /// <returns>The configured <see cref="ILoggingBuilder"/> instance.</returns>
        /// <remarks>
        /// This method clears existing logging providers, sets the minimum logging level to <see cref="LogLevel.Trace"/>, and adds console and debug logging providers. Debug logging is only added if a debugger is attached.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var builder = WebApplication.CreateBuilder(args);
        /// var loggingBuilder = builder.Logging;
        /// var initializer = new LoggingBuilderInitializer();
        /// initializer.Execute(loggingBuilder);
        /// </code>
        /// </example>
        public override void Execute(ILoggingBuilder context)
        {

            var a = Trace.Listeners;

            context.ClearProviders();
            context.SetMinimumLevel(LogLevel.Trace);

            context.AddConsole();
            if (Debugger.IsAttached)
                context.AddDebug();

        }

    }

}
