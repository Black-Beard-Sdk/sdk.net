using System.Collections;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Web;
using System.Collections.Specialized;


namespace Bb.Urls
{

    /// <summary>
    /// CommonExtensions for objects.
    /// </summary>
    public static class CommonExtensions
    {
        /// <summary>
        /// Returns a key-value-pairs representation of the object.
        /// For strings, URL query string format assumed and pairs are parsed from that.
        /// For objects that already implement IEnumerable&lt;KeyValuePair&gt;, the object itself is simply returned.
        /// For all other objects, all publicly readable properties are extracted and returned as pairs.
        /// </summary>
        /// <param name="obj">The object to parse into key-value pairs</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"><paramref name="obj"/> is <see langword="null" />.</exception>
        public static IEnumerable<(string Name, object? Value)> ToKeyValuePairs(this object obj)
        {
            if (obj == null)
                return [];

            if (obj is string s)
                return StringToKV(s);

            if (obj is IEnumerable e)
                return CollectionToKV(e);

            var result = ObjectToKV(obj);
            if (result == null)
                return [];

            return result;

        }

        /// <summary>
        /// Returns a string that represents the current object, using CultureInfo.InvariantCulture where possible.
        /// Dates are represented in IS0 8601.
        /// </summary>
        public static string ToInvariantString(this object obj)
        {

            if (obj == null)
                return string.Empty;

            if (obj is DateTime dt)
                return dt.ToString("o", CultureInfo.InvariantCulture);

            if (obj is DateTimeOffset dto)
                return dto.ToString("o", CultureInfo.InvariantCulture);

            if (obj is IConvertible c)
                return c.ToString(CultureInfo.InvariantCulture);

            if (obj is IFormattable f)
                return f.ToString(null, CultureInfo.InvariantCulture);

            var result = obj.ToString();

            if (result == null)
                result = string.Empty;

            return result;

        }

        internal static bool OrdinalEquals(this string s, string value, bool ignoreCase = false) =>
            s != null && s.Equals(value, ignoreCase ? StringComparison.OrdinalIgnoreCase : StringComparison.Ordinal);

        internal static bool OrdinalContains(this string s, string value, bool ignoreCase = false) =>
            s != null && s.IndexOf(value, ignoreCase ? StringComparison.OrdinalIgnoreCase : StringComparison.Ordinal) >= 0;

        internal static bool OrdinalStartsWith(this string s, string value, bool ignoreCase = false) =>
            s != null && s.StartsWith(value, ignoreCase ? StringComparison.OrdinalIgnoreCase : StringComparison.Ordinal);

        internal static bool OrdinalEndsWith(this string s, string value, bool ignoreCase = false) =>
            s != null && s.EndsWith(value, ignoreCase ? StringComparison.OrdinalIgnoreCase : StringComparison.Ordinal);

        /// <summary>
        /// Splits at the first occurrence of the given separator.
        /// </summary>
        /// <param name="s">The string to split.</param>
        /// <param name="separator">The separator to split on.</param>
        /// <returns>Array of at most 2 strings. (1 if separator is not found.)</returns>
        public static string[] SplitOnFirstOccurrence(this string s, string separator)
        {
            // Needed because full PCL profile doesn't support Split(char[], int) (#119)
            if (string.IsNullOrEmpty(s))
                return [s];

            var i = s.IndexOf(separator);
            return i == -1 ?
                [s] :
                [s.Substring(0, i), s.Substring(i + separator.Length)];
        }

        private static IEnumerable<(string Key, object? Value)> StringToKV(string queryString)
        {

            if (string.IsNullOrEmpty(queryString))
                return [];

            var list = new List<(string Key, object Value)>();
            NameValueCollection queryParams = HttpUtility.ParseQueryString(queryString);
            foreach (string key in queryParams)
                list.Add(new(key, queryParams[key] ?? string.Empty));

            return (IEnumerable<(string Key, object? Value)>)list; // Don't remove the cast.

        }

        private static IEnumerable<(string Name, object? Value)> ObjectToKV(object obj) =>
            from prop in obj.GetType().GetProperties()
            let getter = prop.GetGetMethod(false)
            where getter != null
            let val = getter.Invoke(obj, null)
            select (prop.Name, GetDeclaredTypeValue(val, prop.PropertyType));

        internal static object? GetDeclaredTypeValue(object value, Type declaredType)
        {

            if (value == null || value.GetType() == declaredType)
                return value;

            // related: https://stackoverflow.com/q/3531318/62600
            declaredType = Nullable.GetUnderlyingType(declaredType) ?? declaredType;

            // thx @j2jensen!
            if (value is IEnumerable col
                && declaredType.IsGenericType
                && declaredType.GetGenericTypeDefinition() == typeof(IEnumerable<>)
                && !col.GetType().GetInterfaces().Contains(declaredType)
                && declaredType.IsInstanceOfType(col))
            {
                var elementType = declaredType.GetGenericArguments()[0];
                return col.Cast<object>().Select(element => Convert.ChangeType(element, elementType));
            }

            return value;
        }

        private static IEnumerable<(string Key, object? Value)> CollectionToKV(IEnumerable col)
        {

            bool TryGetProp(object obj, string name, out object? value)
            {
                var prop = obj.GetType().GetProperty(name);
                var field = obj.GetType().GetField(name);

                if (prop != null)
                {
                    value = prop.GetValue(obj, null);
                    return true;
                }
                if (field != null)
                {
                    value = field.GetValue(obj);
                    return true;
                }
                value = null;
                return false;
            }

            bool IsTuple2(object item, out object? name, out object? val)
            {
                name = null;
                val = null;
                return
                    item.GetType().Name.OrdinalContains("Tuple") &&
                    TryGetProp(item, "Item1", out name) &&
                    TryGetProp(item, "Item2", out val) &&
                    !TryGetProp(item, "Item3", out _);
            }

            bool LooksLikeKV(object item, out object? name, out object? val)
            {
                name = null;
                val = null;
                return
                    (TryGetProp(item, "Key", out name) || TryGetProp(item, "key", out name) || TryGetProp(item, "Name", out name) || TryGetProp(item, "name", out name)) &&
                    (TryGetProp(item, "Value", out val) || TryGetProp(item, "value", out val));
            }

            foreach (var item in col)
            {
                if (item == null)
                    continue;
                if (!IsTuple2(item, out var name, out var val) && !LooksLikeKV(item, out name, out val))
                    yield return (item.ToInvariantString() ?? string.Empty, null);
                else if (name != null)
                    yield return (name.ToInvariantString() ?? string.Empty, val);
            }
        }

        /// <summary>
        /// Merges the key/value pairs from d2 into d1, without overwriting those already set in d1.
        /// </summary>
        public static void Merge<TKey, TValue>(this IDictionary<TKey, TValue> d1, IDictionary<TKey, TValue> d2)
        {
            foreach (var kv in d2.Where(x => !d1.ContainsKey(x.Key)).ToList())
            {
                d1[kv.Key] = kv.Value;
            }
        }

        /// <summary>
        /// Strips any single quotes or double quotes from the beginning and end of a string.
        /// </summary>
        public static string StripQuotes(this string s) => Regex.Replace(s, "^\\s*['\"]+|['\"]+\\s*$", string.Empty);

        /// <summary>
        /// True if the given string is a valid IPv4 address.
        /// </summary>
        public static bool IsIP(this string s)
        {
            // based on https://stackoverflow.com/a/29942932/62600
            if (string.IsNullOrEmpty(s))
                return false;

            var parts = s.Split('.');
            return parts.Length == 4 && parts.All(x => byte.TryParse(x, out _));
        }
    }
}