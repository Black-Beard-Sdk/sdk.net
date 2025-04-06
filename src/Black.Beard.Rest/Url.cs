using System.Text.RegularExpressions;

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
    public class Url
    {

        #region public properties

        /// <summary>
        /// Gets or sets the scheme of the URL, such as "http" or "https".
        /// </summary>
        /// <value>A <see cref="string"/> representing the scheme of the URL.</value>
        /// <remarks>
        /// The scheme does not include the ":" delimiter. If the URL is relative, this property is an empty string.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var url = new Url("https://example.com");
        /// Console.WriteLine(url.Scheme); // Output: https
        /// </code>
        /// </example>
        public string Scheme
        {
            get => EnsureParsed()._scheme;
            set
            {
                if (!AllowedSchemes.Contains(value))
                    EnsureParsed()._scheme = value;
                else
                    throw new ArgumentException($"The scheme '{value}' is not allowed. Allowed schemes are: {string.Join(", ", AllowedSchemes)}");
            }
        }

        /// <summary>
        /// Gets or sets the user information in the URL, such as "user:pass".
        /// </summary>
        /// <value>A <see cref="string"/> representing the user information.</value>
        /// <remarks>
        /// This property corresponds to the "user:pass" part of the URL, if present.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var url = new Url("https://user:pass@example.com");
        /// Console.WriteLine(url.UserInfo); // Output: user:pass
        /// </code>
        /// </example>
        public string UserInfo
        {
            get => EnsureParsed()._userInfo;
            set
            {

                EnsureParsed();

                if (!string.IsNullOrEmpty(value))
                {

                    if (value.Contains("@") || value.Contains(":"))
                        throw new ArgumentException("UserInfo cannot contain '@' or ':' characters.");

                    value = Encode(value);

                }

                _userInfo = value;

            }
        }

        /// <summary>
        /// i.e. "www.site.com" in "https://www.site.com:8080/path". Does not include user info or port.
        /// </summary>
        public string Host
        {
            get => EnsureParsed()._host;
            set => EnsureParsed()._host = value;
        }

        /// <summary>
        /// Gets or sets the port of the URL.
        /// </summary>
        /// <value>An <see cref="int?"/> representing the port of the URL, or <see langword="null"/> if not specified.</value>
        /// <remarks>
        /// This property corresponds to the port part of the URL, if explicitly specified.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var url = new Url("https://example.com:8080");
        /// Console.WriteLine(url.Port); // Output: 8080
        /// </code>
        /// </example>
        public int? Port
        {
            get => EnsureParsed()._port;
            set => EnsureParsed()._port = value;
        }

        /// <summary>
        /// Gets the authority of the URL, including user info, host, and port.
        /// </summary>
        /// <value>A <see cref="string"/> representing the authority of the URL.</value>
        /// <remarks>
        /// This property corresponds to the "user:pass@host:port" part of the URL, if present.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var url = new Url("https://user:pass@example.com:8080");
        /// Console.WriteLine(url.Authority); // Output: user:pass@example.com:8080
        /// </code>
        /// </example>
        public string Authority
        {
            get
            {




                return new UriBuilder
                {
                    Scheme = Scheme,
                    Host = Host,
                    Port = Port ?? -1,
                    UserName = UserInfo,

                }.ToString();

                return string.Concat
                (
                    UserInfo,
                    UserInfo?.Length > 0 ? "@" : string.Empty,
                    Host,
                    Port.HasValue ? ":" : string.Empty,
                    Port
                );
            }

        }

        /// <summary>
        /// i.e. "https://www.site.com:8080" in "https://www.site.com:8080/path" (everything before the path).
        /// </summary>
        public string Root
        {
            get
            {
                return new UriBuilder
                {
                    Scheme = Scheme,
                    Host = Host,
                    Port = Port ?? -1,
                    Path = p,
                    Query = Query,
                    Fragment = Fragment,

                }.ToString();
            }
        }

        /// <summary>
        /// Gets the base address of the URL as a <see cref="Uri"/> object.
        /// </summary>
        public Uri BaseAddress
        {
            get
            {
                return new UriBuilder
                {
                    Scheme = Scheme,
                    Host = Host,
                    Port = Port ?? -1,
                    // Path = p,
                    // Query = Query,
                    // Fragment = Fragment,

                }.Uri;
            }
        }

        /// <summary>
        /// Gets or sets the path of the URL.
        /// </summary>
        /// <value>A <see cref="string"/> representing the path of the URL.</value>
        /// <remarks>
        /// This property corresponds to the path part of the URL, including leading and trailing slashes as specified.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var url = new Url("https://example.com/path/to/resource");
        /// Console.WriteLine(url.Path); // Output: /path/to/resource
        /// </code>
        /// </example>
        public string Path
        {
            get
            {

                EnsureParsed();

                List<string> _segments = new List<string>(_pathSegments.Count);
                foreach (Segment item in PathSegments)
                    _segments.Add(item.EncodedValue);

                return string.Concat(
                    _leadingSlash ? Slash : string.Empty,
                    string.Join(Slash, _segments),
                    _trailingSlash && PathSegments.Any() ? Slash : string.Empty);

            }
            set
            {
                PathSegments.Clear();
                _trailingSlash = false;
                if (string.IsNullOrEmpty(value))
                    _leadingSlash = false;
                else if (value == Slash)
                    _leadingSlash = true;
                else
                    WithPathSegment(value ?? string.Empty);
            }
        }

        /// <summary>
        /// The "/"-delimited segments of the path, not including leading or trailing "/" characters.
        /// </summary>
        public IList<Segment> PathSegments => EnsureParsed()._pathSegments;

        /// <summary>
        /// Gets or sets the query string of the URL.
        /// </summary>
        /// <value>A <see cref="string"/> representing the query string of the URL.</value>
        /// <remarks>
        /// This property corresponds to the query part of the URL, excluding the "?" delimiter.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var url = new Url("https://example.com?key=value");
        /// Console.WriteLine(url.Query); // Output: key=value
        /// </code>
        /// </example>
        public string Query
        {
            get => QueryParams.ToString();
            set => EnsureParsed()._queryParams = new QueryParamCollection(value);
        }

        /// <summary>
        /// Query parsed to name/value pairs.
        /// </summary>
        public QueryParamCollection QueryParams => EnsureParsed()._queryParams;

        /// <summary>
        /// Gets or sets the fragment of the URL.
        /// </summary>
        /// <value>A <see cref="string"/> representing the fragment of the URL.</value>
        /// <remarks>
        /// This property corresponds to the fragment part of the URL, excluding the "#" delimiter.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var url = new Url("https://example.com#section");
        /// Console.WriteLine(url.Fragment); // Output: section
        /// </code>
        /// </example>
        public string Fragment
        {
            get => EnsureParsed()._fragment;
            set => EnsureParsed()._fragment = value;
        }

        /// <summary>
        /// Gets a value indicating whether the URL is relative.
        /// </summary>
        /// <value><see langword="true"/> if the URL is relative; otherwise, <see langword="false"/>.</value>
        /// <remarks>
        /// A URL is considered relative if it does not start with a scheme.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var url = new Url("//example.com");
        /// Console.WriteLine(url.IsRelative); // Output: true
        /// </code>
        /// </example>
        public bool IsRelative => string.IsNullOrEmpty(Scheme);

        /// <summary>
        /// Gets a value indicating whether the URL uses a secure scheme.
        /// </summary>
        /// <value><see langword="true"/> if the URL uses "https" or "wss"; otherwise, <see langword="false"/>.</value>
        /// <remarks>
        /// A URL is considered secure if it is absolute and uses a secure scheme.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var url = new Url("https://example.com");
        /// Console.WriteLine(url.IsSecureScheme); // Output: true
        /// </code>
        /// </example>
        public bool IsSecureScheme => !IsRelative && (Scheme.OrdinalEquals("https", true) || Scheme.OrdinalEquals("wss", true));

        #endregion

        #region constructors and parsing methods

        /// <summary>
        /// Constructs a Url object from another Url object.
        /// </summary>
        /// <param name="scheme"></param>
        /// <param name="host"></param>
        /// <param name="port"></param>
        /// <param name="segments"></param>
        /// <example>
        /// <code lang="csharp">
        ///     var url = new Url("api.example.com", 80, "api", "v1");
        /// </code>
        /// </example>
        public Url(string scheme, string host, int port, params string[] segments)
            : this()
        {

            Scheme = scheme;
            Host = host;
            Port = port;

            WithPathSegment(segments);

        }

        /// <summary>
        /// Constructs a Url object from a string.
        /// </summary>
        /// <param name="baseUrl">The URL to use as a starting point.</param>
        /// <example>
        /// <code lang="csharp">
        ///     var url = new Url("https://api.example.com:80");
        /// </code>
        /// </example>
        public Url(string baseUrl = null)
        {
            _originalString = baseUrl?.Trim();
        }

        /// <summary>
        /// Constructs a Url object from a string.
        /// </summary>
        /// <param name="baseUrl">The URL to use as a starting point.</param>
        /// <example>
        /// <code lang="csharp">
        ///     var url = new Url("https://api.example.com:80");
        /// </code>
        /// </example>
        public Url(string baseUrl, int? port = null)
        {
            _originalString = baseUrl?.Trim();
            if (port.HasValue)
                Port = port;
        }

        /// <summary>
        /// Constructs a Url object from a System.Uri.
        /// </summary>
        /// <param name="uri">The System.Uri (required)</param>
        /// <exception cref="ArgumentNullException"><paramref name="uri"/> is <see langword="null" />.</exception>
        /// <example>
        /// <code lang="csharp">
        ///     var url = new Url(new Uri("http://api.example.com:80"), "api", "v1");
        /// </code>
        /// </example>
        public Url(Uri uri, params string[] segments)
        {
            _originalString = (uri ?? throw new ArgumentNullException(nameof(uri))).OriginalString;
            ParseInternal(uri); // parse eagerly, taking advantage of the fact that we already have a parsed Uri
            WithPathSegment(segments);
        }

        /// <summary>
        /// Parses a URL string into a <see cref="Url"/> object.
        /// </summary>
        /// <param name="url">The URL string to parse. Must not be null or empty.</param>
        /// <returns>A new <see cref="Url"/> object representing the parsed URL.</returns>
        /// <remarks>
        /// This method creates a <see cref="Url"/> object from a string representation of a URL.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var url = Url.Parse("https://example.com/path?query=value#fragment");
        /// Console.WriteLine(url.Path); // Output: /path
        /// </code>
        /// </example>
        public static Url Parse(string url) => new Url(url).ParseInternal();

        private Url EnsureParsed() => _parsed ? this : ParseInternal();

        private Url ParseInternal(Uri uri = null)
        {
            _parsed = true;

            uri = uri ?? new Uri(_originalString ?? string.Empty, UriKind.RelativeOrAbsolute);

            if (uri.OriginalString.OrdinalStartsWith("//"))
            {
                ParseInternal(new Uri("http:" + uri.OriginalString));
                _scheme = string.Empty;
            }
            else if (uri.OriginalString.OrdinalStartsWith(Slash))
            {
                ParseInternal(new Uri("http://temp.com" + uri.OriginalString));
                _scheme = string.Empty;
                _host = string.Empty;
                _leadingSlash = true;
            }
            else if (uri.IsAbsoluteUri)
            {
                _scheme = uri.Scheme;
                _userInfo = uri.UserInfo;
                _host = uri.Host;
                _port = _originalString?.OrdinalStartsWith($"{Root}:{uri.Port}", ignoreCase: true) == true ? uri.Port : null;
                // don't default Port if not included explicitly
                _pathSegments = new List<Segment>();
                if (uri.AbsolutePath.Length > 0 && uri.AbsolutePath != Slash)
                    WithPathSegment(uri.AbsolutePath);
                _queryParams = new QueryParamCollection(uri.Query);
                _fragment = uri.Fragment.TrimStart('#'); // quirk - formal def of fragment does not include the #

                _leadingSlash = uri.OriginalString.OrdinalStartsWith(Root + Slash, ignoreCase: true);
                _trailingSlash = _pathSegments.Any() && uri.AbsolutePath.OrdinalEndsWith(Slash);
                _trailingQmark = uri.Query == "?";
                _trailingHash = uri.Fragment == "#";

                // more quirk fixes
                var hasAuthority = uri.OriginalString.OrdinalStartsWith($"{Scheme}://", ignoreCase: true);
                if (hasAuthority && Authority.Length == 0 && PathSegments.Any())
                {
                    // Uri didn't parse Authority when it should have
                    _host = _pathSegments[0].Value;
                    _pathSegments.RemoveAt(0);
                }
                else if (!hasAuthority && Authority.Length > 0)
                {
                    // Uri parsed Authority when it should not have
                    _pathSegments.Insert(0, new Segment(Authority));
                    _userInfo = string.Empty;
                    _host = string.Empty;
                    _port = null;
                }
            }
            // if it's relative, System.Uri refuses to parse any of it. these hacks will force the matter
            else
            {
                ParseInternal(new Uri("http://temp.com/" + uri.OriginalString));
                _scheme = string.Empty;
                _host = string.Empty;
                _leadingSlash = false;
            }

            return this;
        }

        /// <summary>
        /// Parses a URL query string into a <see cref="QueryParamCollection"/>.
        /// </summary>
        /// <param name="query">The query string to parse. Must not be null or empty.</param>
        /// <returns>A <see cref="QueryParamCollection"/> containing the parsed query parameters.</returns>
        /// <remarks>
        /// This method converts a query string into a collection of key-value pairs for easier manipulation.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var queryParams = Url.ParseQueryParam("key1=value1&key2=value2");
        /// Console.WriteLine(queryParams["key1"]); // Output: value1
        /// </code>
        /// </example>
        public static QueryParamCollection ParseQueryParam(string query) => new QueryParamCollection(query);

        /// <summary>
        /// Splits a path string into segments, encoding illegal characters, "?", and "#".
        /// </summary>
        /// <param name="path">The path string to split. Must not be null or empty.</param>
        /// <returns>An <see cref="IEnumerable{T}"/> of <see cref="Segment"/> objects representing the path segments.</returns>
        /// <remarks>
        /// This method processes a path string into individual segments, ensuring proper encoding of illegal characters.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var segments = Url.ParsePathSegment("/path/to/resource");
        /// foreach (var segment in segments)
        /// {
        ///     Console.WriteLine(segment.Value);
        /// }
        /// // Output:
        /// // path
        /// // to
        /// // resource
        /// </code>
        /// </example>
        public static IEnumerable<Segment> ParsePathSegment(string path)
        {
            var segments = EncodeIllegalCharacters(path)
                .Replace("?", "%3F")
                .Replace("#", "%23")
                .Split('/');

            if (!segments.Any())
                yield break;

            // skip first and/or last segment if either empty, but not any in between. "///" should return 2 empty segments for example. 
            var start = segments.First().Length > 0 ? 0 : 1;
            var count = segments.Length - (segments.Last().Length > 0 ? 0 : 1);

            for (var i = start; i < count; i++)
            {
                var s = segments[i];
                if (!string.IsNullOrEmpty(s) && s != ".")
                    yield return new Segment(segments[i]);
            }
        }

        #endregion


        #region fluent builder methods

        /// <summary>
        /// Maps variables in the URL path and query parameters to specified values.
        /// </summary>
        /// <param name="values">An array of key-value pairs representing the variables and their corresponding values. Must not be null.</param>
        /// <returns>The modified <see cref="Url"/> object with the variables replaced.</returns>
        /// <remarks>
        /// This method replaces variables in the URL path and query parameters with the provided values.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var url = new Url("https://example.com/{id}?name={name}");
        /// url.Map(("id", "123"), ("name", "John"));
        /// Console.WriteLine(url.ToString()); // Output: https://example.com/123?name=John
        /// </code>
        /// </example>
        public Url Map(params (string, string)[] values)
        {
            foreach (var item in values)
                Map(item.Item1, item.Item2);
            return this;
        }

        /// <summary>
        /// Maps a single variable in the URL path or query parameters to a specified value.
        /// </summary>
        /// <param name="name">The name of the variable to replace. Must not be null or empty.</param>
        /// <param name="value">The value to replace the variable with. Must not be null or empty.</param>
        /// <remarks>
        /// This method replaces a single variable in the URL path or query parameters with the provided value.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var url = new Url("https://example.com/{id}");
        /// url.Map("id", "123");
        /// Console.WriteLine(url.ToString()); // Output: https://example.com/123
        /// </code>
        /// </example>
        public void Map(string name, string value)
        {

            var p = PathSegments.ToArray();
            foreach (var item in p)
                if (item.IsVariable && item.Value == name)
                {
                    var o = _pathSegments.IndexOf(item);
                    _pathSegments[o] = new Segment(value);
                }

            var q = QueryParams;
            foreach (var item in q)
                if (item.Name == name && item.Value.IsVariable && item.Value.Match(name))
                    QueryParams.AddOrReplace(name, value, false, NullValueHandling.Ignore);

        }


        #region path segment

        /// <summary>
        /// Appends a segment to the URL path, ensuring there is one and only one '/' character as a separator.
        /// </summary>
        /// <param name="segment">The segment to append</param>
        /// <param name="fullyEncode">If true, URL-encodes reserved characters such as '/', '+', and '%'. Otherwise, only encodes strictly illegal characters (including '%' but only when not followed by 2 hex characters).</param>
        /// <returns>the Url object with the segment appended</returns>
        /// <exception cref="ArgumentNullException"><paramref name="segment"/> is <see langword="null" />.</exception>
        public Url WithPathSegment(object segment, bool fullyEncode = false)
        {
            if (segment == null)
                throw new ArgumentNullException(nameof(segment));

            EnsureParsed();

            if (fullyEncode)
            {
                var m = Uri.EscapeDataString(segment.ToInvariantString());
                var s = new Segment(m);
                PathSegments.Add(s);
                _trailingSlash = false;
            }
            else
            {
                var subpath = segment.ToInvariantString();
                foreach (Segment s in ParsePathSegment(subpath))
                    PathSegments.Add(s);
                _trailingSlash = subpath.OrdinalEndsWith(Slash);
            }

            _leadingSlash |= !IsRelative;
            return this;
        }

        /// <summary>
        /// Appends multiple segments to the URL path, ensuring there is one and only one '/' character as a separator.
        /// </summary>
        /// <param name="segments">The segments to append</param>
        /// <returns>the Url object with the segments appended</returns>
        public Url WithPathSegment(params object[] segments)
        {
            foreach (var segment in segments)
                WithPathSegment(segment);

            return this;
        }

        /// <summary>
        /// Appends multiple segments to the URL path, ensuring there is one and only one '/' character as a separator.
        /// </summary>
        /// <param name="segments">The segments to append</param>
        /// <returns>the Url object with the segments appended</returns>
        public Url WithPathSegment(IEnumerable<object> segments)
        {
            foreach (var s in segments)
                WithPathSegment(s);

            return this;
        }

        /// <summary>
        /// Removes the last path segment from the URL.
        /// </summary>
        /// <returns>The Url object.</returns>
        public Url RemovePathSegment()
        {
            if (PathSegments.Any())
                PathSegments.RemoveAt(PathSegments.Count - 1);
            return this;
        }

        /// <summary>
        /// Removes the entire path component of the URL, including the leading slash.
        /// </summary>
        /// <returns>The Url object.</returns>
        public Url RemovePath()
        {
            PathSegments.Clear();
            _leadingSlash = _trailingSlash = false;
            return this;
        }

        /// <summary>
        /// Set the URL fragment fluently.
        /// </summary>
        /// <param name="fragment">The part of the URL after #</param>
        /// <returns>The Url object with the new fragment set</returns>
        public Url SetFragment(string fragment)
        {
            Fragment = fragment ?? string.Empty;
            return this;
        }

        /// <summary>
        /// Removes the URL fragment including the #.
        /// </summary>
        /// <returns>The Url object with the fragment removed</returns>
        public Url RemoveFragment() => SetFragment(string.Empty);

        #endregion path segment

        #region query params

        /// <summary>
        /// Adds a parameter to the query, overwriting the value if name exists.
        /// </summary>
        /// <param name="name">Name of query parameter</param>
        /// <param name="value">Value of query parameter</param>
        /// <param name="nullValueHandling">Indicates how to handle null values. Defaults to Remove (any existing)</param>
        /// <returns>The Url object with the query parameter added</returns>
        public Url WithQueryParam(string name, object value, NullValueHandling nullValueHandling = NullValueHandling.Remove)
        {
            QueryParams.AddOrReplace(name, value, false, nullValueHandling);
            return this;
        }

        /// <summary>
        /// Adds a parameter to the query, overwriting the value if name exists.
        /// </summary>
        /// <param name="name">Name of query parameter</param>
        /// <param name="value">Value of query parameter</param>
        /// <param name="isEncoded">Set to true to indicate the value is already URL-encoded</param>
        /// <param name="nullValueHandling">Indicates how to handle null values. Defaults to Remove (any existing)</param>
        /// <returns>The Url object with the query parameter added</returns>
        /// <exception cref="ArgumentNullException"><paramref name="name"/> is <see langword="null" />.</exception>
        public Url WithQueryParam(string name, string value, bool isEncoded = false, NullValueHandling nullValueHandling = NullValueHandling.Remove)
        {
            QueryParams.AddOrReplace(name, value, isEncoded, nullValueHandling);
            return this;
        }

        /// <summary>
        /// Adds a parameter without a value to the query, removing any existing value.
        /// </summary>
        /// <param name="name">Name of query parameter</param>
        /// <returns>The Url object with the query parameter added</returns>
        public Url WithQueryParam(string name)
        {
            QueryParams.AddOrReplace(name, null, false, NullValueHandling.NameOnly);
            return this;
        }

        /// <summary>
        /// Parses values (usually an anonymous object or dictionary) into name/value pairs and adds them to the query, overwriting any that already exist.
        /// </summary>
        /// <param name="values">Typically an anonymous object, ie: new { x = 1, y = 2 }</param>
        /// <param name="nullValueHandling">Indicates how to handle null values. Defaults to Remove (any existing)</param>
        /// <returns>The Url object with the query parameters added</returns>
        public Url WithQueryParam(object values, NullValueHandling nullValueHandling = NullValueHandling.Remove)
        {
            if (values == null)
                return this;

            if (values is string s)
                return WithQueryParam(s);

            foreach (var kv in values.ToKeyValuePairs())
                WithQueryParam(kv.Key, kv.Value, nullValueHandling);

            return this;
        }

        /// <summary>
        /// Adds multiple parameters without values to the query.
        /// </summary>
        /// <param name="names">Names of query parameters.</param>
        /// <returns>The Url object with the query parameter added</returns>
        public Url WithQueryParam(IEnumerable<string> names)
        {
            if (names == null)
                return this;

            foreach (var name in names.Where(n => !string.IsNullOrEmpty(n)))
                WithQueryParam(name);

            return this;
        }

        /// <summary>
        /// Adds multiple parameters without values to the query.
        /// </summary>
        /// <param name="names">Names of query parameters</param>
        /// <returns>The Url object with the query parameter added.</returns>
        public Url WithQueryParam(params string[] names) => WithQueryParam(names as IEnumerable<string>);

        /// <summary>
        /// Removes a name/value pair from the query by name.
        /// </summary>
        /// <param name="name">Query string parameter name to remove</param>
        /// <returns>The Url object with the query parameter removed</returns>
        public Url RemoveQueryParam(string name)
        {
            QueryParams.Remove(name);
            return this;
        }

        /// <summary>
        /// Removes multiple name/value pairs from the query by name.
        /// </summary>
        /// <param name="names">Query string parameter names to remove</param>
        /// <returns>The Url object.</returns>
        public Url RemoveQueryParam(params string[] names)
        {
            foreach (var name in names)
                QueryParams.Remove(name);
            return this;
        }

        /// <summary>
        /// Removes multiple name/value pairs from the query by name.
        /// </summary>
        /// <param name="names">Query string parameter names to remove</param>
        /// <returns>The Url object with the query parameters removed</returns>
        public Url RemoveQueryParam(IEnumerable<string> names)
        {
            foreach (var name in names)
                QueryParams.Remove(name);
            return this;
        }

        /// <summary>
        /// Removes the entire query component of the URL.
        /// </summary>
        /// <returns>The Url object.</returns>
        public Url RemoveQuery()
        {
            QueryParams.Clear();
            return this;
        }

        #endregion query params

        /// <summary>
        /// Resets the URL to its root, including the scheme, any user info, host, and port (if specified).
        /// </summary>
        /// <returns>The Url object trimmed to its root.</returns>
        public Url ResetToRoot()
        {
            PathSegments.Clear();
            QueryParams.Clear();
            Fragment = string.Empty;
            _leadingSlash = false;
            _trailingSlash = false;
            return this;
        }

        /// <summary>
        /// Resets the URL to its original state as set in the constructor.
        /// </summary>
        public Url Reset()
        {
            if (_parsed)
            {
                _scheme = null;
                _userInfo = null;
                _host = null;
                _port = null;
                _pathSegments = null;
                _queryParams = null;
                _fragment = null;
                _leadingSlash = false;
                _trailingSlash = false;
                _parsed = false;
            }
            return this;
        }

        /// <summary>
        /// Creates a copy of this Url.
        /// </summary>
        public Url Clone() => new Url(ToString());
        #endregion

        #region conversion, equality, etc.

        /// <summary>
        /// Converts this Url object to its string representation.
        /// </summary>
        /// <param name="encodeSpaceAsPlus">Indicates whether to encode spaces with the "+" character instead of "%20"</param>
        /// <returns></returns>
        public string ToString(bool encodeSpaceAsPlus)
        {

            //if (!_parsed)
            //    return _originalString ?? string.Empty;

            var p = Path;


            new UriBuilder
            {
                Scheme = Scheme,
                Host = Host,
                Port = Port ?? -1,
                Path = p,
                Query = Query,
                Fragment = Fragment
            }

            return string.Concat
            (
                Root,
                encodeSpaceAsPlus ? p.Replace("%20", "+") : p,
                _trailingQmark || QueryParams.Any() ? "?" : string.Empty,
                QueryParams.ToString(encodeSpaceAsPlus),
                _trailingHash || Fragment?.Length > 0 ? "#" : string.Empty,
                Fragment
            ).Trim();

        }

        /// <summary>
        /// Converts this Url object to its string representation.
        /// </summary>
        /// <returns></returns>
        public override string ToString() => ToString(false);

        /// <summary>
        /// Converts this Url object to System.Uri
        /// </summary>
        /// <returns>The System.Uri object</returns>
        public Uri ToUri() => new Uri(ToString(), UriKind.RelativeOrAbsolute);

        /// <summary>
        /// Implicit conversion from Url to System.Uri.
        /// </summary>
        /// <param name="url"></param>
        public static implicit operator Uri(Url url) => url.ToUri();

        /// <summary>
        /// Implicit conversion from System.Uri to Url.
        /// </summary>
        /// <returns>The string</returns>
        public static implicit operator Url(Uri uri) => new Url(uri.ToString());

        /// <summary>
        /// Implicit conversion from Url to String.
        /// </summary>
        /// <param name="url">The Url object</param>
        /// <returns>The string</returns>
        public static implicit operator string(Url url) => url?.ToString();

        /// <summary>
        /// Implicit conversion from String to Url.
        /// </summary>
        /// <param name="url">The String representation of the URL</param>
        /// <returns>The string</returns>
        public static implicit operator Url(string url) => new Url(url);

        /// <summary>
        /// True if obj is an instance of Url and its string representation is equal to this instance's string representation.
        /// </summary>
        /// <param name="obj">The object to compare to this instance.</param>
        /// <returns></returns>
        public override bool Equals(object obj) => obj is Url url && ToString().OrdinalEquals(url.ToString());

        /// <summary>
        /// Returns the hash code for this Url.
        /// </summary>
        public override int GetHashCode() => ToString().GetHashCode();
        #endregion

        #region static utility methods        

        /// <summary>
        /// Basically a Path.Combine for URLs. Ensures exactly one '/' separates each segment,
        /// and exactly on '&amp;' separates each query parameter.
        /// URL-encodes illegal characters but not reserved characters.
        /// </summary>
        /// <param name="parts">URL parts to combine.</param>
        public static string Combine(params string[] parts)
        {
            if (parts == null)
                throw new ArgumentNullException(nameof(parts));

            string result = string.Empty;
            bool inQuery = false, inFragment = false;

            string CombineEnsureSingleSeparator(string a, string b, char separator)
            {
                if (string.IsNullOrEmpty(a)) return b;
                if (string.IsNullOrEmpty(b)) return a;
                return a.TrimEnd(separator) + separator + b.TrimStart(separator);
            }

            foreach (var part in parts)
            {
                if (string.IsNullOrEmpty(part))
                    continue;

                if (result.OrdinalEndsWith("?") || part.OrdinalStartsWith("?"))
                    result = CombineEnsureSingleSeparator(result, part, '?');
                else if (result.OrdinalEndsWith("#") || part.OrdinalStartsWith("#"))
                    result = CombineEnsureSingleSeparator(result, part, '#');
                else if (inFragment)
                    result += part;
                else if (inQuery)
                    result = CombineEnsureSingleSeparator(result, part, '&');
                else
                    result = CombineEnsureSingleSeparator(result, part, '/');

                if (part.OrdinalContains("#"))
                {
                    inQuery = false;
                    inFragment = true;
                }
                else if (!inFragment && part.OrdinalContains("?"))
                {
                    inQuery = true;
                }
            }
            return EncodeIllegalCharacters(result);
        }

        /// <summary>
        /// Decodes a URL-encoded string.
        /// </summary>
        /// <param name="s">The URL-encoded string to decode. Must not be null.</param>
        /// <param name="interpretPlusAsSpace">If true, "+" characters will be interpreted as spaces.</param>
        /// <returns>A <see cref="string"/> representing the decoded URL.</returns>
        /// <remarks>
        /// This method decodes a URL-encoded string, converting encoded characters back to their original form.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var decoded = Url.Decode("key%3Dvalue%26key2%3Dvalue2", false);
        /// Console.WriteLine(decoded); // Output: key=value&key2=value2
        /// </code>
        /// </example>
        public static string Decode(string s, bool interpretPlusAsSpace)
        {
            if (string.IsNullOrEmpty(s))
                return s;

            return Uri.UnescapeDataString(interpretPlusAsSpace ? s.Replace("+", " ") : s);
        }

        private const int MAX_URL_LENGTH = 65519;

        /// <summary>
        /// URL-encodes a string, including reserved characters such as '/' and '?'.
        /// </summary>
        /// <param name="str">The string to encode. Must not be null.</param>
        /// <param name="encodeSpaceAsPlus">If true, spaces will be encoded as + signs. Otherwise, they'll be encoded as %20.</param>
        /// <returns>The encoded URL.</returns>
        /// <remarks>
        /// This method ensures that the string is properly encoded for use in a URL, including handling long strings by splitting them into smaller parts.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var encoded = Url.Encode("key=value&key2=value2");
        /// Console.WriteLine(encoded); // Output: key%3Dvalue%26key2%3Dvalue2
        /// </code>
        /// </example>
        public static string Encode(string str, bool encodeSpaceAsPlus = false)
        {

            if (string.IsNullOrEmpty(str))
                return str;

            if (str.Length > MAX_URL_LENGTH)
            {
                // Uri.EscapeDataString is going to throw because the string is "too long", so break it into pieces and concat them
                var parts = new string[(int)Math.Ceiling((double)str.Length / MAX_URL_LENGTH)];
                for (var i = 0; i < parts.Length; i++)
                {
                    var start = i * MAX_URL_LENGTH;
                    var len = Math.Min(MAX_URL_LENGTH, str.Length - start);
                    parts[i] = Uri.EscapeDataString(str.Substring(start, len));
                }
                str = string.Concat(parts);
            }
            else
            {
                str = Uri.EscapeDataString(str);
            }

            return encodeSpaceAsPlus ? str.Replace("%20", "+") : str;

        }

        /// <summary>
        /// URL-encodes characters in a string that are neither reserved nor unreserved. Avoids encoding reserved characters such as '/' and '?'. Avoids encoding '%' if it begins a %-hex-hex sequence (i.e. avoids double-encoding).
        /// </summary>
        /// <param name="s">The string to encode.</param>
        /// <param name="encodeSpaceAsPlus">If true, spaces will be encoded as + signs. Otherwise, they'll be encoded as %20.</param>
        /// <returns>The encoded URL.</returns>
        public static string EncodeIllegalCharacters(string s, bool encodeSpaceAsPlus = false)
        {
            if (string.IsNullOrEmpty(s))
                return s;

            if (encodeSpaceAsPlus)
                s = s.Replace(" ", "+");

            // Uri.EscapeUriString mostly does what we want - encodes illegal characters only - but it has a quirk
            // in that % isn't illegal if it's the start of a %- encoded sequence https://stackoverflow.com/a/47636037/62600

            // no % characters, so avoid the regex overhead
            if (!s.OrdinalContains("%"))
                return Uri.EscapeDataString(s);

            // pick out all %-hex-hex matches and avoid double-encoding
            return Regex.Replace(s, "(.*?)((%[0-9A-Fa-f]{2})|$)", c =>
            {
                var a = c.Groups[1].Value; // group 1 is a sequence with no %- encoding - encode illegal characters
                var b = c.Groups[2].Value; // group 2 is a valid 3-character %- encoded sequence - leave it alone!
                return Uri.EscapeDataString(a) + b;
            });
        }

        /// <summary>
        /// Checks if a string is a well-formed absolute URL.
        /// </summary>
        /// <param name="url">The string to check</param>
        /// <returns>true if the string is a well-formed absolute URL</returns>
        public static bool IsValid(string url) => url != null && Uri.IsWellFormedUriString(url, UriKind.Absolute);

        private static string Encode(string datas)
        {

            if (string.IsNullOrEmpty(datas))
                return datas;

            return Uri.EscapeDataString(datas);
        }

        #endregion



        public static string Slash = "/";

        private static readonly HashSet<string> AllowedSchemes = new HashSet<string>(StringComparer.OrdinalIgnoreCase) { "http", "https" };
        private string _originalString;
        private bool _parsed;
        private string _scheme;
        private string _userInfo;
        private string _host;
        private List<Segment> _pathSegments;
        private QueryParamCollection _queryParams;
        private string _fragment;
        private int? _port;
        private bool _leadingSlash;
        private bool _trailingSlash;
        private bool _trailingQmark;
        private bool _trailingHash;

    }

}