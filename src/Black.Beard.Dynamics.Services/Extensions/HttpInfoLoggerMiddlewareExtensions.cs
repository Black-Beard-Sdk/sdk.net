using Bb.Extensions.EntryFullLogger;

namespace Bb.Extensions
{
    public static class HttpInfoLoggerMiddlewareExtensions
    {

        public static IApplicationBuilder UseHttpInfoLogger<T>(this T builder) where T : IApplicationBuilder
        {
            return builder.UseMiddleware<HttpInfoLoggerMiddleware>();
        }

        public static IApplicationBuilder UseHttpExceptionInterceptor<T>(this T builder) where T : IApplicationBuilder
        {
            return builder.UseMiddleware<RequestResponseLoggerMiddleware>();
        }

    }

}
