using Bb.Util;
using RestSharp;

namespace Bb.Extensions
{

    /// <summary>
    /// Extension methods for <see cref="HttpContext"/> to facilitate setting HTTP responses.
    /// </summary>
    public static class HttpContextExtension
    {

        static HttpContextExtension()
        {
            IsDebug = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "Development";
        }

        /// <summary>
        /// Indicates whether the application is running in debug mode.
        /// </summary>
        /// <remarks>
        /// This property checks the "ASPNETCORE_ENVIRONMENT" environment variable to determine if the application is in the "Development" environment.
        /// </remarks>
        public static bool IsDebug { get; }

        /// <summary>
        /// Sets the HTTP response with the specified data serialized as JSON.
        /// </summary>
        /// <param name="context">The <see cref="HttpContext"/> to set the response for. Must not be null.</param>
        /// <param name="data">The object to serialize and include in the response. Must not be null.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        /// <remarks>
        /// This method serializes the provided data into JSON format and sets it as the HTTP response content.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var context = new DefaultHttpContext();
        /// var data = new { Message = "Hello, World!" };
        /// await context.SetResponse(data);
        /// </code>
        /// </example>
        public static async Task SetResponse(this HttpContext context, object data)
        {
            var datas = data.Serialize(IsDebug) ?? string.Empty;
            await context.SetResponse(ContentTypes.ApplicationJson, datas);
        }

        /// <summary>
        /// Sets the HTTP response with the specified content type and data.
        /// </summary>
        /// <param name="context">The <see cref="HttpContext"/> to set the response for. Must not be null.</param>
        /// <param name="contentType">The content type of the response. Must not be null or empty.</param>
        /// <param name="data">The string data to include in the response. Must not be null.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        /// <remarks>
        /// This method sets the HTTP response content type and writes the provided string data to the response.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var context = new DefaultHttpContext();
        /// await context.SetResponse(ContentTypes.ApplicationJson, "{\"Message\":\"Hello, World!\"}");
        /// </code>
        /// </example>
        public static async Task SetResponse(this HttpContext context, ContentType contentType, string data)
        {
            context.Response.ContentType = contentType;
            await context.Response.WriteAsync(data);
        }

    }

}
