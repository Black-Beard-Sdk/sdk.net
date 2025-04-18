using System.Collections;

namespace Bb.Urls
{


    /// <summary>
    /// Represents a URL query as a collection of name/value pairs. Insertion order is preserved.
    /// </summary>
    public class QueryParamCollection : IReadOnlyNameValueList<QueryParamValue>
    {

        /// <summary>
        /// Returns a new instance of QueryParamCollection
        /// </summary>
        /// <param name="query">Optional query string to parse.</param>
        public QueryParamCollection(string query = null)
        {
            if (query == null)
                return;

            _values.AddRange(
                from kv in query.TrimStart('?').ToKeyValuePairs()
                select (kv.Key, new QueryParamValue(kv.Value)));

        }

        /// <summary>
        /// Returns serialized, encoded query string. Insertion order is preserved.
        /// </summary>
        /// <returns></returns>
        public override string ToString() => ToString(false);

        /// <summary>
        /// Returns serialized, encoded query string. Insertion order is preserved.
        /// </summary>
        /// <returns></returns>
        public string ToString(bool encodeSpaceAsPlus) => string.Join("&",
            from p in _values
            let name = Url.EncodeIllegalCharacters(p.Name, encodeSpaceAsPlus)
            let value = p.Value.EncodedValue(encodeSpaceAsPlus)
            select value == null ? name : $"{name}={value}");

        /// <summary>
        /// Appends a query parameter. If value is a collection type (array, IEnumerable, etc.), multiple parameters are added, i.e. x=1&amp;x=2.
        /// To overwrite existing parameters of the same name, use AddOrReplace instead.
        /// </summary>
        /// <param name="name">Name of the parameter.</param>
        /// <param name="value">Value of the parameter. If it's a collection, multiple parameters of the same name are added.</param>
        /// <param name="nullValueHandling">Describes how to handle null values.</param>
        public void Add(string name, object value, NullValueHandling nullValueHandling = NullValueHandling.Remove)
        {

            if (value == null && nullValueHandling == NullValueHandling.Remove)
            {
                _values.Remove(name);
                return;
            }

            foreach (var val in SplitCollection(value).ToList())
            {

                if (val == null && nullValueHandling != NullValueHandling.NameOnly)
                    continue;
                
                _values.Add(name, new QueryParamValue(val));

            }

        }

        /// <summary>
        /// Replaces existing query parameter(s) or appends to the end. If value is a collection type (array, IEnumerable, etc.),
        /// multiple parameters are added, i.e. x=1&amp;x=2. If any of the same name already exist, they are overwritten one by one
        /// (preserving order) and any remaining are appended to the end. If fewer values are specified than already exist,
        /// remaining existing values are removed.
        /// </summary>
        /// <param name="name">Name of the parameter.</param>
        /// <param name="value">Value of the parameter. If it's a collection, multiple parameters of the same name are added/replaced.</param>
        /// <param name="isEncoded">If true, assume value(s) already URL-encoded.</param>
        /// <param name="nullValueHandling">Describes how to handle null values.</param>
        public void AddOrReplace(string name, object value, NullValueHandling nullValueHandling = NullValueHandling.Remove)
        {

            if (!Contains(name))
                Add(name, value, nullValueHandling);

            // This covers some complex edge cases involving multiple values of the same name.
            // example: x has values at positions 2 and 4 in the query string, then we set x to
            // an array of 4 values. We want to replace the values at positions 2 and 4 with the
            // first 2 values of the new array, then append the remaining 2 values to the end.
            var values = new Queue<object>(SplitCollection(value));

            var old = _values.ToArray();
            _values.Clear();

            foreach (var item in old)
            {
                if (item.Name != name)
                {
                    _values.Add(item);
                    continue;
                }

                if (values.Count == 0)
                    continue; // remove, effectively

                var val = values.Dequeue();
                if (val == null && nullValueHandling == NullValueHandling.Ignore)
                    _values.Add(item);

                else if (val == null && nullValueHandling == NullValueHandling.Remove)
                    continue;

                else
                    Add(name, val, nullValueHandling);
            }

            // add the rest to the end
            while (values.Count > 0)
                Add(name, values.Dequeue(), nullValueHandling);

        }

        private IEnumerable<object> SplitCollection(object value)
        {
            
            if (value == null)
                yield return null;

            else if (value is string s)
                yield return s;

            else if (value is IEnumerable en)
            {
                foreach (var item in en.Cast<object>().SelectMany(SplitCollection).ToList())
                    yield return item;
            }
            else
                yield return value;

        }

        /// <summary>
        /// Removes all query parameters of the given name.
        /// </summary>
        public void Remove(string name) => _values.Remove(name);

        /// <summary>
        /// Clears all query parameters from this collection.
        /// </summary>
        public void Clear() => _values.Clear();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        /// <inheritdoc />>
        public IEnumerator<(string Name, QueryParamValue Value)> GetEnumerator() =>
            _values.Select(qp => (qp.Name, Original: qp.Value)).GetEnumerator();

        /// <inheritdoc />>
        public int Count => _values.Count;

        /// <inheritdoc />>
        public (string Name, QueryParamValue Value) this[int index] => (_values[index].Name, _values[index].Value);

        /// <inheritdoc />>
        public QueryParamValue FirstOrDefault(string name) => _values.FirstOrDefault(name);

        /// <inheritdoc />>
        public bool TryGetFirst(string name, out QueryParamValue value)
        {
            var result = _values.TryGetFirst(name, out value);
            return result;
        }

        /// <inheritdoc />>
        public IEnumerable<QueryParamValue> GetAll(string name) => _values.GetAll(name);

        /// <inheritdoc />>
        public bool Contains(string name) => _values.Contains(name);

        /// <inheritdoc />>
        public bool Contains(string name, QueryParamValue value) => _values.Any(qv => qv.Name == name && qv.Value.Equals(value));


        /// <summary>
        /// implicit conversion from QueryParamCollection to string
        /// </summary>
        /// <param name="query"></param>
        public static implicit operator string(QueryParamCollection query) => query.ToString();

        private readonly NameValueList<QueryParamValue> _values = new NameValueList<QueryParamValue>(true);
    }

}