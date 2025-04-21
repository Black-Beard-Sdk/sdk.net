namespace Bb.Curls
{
    /// <summary>
    /// Represents a collection of HTTP headers.
    /// </summary>
    public class Headers
    {

        /// <summary>
        /// try to resolve header by name of the name
        /// </summary>
        /// <param name="header">header name</param>
        /// <param name="result"></param>
        /// <returns></returns>
        public bool TryGetFirst(string header, out string? result)
        {

            result = null;

            if (_headers.TryGetValue(header, out var result1))
                result = result1.FirstOrDefault();

            return result != null;

        }

        /// <summary>
        /// evaluate if the header is present in the collection
        /// </summary>
        /// <param name="header">header name</param>
        /// <returns></returns>
        public bool Contains(string header)
        {
            return _headers.ContainsKey(header);
        }

        /// <summary>
        /// Add or replace a header in the collection.
        /// </summary>
        /// <param name="header">header name</param>
        /// <param name="value">header value</param>
        public void AddOrReplace(string header, string value)
        {

            if (!_headers.TryGetValue(header, out var result))
                _headers.Add(header, new HashSet<string>() { value });

            else
            {
                result.Clear();
                result.Add(value);
            }

        }

        /// <summary>
        /// Add the header in the collection.
        /// </summary>
        /// <param name="header">header name</param>
        /// <param name="value">header value</param>
        public void Add(string header, string value)
        {

            if (!_headers.TryGetValue(header, out var result))
                _headers.Add(header, new HashSet<string>() { value });

            else
                result.Add(value);

        }

        private readonly Dictionary<string, HashSet<string>> _headers = new Dictionary<string, HashSet<string>>();

    }

}
