using Bb.Interceptors;
using System.Net.Http.Headers;
using System.Text;

namespace Bb.Helpers
{
    public static class LogConfigurationExtension
    {

        /// <summary>
        /// Logs the start of an HTTP request.
        /// </summary>
        /// <param name="self">The <see cref="LogConfiguration{HttpRequestMessage}"/> instance to configure. Must not be null.</param>
        /// <returns>The configured <see cref="LogConfiguration{HttpRequestMessage}"/> instance.</returns>
        /// <remarks>
        /// This method adds a logging rule to log the HTTP request method and URI at the start of the request.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var logConfig = new LogConfiguration&lt;HttpRequestMessage&gt;();
        /// logConfig.LogStart();
        /// </code>
        /// </example>
        internal static LogConfiguration<HttpRequestMessage> LogStart(this LogConfiguration<HttpRequestMessage> self)
        {
            self.AddRule(async (message, logger, cancellationToken) =>
            {
                logger.AppendLine("-----------------------------------------------");
                logger.AppendLine("HTTP Request: ");
                logger.AppendLine($"{message.Method} {message.RequestUri}");
                await Task.CompletedTask;
            });

            return self;
        }

        /// <summary>
        /// Logs all details of an HTTP request, including headers and body.
        /// </summary>
        /// <param name="self">The <see cref="LogConfiguration{HttpRequestMessage}"/> instance to configure. Must not be null.</param>
        /// <returns>The configured <see cref="LogConfiguration{HttpRequestMessage}"/> instance.</returns>
        /// <remarks>
        /// This method adds logging rules to log both the headers and body of an HTTP request.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var logConfig = new LogConfiguration&lt;HttpRequestMessage&gt;();
        /// logConfig.LogAll();
        /// </code>
        /// </example>
        public static LogConfiguration<HttpRequestMessage> LogAll(this LogConfiguration<HttpRequestMessage> self)
        {
            self
                .LogHeader()
                .LogBody();
            return self;
        }

        /// <summary>
        /// Logs the headers of an HTTP request.
        /// </summary>
        /// <param name="self">The <see cref="LogConfiguration{HttpRequestMessage}"/> instance to configure. Must not be null.</param>
        /// <returns>The configured <see cref="LogConfiguration{HttpRequestMessage}"/> instance.</returns>
        /// <remarks>
        /// This method adds a logging rule to log the headers of an HTTP request.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var logConfig = new LogConfiguration&lt;HttpRequestMessage&gt;();
        /// logConfig.LogHeader();
        /// </code>
        /// </example>
        public static LogConfiguration<HttpRequestMessage> LogHeader(this LogConfiguration<HttpRequestMessage> self)
        {
            self.AddRule((message, logger, cancellationToken) => LogHeader(message.Headers, logger, cancellationToken));
            return self;
        }

        /// <summary>
        /// Logs the body of an HTTP request.
        /// </summary>
        /// <param name="self">The <see cref="LogConfiguration{HttpRequestMessage}"/> instance to configure. Must not be null.</param>
        /// <returns>The configured <see cref="LogConfiguration{HttpRequestMessage}"/> instance.</returns>
        /// <remarks>
        /// This method adds a logging rule to log the body of an HTTP request.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var logConfig = new LogConfiguration&lt;HttpRequestMessage&gt;();
        /// logConfig.LogBody();
        /// </code>
        /// </example>
        public static LogConfiguration<HttpRequestMessage> LogBody(this LogConfiguration<HttpRequestMessage> self)
        {
            self.AddRule(async (message, logger, cancellationToken) => await LogBody(message.Content, logger, cancellationToken));
            return self;
        }

        /// <summary>
        /// Logs all details of an HTTP response, including headers and body.
        /// </summary>
        /// <param name="self">The <see cref="LogConfiguration{HttpResponseMessage}"/> instance to configure. Must not be null.</param>
        /// <returns>The configured <see cref="LogConfiguration{HttpResponseMessage}"/> instance.</returns>
        /// <remarks>
        /// This method adds logging rules to log both the headers and body of an HTTP response.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var logConfig = new LogConfiguration&lt;HttpResponseMessage&gt;();
        /// logConfig.LogAll();
        /// </code>
        /// </example>
        public static LogConfiguration<HttpResponseMessage> LogAll(this LogConfiguration<HttpResponseMessage> self)
        {
            self
                .LogHeader()
                .LogBody();
            return self;
        }

        /// <summary>
        /// Logs the headers of an HTTP response.
        /// </summary>
        /// <param name="self">The <see cref="LogConfiguration{HttpResponseMessage}"/> instance to configure. Must not be null.</param>
        /// <returns>The configured <see cref="LogConfiguration{HttpResponseMessage}"/> instance.</returns>
        /// <remarks>
        /// This method adds a logging rule to log the headers of an HTTP response.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var logConfig = new LogConfiguration&lt;HttpResponseMessage&gt;();
        /// logConfig.LogHeader();
        /// </code>
        /// </example>
        public static LogConfiguration<HttpResponseMessage> LogHeader(this LogConfiguration<HttpResponseMessage> self)
        {
            self.AddRule((message, logger, cancellationToken) => LogHeader(message.Headers, logger, cancellationToken));
            return self;
        }

        /// <summary>
        /// Logs the body of an HTTP response.
        /// </summary>
        /// <param name="self">The <see cref="LogConfiguration{HttpResponseMessage}"/> instance to configure. Must not be null.</param>
        /// <returns>The configured <see cref="LogConfiguration{HttpResponseMessage}"/> instance.</returns>
        /// <remarks>
        /// This method adds a logging rule to log the body of an HTTP response.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var logConfig = new LogConfiguration&lt;HttpResponseMessage&gt;();
        /// logConfig.LogBody();
        /// </code>
        /// </example>
        public static LogConfiguration<HttpResponseMessage> LogBody(this LogConfiguration<HttpResponseMessage> self)
        {
            self.AddRule(async (message, logger, cancellationToken) => await LogBody(message.Content, logger, cancellationToken));
            return self;
        }

        static async ValueTask LogHeader(this HttpHeaders self, StringBuilder logger, CancellationToken cancellationToken)
        {

            logger.AppendLine("[Headers]");
            if (self != null)
                foreach (KeyValuePair<string, IEnumerable<string>> header in self)
                    //if (header.Key != "Autorization" || (!header.Key.Contains("api") && !header.Key.Contains("key")))
                    logger.AppendLine($"{header.Key}: {string.Join(", ", header.Value)}");

            await Task.CompletedTask;

        }

        static async ValueTask LogBody(this HttpContent self, StringBuilder logger, CancellationToken cancellationToken)
        {
            logger.AppendLine("[Content]");
            if (self != null)
                try
                {
                    string content = await self.ReadAsStringAsync(cancellationToken);
                    if (!string.IsNullOrEmpty(content))
                        logger.AppendLine(content);
                }
                catch (Exception ex)
                {
                    logger.AppendLine(string.Format("Failed to read {way} body: {Message}", ex.Message));
                }
            await Task.CompletedTask;
        }

    }

}
