using Microsoft.Extensions.Logging;
using System.Text;
using System.Threading;

namespace Bb.Interceptors
{

    /// <summary>
    /// Represents a configuration for logging messages of type <typeparamref name="T"/>.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class LogConfiguration<T>
        where T :class
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="LogConfiguration{T}"/> class.
        /// </summary>
        /// <remarks>
        /// This constructor initializes the list of logging rules for the specified type <typeparamref name="T"/>.
        /// </remarks>
        public LogConfiguration()
        {
            _rules = new List<Func<T, StringBuilder, CancellationToken, ValueTask>>();
        }

        /// <summary>
        /// Adds a logging rule to the configuration.
        /// </summary>
        /// <param name="rule">The rule to add, represented as a function that processes a message of type <typeparamref name="T"/>. Must not be null.</param>
        /// <remarks>
        /// This method allows adding custom logging rules that define how messages of type <typeparamref name="T"/> should be logged.
        /// </remarks>
        /// <exception cref="ArgumentNullException">
        /// Thrown if <paramref name="rule"/> is null.
        /// </exception>
        /// <example>
        /// <code lang="C#">
        /// var logConfig = new LogConfiguration&lt;HttpRequestMessage&gt;();
        /// logConfig.AddRule(async (message, logger, cancellationToken) =>
        /// {
        ///     logger.AppendLine($"Request: {message.Method} {message.RequestUri}");
        ///     await Task.CompletedTask;
        /// });
        /// </code>
        /// </example>
        public void AddRule(Func<T, StringBuilder, CancellationToken, ValueTask> rule)
        {
            ArgumentNullException.ThrowIfNull(rule);
            _rules.Add(rule);
        }

        /// <summary>
        /// Logs a message using the configured rules.
        /// </summary>
        /// <param name="message">The message of type <typeparamref name="T"/> to log. Must not be null.</param>
        /// <param name="logger">The <see cref="StringBuilder"/> instance to append log messages to. Must not be null.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> to observe while logging.</param>
        /// <returns>A <see cref="ValueTask"/> representing the asynchronous logging operation.</returns>
        /// <remarks>
        /// This method iterates through all configured logging rules and applies them to the provided message.
        /// </remarks>
        /// <exception cref="ArgumentNullException">
        /// Thrown if <paramref name="message"/> or <paramref name="logger"/> is null.
        /// </exception>
        /// <example>
        /// <code lang="C#">
        /// var logConfig = new LogConfiguration&lt;HttpRequestMessage&gt;();
        /// var logger = new StringBuilder();
        /// await logConfig.Log(requestMessage, logger, CancellationToken.None);
        /// Console.WriteLine(logger.ToString());
        /// </code>
        /// </example>
        public async ValueTask Log(T message, StringBuilder logger, CancellationToken cancellationToken)
        {
            ArgumentNullException.ThrowIfNull(message);
            ArgumentNullException.ThrowIfNull(logger);

            foreach (var rule in _rules)
                await rule(message, logger, cancellationToken);
        }

        /// <summary>
        /// Gets a value indicating whether any logging rules are configured.
        /// </summary>
        /// <value><c>true</c> if at least one logging rule is configured; otherwise, <c>false</c>.</value>
        /// <remarks>
        /// This property indicates whether the <see cref="LogConfiguration{T}"/> instance has any rules defined.
        /// </remarks>
        public bool HasRule => _rules.Count > 0;

        /// <summary>
        /// The list of logging rules for messages of type <typeparamref name="T"/>.
        /// </summary>
        private readonly List<Func<T, StringBuilder, CancellationToken, ValueTask>> _rules;

    }

}
