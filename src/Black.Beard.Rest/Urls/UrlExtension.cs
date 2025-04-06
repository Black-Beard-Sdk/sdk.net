using Bb.Helpers;
using Bb.Http;
using Bb.Urls;
using RestSharp;
using System.Text;

namespace Bb.Urls
{


        /// <summary>
        /// Provides extension methods for working with URLs, including manipulation of paths, query parameters, fragments, and creating REST clients.
        /// </summary>
        /// <remarks>
        /// This class contains a variety of helper methods for handling and modifying URLs. It supports operations such as:
        /// - Creating and configuring <see cref="RestClient"/> instances.
        /// - Mapping variables in URLs to specific values.
        /// - Concatenating multiple URLs into a single string.
        /// - Adding, removing, and modifying query parameters.
        /// - Manipulating URL paths and fragments.
        /// - Resetting URLs to their root components.
        /// These methods simplify common URL-related tasks in web applications.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var url = "https://example.com/{id}".Map("id", "123");
        /// Console.WriteLine(url); // Output: https://example.com/123
        ///
        /// var urls = new List&lt;Url&gt; { new Url("https://example1.com"), new Url("https://example2.com") };
        /// var result = urls.ConcatUrl();
        /// Console.WriteLine(result); // Output: https://example1.com;https://example2.com
        /// </code>
        /// </example>
        public static partial class UrlExtension
    {

        /// <summary>
        /// Creates a new <see cref="RestClient"/> instance using the specified <see cref="Url"/>.
        /// </summary>
        /// <param name="url">The <see cref="Url"/> instance to use for creating the client. Must not be null.</param>
        /// <returns>A new <see cref="RestClient"/> instance configured with the root URL.</returns>
        /// <remarks>
        /// This method initializes a REST client using the root URL of the provided <see cref="Url"/> instance.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var url = new Url("https://example.com");
        /// var client = url.RestClient();
        /// </code>
        /// </example>
        public static RestClient RestClient(this Url url)
        {
            return new RestClient(url.ToUri());
        }

        /// <summary>
        /// Maps a variable in the URL to a specified value.
        /// </summary>
        /// <param name="self">The URL string to map. Must not be null or empty.</param>
        /// <param name="variable">The variable name to replace in the URL. Must not be null or empty.</param>
        /// <param name="value">The value to replace the variable with. Must not be null or empty.</param>
        /// <returns>A new <see cref="Url"/> instance with the variable replaced by the specified value.</returns>
        /// <remarks>
        /// This method replaces a variable in the URL with the provided value.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var url = "https://example.com/{id}".Map("id", "123");
        /// Console.WriteLine(url); // Output: https://example.com/123
        /// </code>
        /// </example>
        public static Url Map(this string self, string variable, string value)
        {
            Url url = new Url(self);
            url.Map(variable, value);
            return url;
        }

        /// <summary>
        /// Concatenates a collection of URLs into a single <see cref="StringBuilder"/> separated by semicolons.
        /// </summary>
        /// <param name="urls">The collection of <see cref="Url"/> instances to concatenate. Must not be null.</param>
        /// <returns>A <see cref="StringBuilder"/> containing the concatenated URLs.</returns>
        /// <remarks>
        /// This method combines multiple URLs into a single string, separated by semicolons.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var urls = new List&lt;Url&gt; { new Url("https://example1.com"), new Url("https://example2.com") };
        /// var result = urls.ConcatUrl();
        /// Console.WriteLine(result); // Output: https://example1.com;https://example2.com
        /// </code>
        /// </example>
        public static StringBuilder CombineUrl(this IEnumerable<Url> urls)
        {
            return new StringBuilder().CombineUrl(urls);
        }
        
        /// <summary>
        /// Concatenates a collection of URLs into the provided <see cref="StringBuilder"/> separated by semicolons.
        /// </summary>
        /// <param name="sb">The <see cref="StringBuilder"/> to append the URLs to. If null, a new instance is created.</param>
        /// <param name="urls">The collection of <see cref="Url"/> instances to concatenate. Must not be null.</param>
        /// <returns>The <see cref="StringBuilder"/> containing the concatenated URLs.</returns>
        /// <remarks>
        /// This method appends multiple URLs to the provided <see cref="StringBuilder"/>, separated by semicolons.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var sb = new StringBuilder();
        /// var urls = new List&lt;Url&gt; { new Url("https://example1.com"), new Url("https://example2.com") };
        /// sb.ConcatUrl(urls);
        /// Console.WriteLine(sb); // Output: https://example1.com;https://example2.com
        /// </code>
        /// </example>
        public static StringBuilder CombineUrl(this StringBuilder sb, IEnumerable<Url> urls)
        {
            if (sb == null)
                sb = new StringBuilder(200);
            string comma = string.Empty;
            foreach (var url in urls)
            {
                sb.Append(comma);
                sb.Append(url.ToString());
                comma = ";";
            }
            return sb;
        }

        /// <summary>
        /// Creates a new Url object from the string and appends a segment to the URL path, ensuring there is one and only one '/' character as a separator.
        /// </summary>
        /// <param name="url">This URL.</param>
        /// <param name="segment">The segment to append</param>
        /// <param name="fullyEncode">If true, URL-encodes reserved characters such as '/', '+', and '%'. Otherwise, only encodes strictly illegal characters (including '%' but only when not followed by 2 hex characters).</param>
        /// <returns>A new Url object.</returns>
        public static Url WithPathSegment(this string url, string segment)
        {
            return new Url(url).WithPathSegment(segment);
        }

        /// <summary>
        /// Appends multiple segments to the URL path, ensuring there is one and only one '/' character as a separator.
        /// </summary>
        /// <param name="url">This URL.</param>
        /// <param name="segments">The segments to append</param>
        /// <returns>A new Url object.</returns>
        public static Url WithPathSegment(this string url, params string[] segments)
        {
            return new Url(url).WithPathSegment(segments);
        }

        /// <summary>
        /// Appends multiple segments to the URL path, ensuring there is one and only one '/' character as a separator.
        /// </summary>
        /// <param name="url">This URL.</param>
        /// <param name="segments">The segments to append</param>
        /// <returns>A new Url object.</returns>
        public static Url WithPathSegment(this string url, IEnumerable<string> segments)
        {
            return new Url(url).WithPathSegment(segments);
        }

        /// <summary>
        /// Removes the last path segment from the URL.
        /// </summary>
        /// <param name="url">This URL.</param>
        /// <returns>A new Url object.</returns>
        public static Url RemoveLastPathSegment(this string url)
        {
            return new Url(url).RemoveLastPathSegment();
        }

        /// <summary>
        /// Removes the entire path component of the URL.
        /// </summary>
        /// <param name="url">This URL.</param>
        /// <returns>A new Url object.</returns>
        public static Url RemovePath(this string url)
        {
            return new Url(url).RemovePath();
        }

        /// <summary>
        /// Creates a new Url object from the string and adds a parameter to the query, overwriting the value if name exists.
        /// </summary>
        /// <param name="url">This URL.</param>
        /// <param name="name">Name of query parameter</param>
        /// <param name="value">Value of query parameter</param>
        /// <param name="nullValueHandling">Indicates how to handle null values. Defaults to Remove (any existing)</param>
        /// <returns>A new Url object.</returns>
        public static Url SetQueryParam(this string url, string name, object value, NullValueHandling nullValueHandling = NullValueHandling.Remove)
        {
            return new Url(url).WithQueryParam(name, value, nullValueHandling);
        }

        /// <summary>
        /// Creates a new Url object from the string and adds a parameter to the query, overwriting the value if name exists.
        /// </summary>
        /// <param name="url">This URL.</param>
        /// <param name="name">Name of query parameter</param>
        /// <param name="value">Value of query parameter</param>
        /// <param name="isEncoded">Set to true to indicate the value is already URL-encoded. Defaults to false.</param>
        /// <param name="nullValueHandling">Indicates how to handle null values. Defaults to Remove (any existing).</param>
        /// <returns>A new Url object.</returns>
        public static Url SetQueryParam(this string url, string name, string value, bool isEncoded = false, NullValueHandling nullValueHandling = NullValueHandling.Remove)
        {
            return new Url(url).WithQueryParam(name, value, isEncoded, nullValueHandling);
        }

        /// <summary>
        /// Creates a new Url object from the string and adds a parameter without a value to the query, removing any existing value.
        /// </summary>
        /// <param name="url">This URL.</param>
        /// <param name="name">Name of query parameter</param>
        /// <returns>A new Url object.</returns>
        public static Url SetQueryParam(this string url, string name)
        {
            return new Url(url).WithQueryParam(name);
        }

        /// <summary>
        /// Creates a new Url object from the string, parses values object into name/value pairs, and adds them to the query, overwriting any that already exist.
        /// </summary>
        /// <param name="url">This URL.</param>
        /// <param name="values">Typically an anonymous object, ie: new { x = 1, y = 2 }</param>
        /// <param name="nullValueHandling">Indicates how to handle null values. Defaults to Remove (any existing)</param>
        /// <returns>A new Url object.</returns>
        public static Url SetQueryParam(this string url, object values, NullValueHandling nullValueHandling = NullValueHandling.Remove)
        {
            return new Url(url).WithQueryParam(values, nullValueHandling);
        }

        /// <summary>
        /// Creates a new Url object from the string and adds multiple parameters without values to the query.
        /// </summary>
        /// <param name="url">This URL.</param>
        /// <param name="names">Names of query parameters.</param>
        /// <returns>A new Url object.</returns>
        public static Url SetQueryParam(this string url, IEnumerable<string> names)
        {
            return new Url(url).WithQueryParam(names);
        }

        /// <summary>
        /// Creates a new Url object from the string and adds multiple parameters without values to the query.
        /// </summary>
        /// <param name="url">This URL.</param>
        /// <param name="names">Names of query parameters</param>
        /// <returns>A new Url object.</returns>
        public static Url SetQueryParam(this string url, params string[] names)
        {
            return new Url(url).WithQueryParam(names);
        }

        /// <summary>
        /// Creates a new Url object from the string and removes a name/value pair from the query by name.
        /// </summary>
        /// <param name="url">This URL.</param>
        /// <param name="name">Query string parameter name to remove</param>
        /// <returns>A new Url object.</returns>
        public static Url RemoveQueryParam(this string url, string name)
        {
            return new Url(url).RemoveQueryParam(name);
        }

        /// <summary>
        /// Creates a new Url object from the string and removes multiple name/value pairs from the query by name.
        /// </summary>
        /// <param name="url">This URL.</param>
        /// <param name="names">Query string parameter names to remove</param>
        /// <returns>A new Url object.</returns>
        public static Url RemoveQueryParam(this string url, params string[] names)
        {
            return new Url(url).RemoveQueryParam(names);
        }

        /// <summary>
        /// Creates a new Url object from the string and removes multiple name/value pairs from the query by name.
        /// </summary>
        /// <param name="url">This URL.</param>
        /// <param name="names">Query string parameter names to remove</param>
        /// <returns>A new Url object.</returns>
        public static Url RemoveQueryParam(this string url, IEnumerable<string> names)
        {
            return new Url(url).RemoveQueryParam(names);
        }

        /// <summary>
        /// Removes the entire query component of the URL.
        /// </summary>
        /// <param name="url">This URL.</param>
        /// <returns>A new Url object.</returns>
        public static Url RemoveQuery(this string url)
        {
            return new Url(url).RemoveQuery();
        }

        /// <summary>
        /// Set the URL fragment fluently.
        /// </summary>
        /// <param name="url">This URL.</param>
        /// <param name="fragment">The part of the URL after #</param>
        /// <returns>A new Url object.</returns>
        public static Url SetFragment(this string url, string fragment)
        {
            return new Url(url).SetFragment(fragment);
        }

        /// <summary>
        /// Removes the URL fragment including the #.
        /// </summary>
        /// <param name="url">This URL.</param>
        /// <returns>A new Url object.</returns>
        public static Url RemoveFragment(this string url)
        {
            return new Url(url).RemoveFragment();
        }

        /// <summary>
        /// Trims the URL to its root, including the scheme, any user info, host, and port (if specified).
        /// </summary>
        /// <param name="url">This URL.</param>
        /// <returns>A new Url object.</returns>
        public static Url ResetToRoot(this string url)
        {
            return new Url(url).ResetToRoot();
        }

        /// <summary>
        /// Creates a new Url object from the string and appends a segment to the URL path, ensuring there is one and only one '/' character as a separator.
        /// </summary>
        /// <param name="uri">This System.Uri.</param>
        /// <param name="segment">The segment to append</param>
        /// <param name="fullyEncode">If true, URL-encodes reserved characters such as '/', '+', and '%'. Otherwise, only encodes strictly illegal characters (including '%' but only when not followed by 2 hex characters).</param>
        /// <returns>A new Url object.</returns>
        public static Url WithPathSegment(this Uri uri, string segment)
        {
            return new Url(uri).WithPathSegment(segment);
        }

        /// <summary>
        /// Appends multiple segments to the URL path, ensuring there is one and only one '/' character as a separator.
        /// </summary>
        /// <param name="uri">This System.Uri.</param>
        /// <param name="segments">The segments to append</param>
        /// <returns>A new Url object.</returns>
        public static Url WithPathSegment(this Uri uri, params string[] segments)
        {
            return new Url(uri).WithPathSegment(segments);
        }

        /// <summary>
        /// Appends multiple segments to the URL path, ensuring there is one and only one '/' character as a separator.
        /// </summary>
        /// <param name="uri">This System.Uri.</param>
        /// <param name="segments">The segments to append</param>
        /// <returns>A new Url object.</returns>
        public static Url WithPathSegment(this Uri uri, IEnumerable<string> segments)
        {
            return new Url(uri).WithPathSegment(segments);
        }

        /// <summary>
        /// Removes the last path segment from the URL.
        /// </summary>
        /// <param name="uri">This System.Uri.</param>
        /// <returns>A new Url object.</returns>
        public static Url WithRemovePathSegment(this Uri uri)
        {
            return new Url(uri).RemoveLastPathSegment();
        }

        /// <summary>
        /// Removes the entire path component of the URL.
        /// </summary>
        /// <param name="uri">This System.Uri.</param>
        /// <returns>A new Url object.</returns>
        public static Url WithRemovePath(this Uri uri)
        {
            return new Url(uri).RemovePath();
        }

        /// <summary>
        /// Creates a new Url object from the string and adds a parameter to the query, overwriting the value if name exists.
        /// </summary>
        /// <param name="uri">This System.Uri.</param>
        /// <param name="name">Name of query parameter</param>
        /// <param name="value">Value of query parameter</param>
        /// <param name="nullValueHandling">Indicates how to handle null values. Defaults to Remove (any existing)</param>
        /// <returns>A new Url object.</returns>
        public static Url WithQueryParam(this Uri uri, string name, object value, NullValueHandling nullValueHandling = NullValueHandling.Remove)
        {
            return new Url(uri).WithQueryParam(name, value, nullValueHandling);
        }

        /// <summary>
        /// Creates a new Url object from the string and adds a parameter to the query, overwriting the value if name exists.
        /// </summary>
        /// <param name="uri">This System.Uri.</param>
        /// <param name="name">Name of query parameter</param>
        /// <param name="value">Value of query parameter</param>
        /// <param name="isEncoded">Set to true to indicate the value is already URL-encoded. Defaults to false.</param>
        /// <param name="nullValueHandling">Indicates how to handle null values. Defaults to Remove (any existing).</param>
        /// <returns>A new Url object.</returns>
        public static Url WithQueryParam(this Uri uri, string name, string value, bool isEncoded = false, NullValueHandling nullValueHandling = NullValueHandling.Remove)
        {
            return new Url(uri).WithQueryParam(name, value, isEncoded, nullValueHandling);
        }

        /// <summary>
        /// Creates a new Url object from the string and adds a parameter without a value to the query, removing any existing value.
        /// </summary>
        /// <param name="uri">This System.Uri.</param>
        /// <param name="name">Name of query parameter</param>
        /// <returns>A new Url object.</returns>
        public static Url WithQueryParam(this Uri uri, string name)
        {
            return new Url(uri).WithQueryParam(name);
        }

        /// <summary>
        /// Creates a new Url object from the string, parses values object into name/value pairs, and adds them to the query, overwriting any that already exist.
        /// </summary>
        /// <param name="uri">This System.Uri.</param>
        /// <param name="values">Typically an anonymous object, ie: new { x = 1, y = 2 }</param>
        /// <param name="nullValueHandling">Indicates how to handle null values. Defaults to Remove (any existing)</param>
        /// <returns>A new Url object.</returns>
        public static Url WithQueryParam(this Uri uri, object values, NullValueHandling nullValueHandling = NullValueHandling.Remove)
        {
            return new Url(uri).WithQueryParam(values, nullValueHandling);
        }

        /// <summary>
        /// Creates a new Url object from the string and adds multiple parameters without values to the query.
        /// </summary>
        /// <param name="uri">This System.Uri.</param>
        /// <param name="names">Names of query parameters.</param>
        /// <returns>A new Url object.</returns>
        public static Url WithQueryParam(this Uri uri, IEnumerable<string> names)
        {
            return new Url(uri).WithQueryParam(names);
        }

        /// <summary>
        /// Creates a new Url object from the string and adds multiple parameters without values to the query.
        /// </summary>
        /// <param name="uri">This System.Uri.</param>
        /// <param name="names">Names of query parameters</param>
        /// <returns>A new Url object.</returns>
        public static Url WithQueryParam(this Uri uri, params string[] names)
        {
            return new Url(uri).WithQueryParam(names);
        }

        /// <summary>
        /// Creates a new Url object from the string and removes a name/value pair from the query by name.
        /// </summary>
        /// <param name="uri">This System.Uri.</param>
        /// <param name="name">Query string parameter name to remove</param>
        /// <returns>A new Url object.</returns>
        public static Url WithRemoveQueryParam(this Uri uri, string name)
        {
            return new Url(uri).RemoveQueryParam(name);
        }

        /// <summary>
        /// Creates a new Url object from the string and removes multiple name/value pairs from the query by name.
        /// </summary>
        /// <param name="uri">This System.Uri.</param>
        /// <param name="names">Query string parameter names to remove</param>
        /// <returns>A new Url object.</returns>
        public static Url WithRemoveQueryParam(this Uri uri, params string[] names)
        {
            return new Url(uri).RemoveQueryParam(names);
        }

        /// <summary>
        /// Creates a new Url object from the string and removes multiple name/value pairs from the query by name.
        /// </summary>
        /// <param name="uri">This System.Uri.</param>
        /// <param name="names">Query string parameter names to remove</param>
        /// <returns>A new Url object.</returns>
        public static Url WithRemoveQueryParam(this Uri uri, IEnumerable<string> names)
        {
            return new Url(uri).RemoveQueryParam(names);
        }

        /// <summary>
        /// Removes the entire query component of the URL.
        /// </summary>
        /// <param name="uri">This System.Uri.</param>
        /// <returns>A new Url object.</returns>
        public static Url WithRemoveQuery(this Uri uri)
        {
            return new Url(uri).RemoveQuery();
        }

        /// <summary>
        /// Set the URL fragment fluently.
        /// </summary>
        /// <param name="uri">This System.Uri.</param>
        /// <param name="fragment">The part of the URL after #</param>
        /// <returns>A new Url object.</returns>
        public static Url WithFragment(this Uri uri, string fragment)
        {
            return new Url(uri).SetFragment(fragment);
        }

        /// <summary>
        /// Removes the URL fragment including the #.
        /// </summary>
        /// <param name="uri">This System.Uri.</param>
        /// <returns>A new Url object.</returns>
        public static Url WithRemoveFragment(this Uri uri)
        {
            return new Url(uri).RemoveFragment();
        }

        /// <summary>
        /// Trims the URL to its root, including the scheme, any user info, host, and port (if specified).
        /// </summary>
        /// <param name="uri">This System.Uri.</param>
        /// <returns>A new Url object.</returns>
        public static Url WithResetToRoot(this Uri uri)
        {
            return new Url(uri).ResetToRoot();
        }

        /// <summary>
        /// Retrieves an authentication token asynchronously using the specified credentials.
        /// </summary>
        /// <param name="self">The the url on the server. Must not be null.</param>
        /// <param name="path">The endpoint path for the token request. Must not be null or empty.</param>
        /// <param name="client_id">The client ID for authentication. Must not be null or empty.</param>
        /// <param name="client_secret">The client secret for authentication. Can be null or empty.</param>
        /// <param name="username">The username for authentication. Must not be null or empty.</param>
        /// <param name="password">The password for authentication. Must not be null or empty.</param>
        /// <returns>A <see cref="Task{TResult}"/> representing the asynchronous operation, with a result of <see cref="TokenResponse"/> containing the token details.</returns>
        /// <remarks>
        /// This method sends a POST request to the specified endpoint to retrieve an authentication token using the provided credentials.
        /// </remarks>
        /// <exception cref="ArgumentNullException">
        /// Thrown if <paramref name="self"/>, <paramref name="path"/>, <paramref name="client_id"/>, <paramref name="username"/>, or <paramref name="password"/> is null or empty.
        /// </exception>
        /// <exception cref="Exception">
        /// Thrown if the token request fails or the response is not successful.
        /// </exception>
        /// <example>
        /// <code lang="C#">
        /// var client = new RestClient("https://example.com");
        /// var tokenResponse = await client.GetTokenAsync("/token", "myClientId", "myClientSecret", "myUsername", "myPassword");
        /// </code>
        /// </example>
        public static async Task<TokenResponse?> GetTokenAsync(this Url self, string client_id, string client_secret, string username, string password)
        {
            var client = GlobalSettings.UrlClientFactory.Create(self.BaseAddress);
            return await client.GetTokenAsync(self.Path, client_id, client_secret, username, password);
        }


        public static async Task<RestResponse?> CallAsync(this Url self, Method method, DataFormat? format = null)
        {
            var client = GlobalSettings.UrlClientFactory.Create(self.BaseAddress);
            var request = method.NewRequest(self.Path, format);
            return await client.ExecuteAsync(request);
        }

        public static async Task<RestResponse?> CallAsync(this Url self, Method method, Action<RestRequest> initializer)
        {
            var client = GlobalSettings.UrlClientFactory.Create(self.BaseAddress);
            var request = method.NewRequest(self.Path, DataFormat.Json);
            initializer(request);
            return await client.ExecuteAsync(request);
        }

        public static async Task<RestResponse?> CallAsync(this Url self, Method method, DataFormat? format, Action<RestRequest> initializer)
        {
            var client = GlobalSettings.UrlClientFactory.Create(self.BaseAddress);
            var request = method.NewRequest(self.Path, format);
            initializer(request);
            return await client.ExecuteAsync(request);
        }


    }

}
