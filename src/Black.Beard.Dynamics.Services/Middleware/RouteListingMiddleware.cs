using System.Text;

namespace Bb.Middleware
{

    /// <summary>
    /// Middleware that logs all registered routes in the application.
    /// </summary>
    public class RouteListingMiddleware
    {        

        /// <summary>
        /// Initializes a new instance of the <see cref="RouteListingMiddleware"/> class.
        /// </summary>
        /// <param name="next">The next middleware in the pipeline. Must not be null.</param>
        /// <param name="logger">The <see cref="ILogger{RouteListingMiddleware}"/> instance used for logging. Must not be null.</param>
        /// <remarks>
        /// This constructor sets up the middleware to log all registered routes in the application.
        /// </remarks>
        /// <exception cref="ArgumentNullException">
        /// Thrown if <paramref name="next"/> or <paramref name="logger"/> is null.
        /// </exception>
        public RouteListingMiddleware(RequestDelegate next, ILogger<RouteListingMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        /// <summary>
        /// Processes an HTTP request and logs all registered routes in the application.
        /// </summary>
        /// <param name="context">The <see cref="HttpContext"/> representing the current HTTP request. Must not be null.</param>
        /// <param name="endpointDataSource">The <see cref="EndpointDataSource"/> containing the registered endpoints. Must not be null.</param>
        /// <returns>A <see cref="Task"/> that represents the asynchronous operation.</returns>
        /// <remarks>
        /// This method iterates through all registered endpoints in the application and logs their route patterns.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var builder = WebApplication.CreateBuilder(args);
        /// var app = builder.Build();
        /// app.UseMiddleware&lt;RouteListingMiddleware&gt;();
        /// app.Run();
        /// </code>
        /// </example>
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
