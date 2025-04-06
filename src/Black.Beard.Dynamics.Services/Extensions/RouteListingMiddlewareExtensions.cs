using Bb.Middleware;

namespace Bb.Extensions
{
    /// <summary>
    /// Extension methods for configuring the route listing middleware in ASP.NET Core applications.
    /// </summary>
    public static class RouteListingMiddlewareExtensions
    {
        /// <summary>
        /// Adds the route listing middleware to the application's request pipeline.
        /// </summary>
        /// <param name="builder">The <see cref="IApplicationBuilder"/> instance to configure. Must not be null.</param>
        /// <returns>The configured <see cref="IApplicationBuilder"/> instance.</returns>
        /// <remarks>
        /// This middleware provides a mechanism to list all registered routes in the application, which can be useful for debugging and documentation purposes.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var builder = WebApplication.CreateBuilder(args);
        /// var app = builder.Build();
        /// app.UseRouteListing();
        /// app.Run();
        /// </code>
        /// </example>
        public static IApplicationBuilder UseRouteListing(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<RouteListingMiddleware>();
        }
    }
}
