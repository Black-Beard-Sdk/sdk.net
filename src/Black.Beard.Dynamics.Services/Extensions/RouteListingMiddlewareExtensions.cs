using Bb.Middleware;

namespace Bb.Extensions
{
    public static class RouteListingMiddlewareExtensions
    {
        public static IApplicationBuilder UseRouteListing(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<RouteListingMiddleware>();
        }
    }
}
