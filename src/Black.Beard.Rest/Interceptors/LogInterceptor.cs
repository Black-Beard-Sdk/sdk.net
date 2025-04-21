using Bb.Services;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Text;

namespace Bb.Interceptors
{

    /// <summary>
    /// Represents class for intercept and log
    /// </summary>
    public class LogInterceptor : RestSharp.Interceptors.Interceptor
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LogInterceptor"/> class.
        /// </summary>
        /// <param name="configurationRequest">The logging configuration for HTTP requests. Must not be null.</param>
        /// <param name="configurationResponse">The logging configuration for HTTP responses. Must not be null.</param>
        /// <param name="logger">The logger instance to use for logging. Can be null.</param>
        /// <remarks>
        /// This constructor sets up the interceptor with the provided logging configurations and logger.
        /// </remarks>
        public LogInterceptor(LogConfiguration<HttpRequestMessage> configurationRequest, LogConfiguration<HttpResponseMessage> configurationResponse, ILogger? logger)
        {
            if (logger != null)
                CurrentLogger = logger;
            _stopwatch = new Stopwatch();

            _configurationRequest = configurationRequest;
            _configurationResponse = configurationResponse;
        }

        /// <summary>
        /// Executes before an HTTP request is sent.
        /// </summary>
        /// <param name="requestMessage">The HTTP request message to log. Must not be null.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> to observe while logging.</param>
        /// <returns>A <see cref="ValueTask"/> representing the asynchronous operation.</returns>
        /// <remarks>
        /// This method logs the HTTP request details if logging rules are configured and starts a stopwatch to measure the request duration.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var interceptor = new LogInterceptor(requestConfig, responseConfig, logger);
        /// await interceptor.BeforeHttpRequest(requestMessage, CancellationToken.None);
        /// </code>
        /// </example>
        public override async ValueTask BeforeHttpRequest(HttpRequestMessage requestMessage, CancellationToken cancellationToken)
        {
            if (_configurationRequest.HasRule)
            {
                var sb = new StringBuilder();
                _configurationRequest?.Log(requestMessage, sb, cancellationToken);
                sb.AppendLine();
                CurrentLogger.LogDebug(sb.ToString());
            }

            _stopwatch.Restart();
            await base.BeforeHttpRequest(requestMessage, cancellationToken);
        }

        /// <summary>
        /// Executes after an HTTP request is completed.
        /// </summary>
        /// <param name="responseMessage">The HTTP response message to log. Must not be null.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> to observe while logging.</param>
        /// <returns>A <see cref="ValueTask"/> representing the asynchronous operation.</returns>
        /// <remarks>
        /// This method logs the HTTP response details, including status code, reason phrase, and elapsed time, if logging rules are configured.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var interceptor = new LogInterceptor(requestConfig, responseConfig, logger);
        /// await interceptor.AfterHttpRequest(responseMessage, CancellationToken.None);
        /// </code>
        /// </example>
        public override async ValueTask AfterHttpRequest(HttpResponseMessage responseMessage, CancellationToken cancellationToken)
        {
            _stopwatch.Stop();

            CurrentLogger.LogInformation("HTTP Response: {StatusCode} {ReasonPhrase} in {ElapsedMilliseconds}ms",
                (int)responseMessage.StatusCode,
                responseMessage.ReasonPhrase,
                _stopwatch.ElapsedMilliseconds);

            if (_configurationResponse.HasRule)
            {
                var sb = new StringBuilder();
                _configurationResponse?.Log(responseMessage, sb, cancellationToken);
                CurrentLogger.LogDebug(sb.ToString());
            }
            await base.AfterHttpRequest(responseMessage, cancellationToken);
        }

        /// <summary>
        /// Gets or sets the logger instance used for logging.
        /// </summary>
        /// <value>An <see cref="ILogger"/> instance for logging operations.</value>
        /// <remarks>
        /// If no logger is explicitly set, a default local logger is created.
        /// </remarks>
        public ILogger CurrentLogger
        {
            get => _logger ?? (_logger = CreateLogger());
            set { _logger = value; }
        }

        /// <summary>
        /// Creates a default local logger instance.
        /// </summary>
        /// <returns>An <see cref="ILogger"/> instance with a default configuration.</returns>
        /// <remarks>
        /// This method creates a logger with the name "http client" if no logger is provided.
        /// </remarks>
        private ILogger CreateLogger()
        {
            return new LocalLogger("http client");
        }

        private ILogger? _logger;
        private readonly Stopwatch _stopwatch;
        private readonly LogConfiguration<HttpRequestMessage> _configurationRequest;
        private readonly LogConfiguration<HttpResponseMessage> _configurationResponse;
    }
}
