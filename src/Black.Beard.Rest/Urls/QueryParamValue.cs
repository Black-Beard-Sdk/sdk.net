namespace Bb.Urls
{
    /// <summary>
    /// Represents a query parameter value with the ability to track whether it was already encoded when created.
    /// </summary>
    public struct QueryParamValue
    {

        private readonly string _encodedValue;

        public QueryParamValue(object value) : this(Convert.ToString(value))
        {

        }

        public QueryParamValue(string value)
        {

            HasValue = true;
            Value = value;

            if (!string.IsNullOrEmpty(value))
            {
                var s1 = value.IndexOf("%7B");
                var s2 = value.IndexOf("%7D");
                if (s2 > s1 && s1 > -1)
                {
                    IsVariable = true;
                    Value = value.Substring(s1 + 3, s2 - s1 - 3);
                }
            }

        }

        public bool HasValue { get; }


        /// <summary>
        /// Return true if the object has been initialized with a value.
        /// </summary>
        public string Value { get; private set; }

        public bool IsVariable { get; private set; }

        /// <summary>
        /// Returns the string representation of the segment.
        /// </summary>
        /// <returns>A string representing the segment value.</returns>
        /// <remarks>
        /// This method returns the raw value of the segment.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var segment = new Segment("example");
        /// Console.WriteLine(segment.ToString()); // Output: example
        /// </code>
        /// </example>
        public override string ToString()
        {
            return EncodedValue(false);
        }


        /// <summary>
        /// Gets the encoded value of the segment.
        /// </summary>
        /// <value>A string representing the encoded value of the segment.</value>
        /// <remarks>
        /// If the segment is a variable, it is returned in the format "{variableName}". Otherwise, the raw value is returned.
        /// </remarks>
        public string EncodedValue( bool encodeSpaceAsPlus = false) => IsVariable ? $"{{{Value}}}" : Url.EncodeIllegalCharacters(Value, encodeSpaceAsPlus);

        public static implicit operator string(QueryParamValue value)
        {
            return value.EncodedValue(false);
        }

    }
}