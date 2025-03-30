using System.Text;

namespace Bb.Middleware
{

    public class RouteListingMiddleware
    {        

        public RouteListingMiddleware(RequestDelegate next, ILogger<RouteListingMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context, EndpointDataSource endpointDataSource)
        {
            var sb = new StringBuilder();
            sb.AppendLine("Registered routes:");

            foreach (var endpoint in endpointDataSource.Endpoints)
            {
                if (endpoint is RouteEndpoint routeEndpoint)
                {
                    sb.AppendLine($"- {routeEndpoint.RoutePattern.RawText}");
                }
            }

            _logger.LogInformation(sb.ToString());

            await _next(context);
        }


        private readonly RequestDelegate _next;
        private readonly ILogger<RouteListingMiddleware> _logger;

    }
}
