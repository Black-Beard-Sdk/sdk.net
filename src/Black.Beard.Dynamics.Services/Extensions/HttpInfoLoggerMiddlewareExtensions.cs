
// Ignore Spelling: Middleware

using Bb.Middleware;

namespace Bb.Extensions
{

    /// <summary>
    /// Extension methods for configuring HTTP information logging middleware in a web application.
    /// </summary>
    public static class HttpInfoLoggerMiddlewareExtensions
    {

        /// <summary>
        /// Adds the HTTP information logger middleware to the application's request pipeline.
        /// </summary>
        /// <typeparam name="T">The type of the application builder, which must implement <see cref="IApplicationBuilder"/>.</typeparam>
        /// <param name="builder">The application builder to configure. Must not be null.</param>
        /// <returns>The configured <see cref="IApplicationBuilder"/> instance.</returns>
        /// <remarks>
        /// This middleware logs HTTP request and response information for debugging and monitoring purposes.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var builder = WebApplication.CreateBuilder(args);
        /// var app = builder.Build();
        /// app.UseHttpInfoLogger();
        /// app.Run();
        /// </code>
        /// </example>
        public static IApplicationBuilder UseHttpInfoLogger<T>(this T builder) where T : IApplicationBuilder
        {
            return builder.UseMiddleware<HttpInfoLoggerMiddleware>();
        }

        /// <summary>
        /// Adds the HTTP exception interceptor middleware to the application's request pipeline.
        /// </summary>
        /// <typeparam name="T">The type of the application builder, which must implement <see cref="IApplicationBuilder"/>.</typeparam>
        /// <param name="builder">The application builder to configure. Must not be null.</param>
        /// <returns>The configured <see cref="IApplicationBuilder"/> instance.</returns>
        /// <remarks>
        /// This middleware intercepts HTTP requests and responses to log exceptions and other relevant information.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var builder = WebApplication.CreateBuilder(args);
        /// var app = builder.Build();
        /// app.UseHttpExceptionInterceptor();
        /// app.Run();
        /// </code>
        /// </example>
        public static IApplicationBuilder UseHttpExceptionInterceptor<T>(this T builder) where T : IApplicationBuilder
        {
            return builder.UseMiddleware<RequestResponseLoggerMiddleware>();
        }

    }

}
