namespace Bb.Urls
{
    /// <summary>
    /// Represents an ordered collection of Name/Value pairs where duplicate names are allowed but aren't typical.
    /// Useful for scenarios where a dictionary would work great if not for edge cases (e.g., headers, cookies).
    /// </summary>
    /// <typeparam name="TValue">The type of the value associated with each name.</typeparam>
    public class NameValueList<TValue> : List<(string Name, TValue Value)>, INameValueList<TValue>, IReadOnlyNameValueList<TValue>
    {

        /// <summary>
        /// Instantiates a new empty <see cref="NameValueList{TValue}"/>.
        /// </summary>
        /// <param name="caseSensitiveNames">Indicates whether name comparisons should be case-sensitive.</param>
        public NameValueList(bool caseSensitiveNames)
        {
            _caseSensitiveNames = caseSensitiveNames;
        }

        /// <summary>
        /// Instantiates a new <see cref="NameValueList{TValue}"/> with the provided Name/Value pairs.
        /// </summary>
        /// <param name="items">The initial collection of Name/Value pairs.</param>
        /// <param name="caseSensitiveNames">Indicates whether name comparisons should be case-sensitive.</param>
        public NameValueList(IEnumerable<(string Name, TValue Value)> items, bool caseSensitiveNames)
        {
            _caseSensitiveNames = caseSensitiveNames;
            AddRange(items);
        }

        /// <summary>
        /// Adds a new Name/Value pair to the list.
        /// </summary>
        /// <param name="name">The name of the pair.</param>
        /// <param name="value">The value associated with the name.</param>
        /// <example>
        /// <code lang="C#">
        /// var list = new NameValueList&lt;string&gt;(true);
        /// list.Add("Key", "Value");
        /// </code>
        /// </example>
        public void Add(string name, TValue value) => Add((name, value));

        /// <summary>
        /// Adds a new Name/Value pair or replaces the value of an existing name.
        /// </summary>
        /// <param name="name">The name of the pair.</param>
        /// <param name="value">The value to associate with the name.</param>
        /// <remarks>
        /// If the name already exists, its value is replaced. If the name appears multiple times, all but the first occurrence are removed.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var list = new NameValueList&lt;string&gt;(true);
        /// list.AddOrReplace("Key", "Value1");
        /// list.AddOrReplace("Key", "Value2"); // Replaces "Value1" with "Value2".
        /// </code>
        /// </example>
        public void AddOrReplace(string name, TValue value)
        {
            var i = 0;
            var replaced = false;
            while (i < Count)
            {
                if (!this[i].Name.OrdinalEquals(name, !_caseSensitiveNames))
                    i++;
                else if (replaced)
                    RemoveAt(i);
                else
                {
                    this[i] = (name, value);
                    replaced = true;
                    i++;
                }
            }

            if (!replaced)
                Add(name, value);
        }

        /// <summary>
        /// Removes all Name/Value pairs with the specified name.
        /// </summary>
        /// <param name="name">The name to remove.</param>
        /// <returns><c>true</c> if at least one pair was removed; otherwise, <c>false</c>.</returns>
        /// <example>
        /// <code lang="C#">
        /// var list = new NameValueList&lt;string&gt;(true);
        /// list.Add("Key", "Value");
        /// list.Remove("Key"); // Removes the pair with name "Key".
        /// </code>
        /// </example>
        public bool Remove(string name) => RemoveAll(x => x.Name.OrdinalEquals(name, !_caseSensitiveNames)) > 0;

        /// <summary>
        /// Returns the first value associated with the specified name, or <c>null</c> if none exist.
        /// </summary>
        /// <param name="name">The name to search for.</param>
        /// <returns>The first value associated with the name, or <c>null</c>.</returns>
        /// <example>
        /// <code lang="C#">
        /// var list = new NameValueList&lt;string&gt;(true);
        /// list.Add("Key", "Value");
        /// var value = list.FirstOrDefault("Key"); // Returns "Value".
        /// </code>
        /// </example>
        public TValue FirstOrDefault(string name) => GetAll(name).FirstOrDefault();

        /// <summary>
        /// Attempts to retrieve the first value associated with the specified name.
        /// </summary>
        /// <param name="name">The name to search for.</param>
        /// <param name="value">When this method returns, contains the first value associated with the name, if found; otherwise, the default value for <typeparamref name="TValue"/>.</param>
        /// <returns><c>true</c> if a value was found; otherwise, <c>false</c>.</returns>
        /// <example>
        /// <code lang="C#">
        /// var list = new NameValueList&lt;string&gt;(true);
        /// list.Add("Key", "Value");
        /// if (list.TryGetFirst("Key", out var value))
        /// {
        ///     Console.WriteLine(value); // Outputs "Value".
        /// }
        /// </code>
        /// </example>
        public bool TryGetFirst(string name, out TValue value)
        {

            var firstItems = GetAll(name).Take(1).ToList();
            if (firstItems.Any())
            {
                value = firstItems.First();
                return true;
            }

            value = default;
            return false;

        }

        /// <summary>
        /// Retrieves all values associated with the specified name.
        /// </summary>
        /// <param name="name">The name to search for.</param>
        /// <returns>An enumerable collection of values associated with the name.</returns>
        /// <example>
        /// <code lang="C#">
        /// var list = new NameValueList&lt;string&gt;(true);
        /// list.Add("Key", "Value1");
        /// list.Add("Key", "Value2");
        /// var values = list.GetAll("Key"); // Returns ["Value1", "Value2"].
        /// </code>
        /// </example>
        public IEnumerable<TValue> GetAll(string name) => this
            .Where(x => x.Name.OrdinalEquals(name, !_caseSensitiveNames))
            .Select(x => x.Value);

        /// <summary>
        /// Determines whether the list contains a Name/Value pair with the specified name.
        /// </summary>
        /// <param name="name">The name to search for.</param>
        /// <returns><c>true</c> if the name exists; otherwise, <c>false</c>.</returns>
        /// <example>
        /// <code lang="C#">
        /// var list = new NameValueList&lt;string&gt;(true);
        /// list.Add("Key", "Value");
        /// var exists = list.Contains("Key"); // Returns true.
        /// </code>
        /// </example>
        public bool Contains(string name) => this.Any(x => x.Name.OrdinalEquals(name, !_caseSensitiveNames));

        /// <summary>
        /// Determines whether the list contains a specific Name/Value pair.
        /// </summary>
        /// <param name="name">The name to search for.</param>
        /// <param name="value">The value to search for.</param>
        /// <returns><c>true</c> if the Name/Value pair exists; otherwise, <c>false</c>.</returns>
        /// <example>
        /// <code lang="C#">
        /// var list = new NameValueList&lt;string&gt;(true);
        /// list.Add("Key", "Value");
        /// var exists = list.Contains("Key", "Value"); // Returns true.
        /// </code>
        /// </example>
        public bool Contains(string name, TValue value) => Contains((name, value));
    
        private readonly bool _caseSensitiveNames;

    }
}
