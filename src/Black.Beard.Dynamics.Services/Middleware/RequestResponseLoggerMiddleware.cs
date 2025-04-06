using Bb.Middleware.EntryFullLogger;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.Extensions.Options;

namespace Bb.Middleware
{

    /// <summary>
    /// Middleware for logging HTTP request and response details.
    /// </summary>
    public class RequestResponseLoggerMiddleware
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestResponseLoggerMiddleware"/> class.
        /// </summary>
        /// <param name="next">The next middleware in the pipeline. Must not be null.</param>
        /// <param name="options">The <see cref="IOptions{RequestResponseLoggerOption}"/> instance containing configuration options. Must not be null.</param>
        /// <param name="logger">The <see cref="IRequestResponseLogger"/> instance used for logging. Must not be null.</param>
        /// <remarks>
        /// This constructor sets up the middleware to log HTTP request and response details based on the provided options.
        /// </remarks>
        /// <exception cref="ArgumentNullException">
        /// Thrown if <paramref name="next"/>, <paramref name="options"/>, or <paramref name="logger"/> is null.
        /// </exception>
        public RequestResponseLoggerMiddleware(RequestDelegate next, IOptions<RequestResponseLoggerOption> options, IRequestResponseLogger logger)
        {
            _next = next;
            _options = options.Value;
            _logger = logger;
        }

        /// <summary>
        /// Processes an HTTP request and logs its details, along with the response details.
        /// </summary>
        /// <param name="httpContext">The <see cref="HttpContext"/> representing the current HTTP request. Must not be null.</param>
        /// <param name="logCreator">The <see cref="IRequestResponseLogModelCreator"/> instance used to create the log model. Must not be null.</param>
        /// <returns>A <see cref="Task"/> that represents the asynchronous operation.</returns>
        /// <remarks>
        /// This method captures and logs details of the HTTP request and response, including headers, body, and exceptions, if any.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var builder = WebApplication.CreateBuilder(args);
        /// var app = builder.Build();
        /// app.UseMiddleware&lt;RequestResponseLoggerMiddleware&gt;();
        /// app.Run();
        /// </code>
        /// </example>
        public async Task InvokeAsync(HttpContext httpContext, IRequestResponseLogModelCreator logCreator)
        {

            // Middleware is enabled only when the EnableRequestResponseLogging config value is set.
            if (_options == null || !_options.IsEnabled)
            {
                await _next(httpContext);
                return;
            }

            RequestResponseLogModel log = logCreator.LogModel;
            log.RequestDateTimeUtc = DateTime.UtcNow;
            log.LogId = Guid.NewGuid().ToString();
            log.TraceId = httpContext.TraceIdentifier;

            HttpRequest request = httpContext.Request;
            /*log*/
            var ip = request.HttpContext.Connection.RemoteIpAddress;
            
            log.ClientIp = ip == null 
                ? null 
                : ip.ToString();

            /*request*/
            log.Node = _options.Name;
            log.RequestMethod = request.Method;
            log.RequestPath = request.Path;
            log.RequestQuery = request.QueryString.ToString();
            log.RequestQueries = FormatQueries(request.QueryString.ToString());
            log.RequestHeaders = FormatHeaders(request.Headers);
            log.RequestBody = await ReadBodyFromRequest(request);
            log.RequestScheme = request.Scheme;
            log.RequestHost = request.Host.ToString();
            log.RequestContentType = request.ContentType;

            // Temporary replace the HttpResponseStream, which is a write-only stream, with a Memory stream to capture it's value in-flight.
            HttpResponse response = httpContext.Response;
            var originalResponseBody = response.Body;
            using var newResponseBody = new MemoryStream();
            response.Body = newResponseBody;

            // Call the next middleware in the pipeline
            try
            {

                await _next(httpContext);

            }
            catch (Exception exception)
            {


                /*exception: but was not managed at app.UseExceptionHandler() or by any middleware*/
                LogError(log, exception);

            }

            newResponseBody.Seek(0, SeekOrigin.Begin);
            var responseBodyText = await new StreamReader(response.Body).ReadToEndAsync();

            newResponseBody.Seek(0, SeekOrigin.Begin);
            await newResponseBody.CopyToAsync(originalResponseBody);

            /*response*/
            log.ResponseContentType = response.ContentType;
            log.ResponseStatus = response.StatusCode.ToString();
            log.ResponseHeaders = FormatHeaders(response.Headers);
            log.ResponseBody = responseBodyText;
            log.ResponseDateTimeUtc = DateTime.UtcNow;


            /*exception: but was managed at app.UseExceptionHandler() or by any middleware*/
            var contextFeature = httpContext.Features.Get<IExceptionHandlerPathFeature>();
            if (contextFeature != null && contextFeature.Error != null)
            {
                Exception exception = contextFeature.Error;
                LogError(log, exception);
            }

            //var jsonString = logCreator.LogString(); /*log json*/
            _logger.Log(logCreator);

        }

        /// <summary>
        /// Logs an exception and updates the log model with exception details.
        /// </summary>
        /// <param name="log">The <see cref="RequestResponseLogModel"/> instance to update with exception details. Must not be null.</param>
        /// <param name="exception">The <see cref="Exception"/> instance representing the error. Must not be null.</param>
        /// <remarks>
        /// This method captures the exception message and stack trace and updates the log model accordingly.
        /// </remarks>
        /// <exception cref="ArgumentNullException">
        /// Thrown if <paramref name="log"/> or <paramref name="exception"/> is null.
        /// </exception>
        private void LogError(RequestResponseLogModel log, Exception exception)
        {
            log.ExceptionMessage = exception.Message;
            log.ExceptionStackTrace = exception.StackTrace;
        }

        /// <summary>
        /// Formats HTTP headers into a dictionary.
        /// </summary>
        /// <param name="headers">The <see cref="IHeaderDictionary"/> containing the HTTP headers. Must not be null.</param>
        /// <returns>A <see cref="Dictionary{TKey, TValue}"/> containing the formatted headers.</returns>
        /// <remarks>
        /// This method converts the HTTP headers into a key-value pair dictionary for logging purposes.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var headers = httpContext.Request.Headers;
        /// var formattedHeaders = FormatHeaders(headers);
        /// Console.WriteLine($"Headers: {string.Join(", ", formattedHeaders)}");
        /// </code>
        /// </example>
        private Dictionary<string, string> FormatHeaders(IHeaderDictionary headers)
        {
            Dictionary<string, string> pairs = new Dictionary<string, string>();
            foreach (var header in headers)
            {
                pairs.Add(header.Key, header.Value);
            }
            return pairs;
        }

        /// <summary>
        /// Formats query string parameters into a list of key-value pairs.
        /// </summary>
        /// <param name="queryString">The query string to format. Must not be null or empty.</param>
        /// <returns>A <see cref="List{T}"/> of key-value pairs representing the query parameters.</returns>
        /// <remarks>
        /// This method parses the query string and converts it into a list of key-value pairs for logging purposes.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var queryString = "?key1=value1&key2=value2";
        /// var formattedQueries = FormatQueries(queryString);
        /// foreach (var query in formattedQueries)
        /// {
        ///     Console.WriteLine($"Key: {query.Key}, Value: {query.Value}");
        /// </code>
        /// </example>
        private List<KeyValuePair<string, string>> FormatQueries(string queryString)
        {
            List<KeyValuePair<string, string>> pairs = new List<KeyValuePair<string, string>>();
            string key, value;
            foreach (var query in queryString.TrimStart('?').Split("&"))
            {
                var items = query.Split("=");
                key = items.Count() >= 1 ? items[0] : string.Empty;
                value = items.Count() >= 2 ? items[1] : string.Empty;
                if (!string.IsNullOrEmpty(key))
                {
                    pairs.Add(new KeyValuePair<string, string>(key, value));
                }
            }
            return pairs;
        }

        /// <summary>
        /// Reads the body of an HTTP request.
        /// </summary>
        /// <param name="request">The <see cref="HttpRequest"/> instance to read the body from. Must not be null.</param>
        /// <returns>A <see cref="Task{TResult}"/> representing the asynchronous operation, with a result of the request body as a <see cref="string"/>.</returns>
        /// <remarks>
        /// This method reads the body of the HTTP request and resets the stream position for subsequent middleware in the pipeline.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var requestBody = await ReadBodyFromRequest(httpContext.Request);
        /// Console.WriteLine($"Request Body: {requestBody}");
        /// </code>
        /// </example>
        private async Task<string> ReadBodyFromRequest(HttpRequest request)
        {
            // Ensure the request's body can be read multiple times (for the next middlewares in the pipeline).
            request.EnableBuffering();
            using var streamReader = new StreamReader(request.Body, leaveOpen: true);
            var requestBody = await streamReader.ReadToEndAsync();
            // Reset the request's body stream position for next middleware in the pipeline.
            request.Body.Position = 0;
            return requestBody;
        }

        private readonly RequestDelegate _next;
        private readonly RequestResponseLoggerOption _options;
        private readonly IRequestResponseLogger _logger;

    }


}
