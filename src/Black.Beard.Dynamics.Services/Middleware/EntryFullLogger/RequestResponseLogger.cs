// Ignore Spelling: Middleware

using Bb.ComponentModel;
using Bb.ComponentModel.Attributes;

namespace Bb.Middleware.EntryFullLogger
{

    /// <summary>
    /// Represents a logger for HTTP request and response details.
    /// </summary>
    [ExposeClass(Context = ConstantsCore.Service, ExposedType = typeof(IRequestResponseLogger), LifeCycle = IocScope.Singleton)]
    public class RequestResponseLogger : IRequestResponseLogger
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestResponseLogger"/> class.
        /// </summary>
        /// <param name="logger">The <see cref="ILogger{RequestResponseLogger}"/> instance used for logging. Must not be null.</param>
        /// <remarks>
        /// This constructor sets up the logger for capturing and logging request and response details.
        /// </remarks>
        public RequestResponseLogger(ILogger<RequestResponseLogger> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Logs the request and response details using the provided log model creator.
        /// </summary>
        /// <param name="logCreator">An instance of <see cref="IRequestResponseLogModelCreator"/> used to create the log model. Must not be null.</param>
        /// <remarks>
        /// This method captures the log details from the provided log model creator and logs them at the critical level.
        /// </remarks>
        /// <exception cref="ArgumentNullException">
        /// Thrown if <paramref name="logCreator"/> is null.
        /// </exception>
        /// <example>
        /// <code lang="C#">
        /// var logger = new RequestResponseLogger(new LoggerFactory().CreateLogger&lt;RequestResponseLogger&gt;());
        /// var logCreator = new MyRequestResponseLogModelCreator();
        /// logger.Log(logCreator);
        /// </code>
        /// </example>
        public void Log(IRequestResponseLogModelCreator logCreator)
        {
            _logger.LogCritical(logCreator.LogString());
        }

        private readonly ILogger<RequestResponseLogger> _logger;

    }


}
