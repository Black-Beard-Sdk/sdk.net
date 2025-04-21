// Ignore Spelling: Middleware

using Microsoft.AspNetCore.Http.Extensions;
using System.Net;
using System.Text;

namespace Bb.Middleware
{

    internal class HttpInfoLoggerMiddleware
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="HttpInfoLoggerMiddleware"/> class.
        /// </summary>
        /// <param name="next">The next middleware in the pipeline. Must not be null.</param>
        /// <param name="logger">The <see cref="ILogger{HttpInfoLoggerMiddleware}"/> instance used for logging. Must not be null.</param>
        /// <remarks>
        /// This constructor sets up the middleware to log HTTP request and response details.
        /// </remarks>
        /// <exception cref="ArgumentNullException">
        /// Thrown if <paramref name="next"/> or <paramref name="logger"/> is null.
        /// </exception>
        public HttpInfoLoggerMiddleware(RequestDelegate next, ILogger<HttpInfoLoggerMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        // RemoteIpAddress = ::1 is localhost
        // https://stackoverflow.com/questions/28664686/how-do-i-get-client-ip-address-in-asp-net-core

        /// <summary>
        /// Processes an HTTP request and logs its details, along with the response details.
        /// </summary>
        /// <param name="context">The <see cref="HttpContext"/> representing the current HTTP request. Must not be null.</param>
        /// <returns>A <see cref="Task"/> that represents the asynchronous operation.</returns>
        /// <remarks>
        /// This method logs the HTTP request and response details, including headers, cookies, and form data, if available.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var builder = WebApplication.CreateBuilder(args);
        /// var app = builder.Build();
        /// app.UseMiddleware&lt;HttpInfoLoggerMiddleware&gt;();
        /// app.Run();
        /// </code>
        /// </example>
        public async Task InvokeAsync(HttpContext context)
        {

            if (System.Diagnostics.Trace.CorrelationManager.ActivityId == Guid.Empty)
                System.Diagnostics.Trace.CorrelationManager.ActivityId = Guid.NewGuid();

            using (_logger.BeginScope(new[]
            {
                new KeyValuePair<string, object>("{url}", context.Request?.GetDisplayUrl() ?? "http://?"),
                new KeyValuePair<string, object>("{RemoteIpAddress}", context.Connection.RemoteIpAddress ?? IPAddress.None),
            }))
            {

                StringBuilder sb;
                if (_logger.IsEnabled(LogLevel.Debug))
                {
                    sb = LogRequest(context);
                    _logger.LogDebug(sb.ToString());
                }

                await _next(context);

                if (_logger.IsEnabled(LogLevel.Debug))
                {
                    sb = LogResponse(context);
                    _logger.LogDebug(sb.ToString());
                }
            }

        }

        /// <summary>
        /// Logs the details of the HTTP request.
        /// </summary>
        /// <param name="context">The <see cref="HttpContext"/> representing the current HTTP request. Must not be null.</param>
        /// <returns>A <see cref="StringBuilder"/> containing the logged request details.</returns>
        /// <remarks>
        /// This method captures details such as the HTTP method, URL, headers, cookies, and form data.
        /// </remarks>
        private StringBuilder LogRequest(HttpContext context)
        {
            return TraceRequest(context.Request);
        }

        /// <summary>
        /// Captures the details of an HTTP request.
        /// </summary>
        /// <param name="r">The <see cref="HttpRequest"/> to capture details from. Must not be null.</param>
        /// <returns>A <see cref="StringBuilder"/> containing the captured request details.</returns>
        /// <remarks>
        /// This method captures details such as the HTTP method, URL, headers, cookies, and form data.
        /// </remarks>
        private static StringBuilder TraceRequest(HttpRequest r)
        {

            StringBuilder sb = new StringBuilder();

            sb.Append(r.Method);
            sb.Append(" http");
            if (r.IsHttps)
                sb.Append("s");
            sb.Append("://");
            sb.Append(r.Host);
            sb.Append(r.Path);
            sb.Append(r.QueryString);

            sb.Append(" ");
            sb.AppendLine(r.Protocol);

            foreach (var item in r.Cookies)
                sb.AppendLine($"cookies: {item.Key}: {item.Value}");

            foreach (var item in r.Headers)
                sb.AppendLine($"Header: {item.Key}: {item.Value}");

            var form = TryToGetForm(r);
            if (form != null)
            {
                sb.AppendLine($"Form: ");
                WriteForm(sb, form);
            }

            return sb;

        }

        private static void WriteForm(StringBuilder sb, IFormCollection form)
        {
            if (form.Count > 0)
                foreach (var item in form)
                {
                    sb.AppendLine($"Key ({item.Key}) ");
                    var file = form.Files.FirstOrDefault(c => c.Name == item.Key);
                    if (file != null)
                        WriteFormFile(sb, file);
                    else
                        sb.AppendLine($"value ({item.Value}) ");
                }
            else
                foreach (var item in form.Files)
                    WriteFormFile(sb, item);
        }

        private static void WriteFormFile(StringBuilder sb, IFormFile item)
        {
            sb.AppendLine($"        File:");
            sb.AppendLine($"        Name: {item.Name}");
            sb.AppendLine($"        FileName: {item.FileName}");
            sb.AppendLine($"        Length: {item.Length}");
            foreach (var item2 in item.Headers)
                sb.AppendLine($"        Header : {item2.Key}: {item2.Value}");
        }

        /// <summary>
        /// Attempts to retrieve the form data from an HTTP request.
        /// </summary>
        /// <param name="r">The <see cref="HttpRequest"/> to retrieve form data from. Must not be null.</param>
        /// <returns>An <see cref="IFormCollection"/> containing the form data, or <see langword="null"/> if the form data is not available.</returns>
        /// <remarks>
        /// This method safely attempts to retrieve form data from the request, handling any exceptions that may occur.
        /// </remarks>
        private static IFormCollection? TryToGetForm(HttpRequest r)
        {
            IFormCollection? form = null;
            try
            {
                if (r.HasFormContentType && r.Form != null)
                    form = r.Form;
            }
            catch (Exception)
            {
            }
            return form;
        }

        /// <summary>
        /// Logs the details of the HTTP response.
        /// </summary>
        /// <param name="context">The <see cref="HttpContext"/> representing the current HTTP response. Must not be null.</param>
        /// <returns>A <see cref="StringBuilder"/> containing the logged response details.</returns>
        /// <remarks>
        /// This method captures details such as the status code and response headers.
        /// </remarks>
        private static StringBuilder LogResponse(HttpContext context)
        {
            return TraceResponse(context.Response);
        }

        /// <summary>
        /// Captures the details of an HTTP response.
        /// </summary>
        /// <param name="r">The <see cref="HttpResponse"/> to capture details from. Must not be null.</param>
        /// <returns>A <see cref="StringBuilder"/> containing the captured response details.</returns>
        /// <remarks>
        /// This method captures details such as the status code and response headers.
        /// </remarks>
        private static StringBuilder TraceResponse(HttpResponse r)
        {

            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Response:");
            sb.AppendLine($"Status Code: {r.StatusCode}");

            foreach (var header in r.Headers)
                sb.AppendLine($"Header: {header.Key}: {header.Value}");

            return sb;

        }

        private readonly RequestDelegate _next;
        private readonly ILogger<HttpInfoLoggerMiddleware> _logger;

    }

}


