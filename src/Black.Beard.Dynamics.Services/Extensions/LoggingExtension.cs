using Bb.ComponentModel.Loaders;

namespace Bb.Extensions
{


    /// <summary>
    /// Extension methods for configuring logging and tracing in a web application.
    /// </summary>
    public static class LoggingExtension
    {
        /// <summary>
        /// Configures logging and tracing for the web application builder.
        /// </summary>
        /// <param name="builder">The <see cref="WebApplicationBuilder"/> instance to configure. Must not be null.</param>
        /// <returns>The configured <see cref="WebApplicationBuilder"/> instance.</returns>
        /// <remarks>
        /// This method sets up logging for the web application by using the builder's services to auto-configure logging providers.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var builder = WebApplication.CreateBuilder(args);
        /// builder.ConfigureTrace();
        /// var app = builder.Build();
        /// app.Run();
        /// </code>
        /// </example>
        public static WebApplicationBuilder ConfigureTrace(this WebApplicationBuilder builder)
        {
            builder.WebHost.ConfigureLogging(logging =>
            {
                var services = builder.Services.BuildServiceProvider();
                var i = logging.AutoConfigure(services);
            });

            return builder;
        }
    }
}
