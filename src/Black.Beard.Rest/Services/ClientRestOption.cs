// Ignore Spelling: deserialization, charset

using System.Net;

namespace Bb.Services
{
    /// <summary>
    /// Represents options for configuring a REST client.
    /// </summary>
    public class ClientRestOption
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientRestOption"/> class.
        /// </summary>
        /// <remarks>
        /// Sets the <see cref="Debug"/> property to <c>true</c> if a debugger is attached.
        /// </remarks>
        public ClientRestOption()
        {
            this.Debug = System.Diagnostics.Debugger.IsAttached;
        }

        /// <summary>
        /// Gets or sets the timeout duration for requests, in seconds.
        /// </summary>
        /// <value>The timeout duration in seconds. Default is 60 seconds.</value>
        public int Timeout { get; set; } = 60;

        /// <summary>
        /// Gets or sets a value indicating whether debug mode is enabled.
        /// </summary>
        /// <value><c>true</c> if debug mode is enabled; otherwise, <c>false</c>.</value>
        /// <remarks>
        /// When debug mode is enabled, additional logging is performed.
        /// </remarks>
        public bool Debug { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether trace mode is enabled.
        /// </summary>
        /// <value><c>true</c> if trace mode is enabled; otherwise, <c>false</c>.</value>
        /// <remarks>
        /// When trace and log mode is enabled, additional logging is performed.
        /// </remarks>
        public bool Trace { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether to throw an exception on any error.
        /// </summary>
        /// <value><c>true</c> if exceptions should be thrown on any error; otherwise, <c>false</c>.</value>
        /// <remarks>
        /// When set to <c>true</c>, any error during the request will result in an exception.
        /// </remarks>
        public bool ThrowOnAnyError { get; set; } = false;

        /// <summary>
        /// Gets or sets a value indicating whether multiple default parameters with the same name are allowed.
        /// </summary>
        /// <value><c>true</c> if multiple default parameters with the same name are allowed; otherwise, <c>false</c>.</value>
        public bool AllowMultipleDefaultParametersWithSameName { get; set; } = false;

        /// <summary>
        /// Gets or sets a value indicating whether to throw an exception on deserialization errors.
        /// </summary>
        /// <value><c>true</c> if exceptions should be thrown on deserialization errors; otherwise, <c>false</c>.</value>
        public bool ThrowOnDeSerializationError { get; set; } = false;

        /// <summary>
        /// Gets or sets a value indicating whether to fail silently on deserialization errors.
        /// </summary>
        /// <value><c>true</c> if deserialization errors should fail silently; otherwise, <c>false</c>.</value>
        public bool FailOnDeserializationError { get; set; } = false;

        /// <summary>
        /// Gets or sets a value indicating whether to pre-authenticate requests.
        /// </summary>
        /// <value><c>true</c> if pre-authentication is enabled; otherwise, <c>false</c>.</value>
        public bool PreAuthenticate { get; set; } = false;

        /// <summary>
        /// Gets or sets a value indicating whether to use default credentials for requests.
        /// </summary>
        /// <value><c>true</c> if default credentials are used; otherwise, <c>false</c>.</value>
        public bool UseDefaultCredentials { get; set; } = false;

        /// <summary>
        /// Gets or sets a value indicating whether to disable the charset in requests.
        /// </summary>
        /// <value><c>true</c> if the charset is disabled; otherwise, <c>false</c>.</value>
        public bool DisableCharset { get; set; } = false;

        /// <summary>
        /// Gets or sets a value indicating whether to follow HTTP redirects.
        /// </summary>
        /// <value><c>true</c> if redirects should be followed; otherwise, <c>false</c>.</value>
        /// <remarks>
        /// When set to <c>true</c>, the client will automatically follow HTTP 3xx redirect responses.
        /// </remarks>
        public bool FollowRedirects { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether to expect a 100-Continue response from the server.
        /// </summary>
        /// <value><c>true</c> if 100-Continue is expected; otherwise, <c>false</c>.</value>
        public bool Expect100Continue { get; set; } = false;

        /// <summary>
        /// Gets or sets the decompression methods to use for automatic decompression of response content.
        /// </summary>
        /// <value>The decompression methods to use. Default is <see cref="DecompressionMethods.None"/>.</value>
        public DecompressionMethods AutomaticDecompression { get; set; } = System.Net.DecompressionMethods.None;

        /// <summary>
        /// Gets or sets the maximum number of redirects to follow.
        /// </summary>
        /// <value>The maximum number of redirects. Default is <c>null</c>, meaning no limit is set.</value>
        /// <remarks>
        /// This property is used to limit the number of HTTP 3xx redirects the client will follow.
        /// </remarks>
        public int? MaxRedirects { get; internal set; }


        //CookieContainer = new System.Net.CookieContainer(),                
        //Proxy = null,
        //ClientCertificates = null,
        //CachePolicy = new System.Net.Http.Headers.CacheControlHeaderValue(),
        //Credentials = null,
        //Authenticator = null,
        //Encoding = System.Text.Encoding.UTF8,
        //BaseHost = null,

    }


}
