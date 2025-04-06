using System.Text.RegularExpressions;
using System.Xml.Schema;

namespace Bb.Urls
{
    public class Url
    {


        #region ctors


        public Url()
        {
            this._builder = new UriBuilder()
            {
                Scheme = DEFAULT_SCHEME,
                Host = DEFAULT_HOST,
                Port = DEFAULT_PORT,
                Path = string.Empty,
                UserName = string.Empty,
                Password = string.Empty,
                Query = string.Empty,
                Fragment = string.Empty,
            };
        }

        public Url(UriBuilder builder, Uri uri = null)
        {
            this._builder = builder;
            if (uri == null)
                uri = builder.Uri;
            PathSegments = ParsePathSegment(uri.Segments);
            this.Query = uri.Query;
        }

        public Url(Uri uri) :
            this(new UriBuilder(uri), uri)
        {

        }

        public Url(string url)
          : this(new Uri(url))
        {

        }

        public Url(Uri uri, string[] paths)
            : this(uri)
        {
            PathSegments = ParsePathSegment(paths);
        }

        public Url(string scheme, string host, int? port, string? userInfo, params string[] paths)
            : this()
        {
            this._builder.Scheme = scheme ?? throw new ArgumentNullException(nameof(scheme));
            this._builder.Host = host ?? throw new ArgumentNullException(nameof(host));

            if (port.HasValue)
            {
                this._builder.Port = port.Value;
            }
            else if (this._builder.Scheme == DEFAULT_SECURED_SCHEME)
                this._builder.Port = 443;


            if (!string.IsNullOrEmpty(userInfo))
            {

                if (userInfo.Contains(":"))
                {
                    var i = userInfo.Split(':');

                    this._builder.UserName = i[0];
                    this._builder.Password = i[1];
                }
                else
                    this._builder.UserName = userInfo;
            }

            if (paths != null && paths.Length > 0)
                PathSegments = ParsePathSegment(paths);

        }

        public Url(string scheme, string host, int? port)
            : this(scheme, host, port, null)
        {

        }

        public Url(string scheme, string host)
            : this(scheme, host, null)
        {

        }

        public Url(string host, int port)
            : this(Url.DEFAULT_SCHEME, host, port, null)
        {

        }

        #endregion ctors


        public string Scheme { get => this._builder.Scheme; set => this._builder.Scheme = value; }

        public string Host { get => this._builder.Host; set => this._builder.Host = value; }

        public int Port { get => this._builder.Port; set => this._builder.Port = value; }

        public string UserName
        {
            get => this._builder.UserName;
            set
            {
                if (!string.IsNullOrEmpty(value))
                    this._builder.UserName = Url.EncodeIllegalCharacters(value);

                else
                    this._builder.UserName = string.Empty;
            }
        }

        public string Password
        {
            get => this._builder.Password;
            set
            {
                if (!string.IsNullOrEmpty(value))
                    this._builder.Password = Url.EncodeIllegalCharacters(value);

                else
                    this._builder.Password = string.Empty;
            }
        }

        public string Fragment
        {
            get => this._builder.Fragment;
            set
            {
                if (!string.IsNullOrEmpty(value))
                    this._builder.Fragment = Url.EncodeIllegalCharacters(value);

                else
                    this._builder.Fragment = string.Empty;
            }
        }

        public string Path
        {
            get => ConcatenatePath(this._pathSegments);
            set
            {
                _pathSegments = ParsePathSegment(value);
            }
        }

        public IEnumerable<Segment> PathSegments
        {
            get => _pathSegments;
            set
            {
                _pathSegments = value.ToList();
            }
        }

        public string Query
        {
            get => this._query.ToString();
            set
            {
                this._query = new QueryParamCollection(value);
            }
        }

        public QueryParamCollection QueryParams
        {
            get
            {
                return this._query ?? (this._query = new QueryParamCollection());
            }
            set
            {
                this._query = value;
            }
        }

        public Uri BaseAddress
        {
            get
            {
                return new UriBuilder
                {
                    Scheme = _builder.Scheme,
                    Host = _builder.Host,
                    Port = _builder.Port
                }.Uri;
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
                    Scheme = _builder.Scheme,
                    Host = _builder.Host,
                    Port = _builder.Port
                }.ToString();
            }
        }

        public Uri ToUri()
        {
            if (_pathSegments != null && _pathSegments.Count > 0)
                _builder.Path = ConcatenatePath(_pathSegments);
            else
                _builder.Path = string.Empty;
            return _builder.Uri;
        }


        #region Path

        /// <summary>
        /// Removes the last path segment from the URL.
        /// </summary>
        /// <returns>The Url object.</returns>
        public Url RemoveLastPathSegment()
        {
            if (_pathSegments.Any())
                _pathSegments.RemoveAt(_pathSegments.Count - 1);
            return this;
        }

        /// <summary>
        /// Removes the entire path component of the URL, including the leading slash.
        /// </summary>
        /// <returns>The Url object.</returns>
        public Url RemovePath()
        {
            _pathSegments.Clear();
            return this;
        }

        public static List<Segment> ParsePathSegment(params string[] paths)
        {

            List<Segment> _paths = new List<Segment>(paths.Length);

            foreach (var path in paths)
                if (!string.IsNullOrWhiteSpace(path) || !string.IsNullOrEmpty(path))
                {
                    var range = path.Split(new[] { '/' }, StringSplitOptions.RemoveEmptyEntries).Select(x =>
                    {
                        if (!x.Contains('%'))
                            x = Url.EncodeIllegalCharacters(x);
                        return new Segment(x);
                    });
                    _paths.AddRange(range);

                }

            return _paths;

        }

        public static string ConcatenatePath(IEnumerable<Segment> paths)
        {

            if (paths == null || paths.Any())
                return string.Empty;

            return string.Join("/", paths.Select(x => x.Value));
        
        }

        public Url CombinePath(params string[] paths)
        {
            if (_pathSegments == null)
                _pathSegments = new List<Segment>();
            _pathSegments.AddRange(ParsePathSegment(paths));
            return this;
        }

        #endregion Path




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

            // Uri.EscapeUriString mostly does what we want - encodes illegal characters only - but it has a quirk
            // in that % isn't illegal if it's the start of a %- encoded sequence https://stackoverflow.com/a/47636037/62600

            // no % characters, so avoid the regex overhead
            if (!s.OrdinalContains("%"))
            {
                var u = Uri.EscapeDataString(s);
                if (encodeSpaceAsPlus)
                    u = u.Replace("%20", "+");
                return u;
            }

            // pick out all %-hex-hex matches and avoid double-encoding
            return Regex.Replace(s, "(.*?)((%[0-9A-Fa-f]{2})|$)", c =>
            {
                var a = c.Groups[1].Value; // group 1 is a sequence with no %- encoding - encode illegal characters
                var b = c.Groups[2].Value; // group 2 is a valid 3-character %- encoded sequence - leave it alone!
                return Uri.EscapeDataString(a) + b;
            });
        }




        #region Fragment

        public Url WithPathSegment(params string[] pathSegments)
        {
            if (_pathSegments == null)
                _pathSegments = new List<Segment>();
            _pathSegments.AddRange(ParsePathSegment(pathSegments));
            return this;
        }

        public Url WithPathSegment(IEnumerable<string> pathSegments)
        {
            if (_pathSegments == null)
                _pathSegments = new List<Segment>();
            _pathSegments.AddRange(ParsePathSegment(pathSegments.ToArray()));
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

        #endregion Fragment


        #region QueryParams

        /// <summary>
        /// Adds a parameter to the query, overwriting the value if name exists.
        /// </summary>
        /// <param name="name">Name of query parameter</param>
        /// <param name="value">Value of query parameter</param>
        /// <param name="nullValueHandling">Indicates how to handle null values. Defaults to Remove (any existing)</param>
        /// <returns>The Url object with the query parameter added</returns>
        public Url WithQueryParam(string name, object value, NullValueHandling nullValueHandling = NullValueHandling.Remove)
        {
            QueryParams.AddOrReplace(name, value, nullValueHandling);
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
            QueryParams.AddOrReplace(name, value, nullValueHandling);
            return this;
        }

        /// <summary>
        /// Adds a parameter without a value to the query, removing any existing value.
        /// </summary>
        /// <param name="name">Name of query parameter</param>
        /// <returns>The Url object with the query parameter added</returns>
        public Url WithQueryParam(string name)
        {
            QueryParams.AddOrReplace(name, null, NullValueHandling.NameOnly);
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

        #endregion QueryParams






        public override string ToString()
        {
            if (_pathSegments != null && _pathSegments.Count > 0)
                _builder.Path = ConcatenatePath(_pathSegments);
            else
                _builder.Path = string.Empty;
            _builder.Query = QueryParams.ToString();
            return _builder.ToString();
        }



        public Url Clone()
        {
            return new Url(this.ToString());
        }

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
        public Url Map(string name, string value)
        {

            var p = PathSegments.ToArray();
            foreach (var item in p)
                if (item.IsVariable)
                    if (item.Value == name)
                        _pathSegments[_pathSegments.IndexOf(item)] = new Segment(value);

            var q = QueryParams.ToList();
            foreach (var item in q)
                if (item.Name == name && item.Value.IsVariable)
                    QueryParams.AddOrReplace(name, value, NullValueHandling.Ignore);

            return this;

        }

        /// <summary>
        /// Resets the URL to its root, including the scheme, any user info, host, and port (if specified).
        /// </summary>
        /// <returns>The Url object trimmed to its root.</returns>
        public Url ResetToRoot()
        {
            _pathSegments.Clear();
            QueryParams.Clear();
            Fragment = string.Empty;
            return this;
        }

        /// <summary>
        /// Resets the URL to its original state as set in the constructor.
        /// </summary>
        public Url Reset()
        {
            _builder.Port = 80;
            _builder.Scheme = string.Empty;
            _builder.UserName = string.Empty;
            _builder.Host = string.Empty;
            _builder.Path = string.Empty;
            _builder.Query = string.Empty;
            _builder.Fragment = string.Empty;
            _pathSegments.Clear();
            _query.Clear();
            return this;
        }



        #region implicit operators

        public static implicit operator Uri(Url url) => url.ToUri();

        public static implicit operator Url(Uri uri) => new Url(uri.ToString());

        public static implicit operator string(Url url) => url.ToString();

        public static implicit operator Url(string url) => new Url(url);

        #endregion


        public const string DEFAULT_SCHEME = "http";
        public const string DEFAULT_SECURED_SCHEME = "https";
        public const string DEFAULT_HOST = "localhost";
        public const int DEFAULT_PORT = 80;



        private const int MAX_URL_LENGTH = 65519;
        private readonly UriBuilder _builder;
        private List<Segment> _pathSegments;
        private QueryParamCollection _query;
    }
}
