using Microsoft.AspNetCore.Http.Extensions;
using System.Text;

namespace Bb.Middleware
{

    internal class HttpInfoLoggerMiddleware
    {

        public HttpInfoLoggerMiddleware(RequestDelegate next, ILogger<HttpInfoLoggerMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        // RemoteIpAddress = ::1 is localhost
        // https://stackoverflow.com/questions/28664686/how-do-i-get-client-ip-address-in-asp-net-core

        public async Task InvokeAsync(HttpContext context)
        {

            if (System.Diagnostics.Trace.CorrelationManager.ActivityId == Guid.Empty)
                System.Diagnostics.Trace.CorrelationManager.ActivityId = Guid.NewGuid();

            using (_logger.BeginScope(new[]
            {
                new KeyValuePair<string, object>("{url}", context.Request?.GetDisplayUrl()),
                new KeyValuePair<string, object>("{RemoteIpAddress}", context.Connection.RemoteIpAddress),
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



        private StringBuilder LogRequest(HttpContext context)
        {
            return TraceRequest(context.Request);
        }

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

                if (form.Count > 0)
                    foreach (var item in form)
                    {
                        sb.AppendLine($"Key ({item.Key}) ");
                        var file = form.Files.Where(c => c.Name == item.Key).FirstOrDefault();
                        if (file != null)
                        {
                            sb.AppendLine($"    File:");
                            sb.AppendLine($"      Name: {file.Name}");
                            sb.AppendLine($"      FileName: {file.FileName}");
                            sb.AppendLine($"      Length: {file.Length}");
                            foreach (var item2 in file.Headers)
                                sb.AppendLine($"    Header : {item2.Key}: {item2.Value}");
                        }
                        else
                            sb.AppendLine($"value ({item.Value}) ");
                    }
                else
                    foreach (var item in form.Files)
                    {
                        sb.AppendLine($"    File:");
                        sb.AppendLine($"      Name: {item.Name}");
                        sb.AppendLine($"      FileName: {item.FileName}");
                        sb.AppendLine($"      Length: {item.Length}");
                        foreach (var item2 in item.Headers)
                            sb.AppendLine($"    Header : {item2.Key}: {item2.Value}");
                    }

            }

            return sb;

        }

        private static IFormCollection? TryToGetForm(HttpRequest r)
        {
            IFormCollection form = null;
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


        private StringBuilder LogResponse(HttpContext context)
        {
            return TraceResponse(context.Response);
        }


        private static StringBuilder TraceResponse(HttpResponse r)
        {

            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Response:");
            sb.AppendLine($"Status Code: {r.StatusCode}");

            foreach (var header in r.Headers)
                sb.AppendLine($"Header: {header.Key}: {header.Value}");

            // Si vous souhaitez logger les cookies de la réponse
            //foreach (var cookie in r.Cookies)
            //    sb.AppendLine($"Cookie: {cookie.Key}: {cookie.Value}");

            return sb;

        }

        private readonly RequestDelegate _next;
        private readonly ILogger<HttpInfoLoggerMiddleware> _logger;

    }

}


