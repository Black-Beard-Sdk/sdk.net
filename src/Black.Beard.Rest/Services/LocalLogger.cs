using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace Bb.Services
{

    internal class LocalLogger : ILogger
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalLogger"/> class with the specified category name.
        /// </summary>
        /// <param name="categoryName">The category name for the logger. Default is "LogInterceptor".</param>
        /// <remarks>
        /// This constructor initializes the logger with a default output writer set to the console.
        /// </remarks>
        public LocalLogger(string categoryName = "LogInterceptor")
        {
            _categoryName = categoryName;
            _writer = Console.Out;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalLogger"/> class with the specified category name and writer.
        /// </summary>
        /// <param name="categoryName">The category name for the logger. Must not be null.</param>
        /// <param name="writer">The <see cref="TextWriter"/> instance to use for logging output. Must not be null.</param>
        /// <remarks>
        /// This constructor initializes the logger with a custom output writer.
        /// </remarks>
        /// <exception cref="ArgumentNullException">
        /// Thrown if <paramref name="writer"/> is null.
        /// </exception>
        public LocalLogger(string categoryName, TextWriter writer)
        {
            _categoryName = categoryName;
            _writer = writer ?? throw new ArgumentNullException(nameof(writer));
        }

        /// <summary>
        /// Begins a logical operation scope.
        /// </summary>
        /// <typeparam name="TState">The type of the state object to associate with the scope.</typeparam>
        /// <param name="state">The state object to associate with the scope.</param>
        /// <returns>An <see cref="IDisposable"/> that ends the logical operation scope on disposal.</returns>
        /// <remarks>
        /// This method returns a no-operation disposable object as the logger does not support scoped logging.
        /// </remarks>
        public IDisposable BeginScope<TState>(TState state)
        {
            return new NoopDisposable();
        }

        /// <summary>
        /// Checks if the specified log level is enabled.
        /// </summary>
        /// <param name="logLevel">The log level to check.</param>
        /// <returns><c>true</c> if the specified log level is enabled; otherwise, <c>false</c>.</returns>
        /// <remarks>
        /// By default, all log levels except <see cref="LogLevel.None"/> are enabled.
        /// </remarks>
        public bool IsEnabled(LogLevel logLevel)
        {
            // Active tous les niveaux de log par défaut
            return logLevel != LogLevel.None;
        }

        /// <summary>
        /// Logs a message with the specified log level and event data.
        /// </summary>
        /// <typeparam name="TState">The type of the state object to log.</typeparam>
        /// <param name="logLevel">The log level of the message.</param>
        /// <param name="eventId">The event ID associated with the log message.</param>
        /// <param name="state">The state object to log. Must not be null.</param>
        /// <param name="exception">The exception to log, if any. Can be null.</param>
        /// <param name="formatter">The function to format the log message. Must not be null.</param>
        /// <remarks>
        /// This method formats and writes the log message to the configured output writer and the trace listeners, if any.
        /// </remarks>
        /// <exception cref="ArgumentNullException">
        /// Thrown if <paramref name="state"/> or <paramref name="formatter"/> is null.
        /// </exception>
        /// <example>
        /// <code lang="C#">
        /// var logger = new LocalLogger("MyCategory");
        /// logger.Log(LogLevel.Information, new EventId(1), "This is a log message.", null, (state, ex) => state.ToString());
        /// </code>
        /// </example>
        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {

            if (!IsEnabled(logLevel))
                return;

            if (state == null)
                throw new ArgumentNullException(nameof(state));
            if (formatter == null)
                throw new ArgumentNullException(nameof(formatter));

            string logLevelString = GetLogLevelString(logLevel);
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
            string message = formatter(state, exception);

            string logMessage = $"[{timestamp}] [{logLevelString}] [{_categoryName}]{Environment.NewLine} {message}";

            if (exception != null)
                logMessage += Environment.NewLine + exception.ToString();

            lock (_writer)
            {

                if (Trace.Listeners.Count > 0)
                {

                    Trace.TraceInformation(logMessage);
                    Trace.TraceInformation("-----------------------------------------------");

                }

                _writer.WriteLine(logMessage);
                _writer.Flush();
            }
        }

        /// <summary>
        /// Converts the log level to its string representation.
        /// </summary>
        /// <param name="logLevel">The log level to convert.</param>
        /// <returns>A string representing the log level.</returns>
        /// <remarks>
        /// This method maps the <see cref="LogLevel"/> enumeration to its corresponding string representation.
        /// </remarks>
        private string GetLogLevelString(LogLevel logLevel)
        {
            return logLevel switch
            {
                LogLevel.Trace => "TRACE",
                LogLevel.Debug => "DEBUG",
                LogLevel.Information => "INFO ",
                LogLevel.Warning => "WARN ",
                LogLevel.Error => "ERROR",
                LogLevel.Critical => "CRIT ",
                _ => "NONE "
            };
        }

        /// <summary>
        /// Represents a no-operation disposable object.
        /// </summary>
        private class NoopDisposable : IDisposable
        {
            /// <summary>
            /// Performs no operation on disposal.
            /// </summary>
            public void Dispose() { }
        }

        private readonly string _categoryName;
        private readonly TextWriter _writer;

    }

}
