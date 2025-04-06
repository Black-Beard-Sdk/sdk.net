namespace Bb.Urls
{

    /// <summary>
    /// Provides extension methods for fluently configuring and modifying <see cref="Url"/> objects.
    /// </summary>
    /// <remarks>
    /// The <see cref="Url2Extension"/> class contains helper methods for setting various components of a <see cref="Url"/> object, such as user information, host, port, and scheme. These methods enable a fluent API for constructing and modifying URLs.
    /// </remarks>
    /// <example>
    /// <code lang="C#">
    /// var url = new Url("https://example.com")
    ///     .WithUserInfo("user:pass")
    ///     .WithHost("example.org")
    ///     .WithPort(8080)
    ///     .WithHttps();
    /// Console.WriteLine(url.ToString()); // Output: https://user:pass@example.org:8080
    /// </code>
    /// </example>
    public static partial class UrlExtension
    {
        /// <summary>
        /// Sets the user information for the specified <see cref="Url"/> object.
        /// </summary>
        /// <param name="self">The <see cref="Url"/> object to modify. Must not be null.</param>
        /// <param name="userInfo">The user information to set, such as "user:pass". Must not be null or empty.</param>
        /// <returns>The modified <see cref="Url"/> object.</returns>
        /// <remarks>
        /// This method sets the "user:pass" part of the URL.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var url = new Url("https://example.com").WithUserInfo("user:pass");
        /// Console.WriteLine(url.ToString()); // Output: https://user:pass@example.com
        /// </code>
        /// </example>
        public static Url WithUserInfo(this Url self, string userInfo)
        {
            self.UserName = userInfo;
            return self;
        }

        /// <summary>
        /// Sets the host for the specified <see cref="Url"/> object.
        /// </summary>
        /// <param name="self">The <see cref="Url"/> object to modify. Must not be null.</param>
        /// <param name="host">The host to set, such as "example.org". Must not be null or empty.</param>
        /// <returns>The modified <see cref="Url"/> object.</returns>
        /// <remarks>
        /// This method sets the host part of the URL.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var url = new Url("https://example.com").WithHost("example.org");
        /// Console.WriteLine(url.ToString()); // Output: https://example.org
        /// </code>
        /// </example>
        public static Url WithHost(this Url self, string host)
        {
            self.Host = host;
            return self;
        }

        /// <summary>
        /// Sets the port for the specified <see cref="Url"/> object.
        /// </summary>
        /// <param name="self">The <see cref="Url"/> object to modify. Must not be null.</param>
        /// <param name="port">The port to set, such as 8080. Must be a valid port number.</param>
        /// <returns>The modified <see cref="Url"/> object.</returns>
        /// <remarks>
        /// This method sets the port part of the URL.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var url = new Url("https://example.com").WithPort(8080);
        /// Console.WriteLine(url.ToString()); // Output: https://example.com:8080
        /// </code>
        /// </example>
        public static Url WithPort(this Url self, int port)
        {
            self.Port = port;
            return self;
        }

        /// <summary>
        /// Sets the scheme of the specified <see cref="Url"/> object to "http".
        /// </summary>
        /// <param name="self">The <see cref="Url"/> object to modify. Must not be null.</param>
        /// <returns>The modified <see cref="Url"/> object.</returns>
        /// <remarks>
        /// This method sets the scheme of the URL to "http".
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var url = new Url("https://example.com").WithHttp();
        /// Console.WriteLine(url.ToString()); // Output: http://example.com
        /// </code>
        /// </example>
        public static Url WithHttp(this Url self)
        {
            self.Scheme = "http";
            return self;
        }

        /// <summary>
        /// Sets the scheme of the specified <see cref="Url"/> object to "https".
        /// </summary>
        /// <param name="self">The <see cref="Url"/> object to modify. Must not be null.</param>
        /// <returns>The modified <see cref="Url"/> object.</returns>
        /// <remarks>
        /// This method sets the scheme of the URL to "https".
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var url = new Url("http://example.com").WithHttps();
        /// Console.WriteLine(url.ToString()); // Output: https://example.com
        /// </code>
        /// </example>
        public static Url WithHttps(this Url self)
        {
            self.Scheme = "https";
            return self;
        }
    }
}
