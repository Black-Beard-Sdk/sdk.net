namespace Bb.Urls
{
    /// <summary>
    /// Represents a segment of a URL or path.
    /// </summary>
    public struct Segment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Segment"/> struct.
        /// </summary>
        /// <param name="segment">The segment string. Must not be null.</param>
        /// <remarks>
        /// This constructor initializes the segment and determines if it represents a variable. 
        /// Variables are identified by being enclosed in "%7B" and "%7D".
        /// </remarks>
        /// <exception cref="ArgumentNullException">
        /// Thrown if <paramref name="segment"/> is null.
        /// </exception>
        public Segment(string segment)
        {
            
            if (segment == null)
                throw new ArgumentNullException(nameof(segment));

            Value = segment;

            var s1 = segment.IndexOf("%7B");
            var s2 = segment.IndexOf("%7D");

            IsMalicious = segment.IndexOf("%3C") > -1 || segment.IndexOf("%3E") > -1;

            if (s2 > s1 && s1 > -1)
            {
                IsVariable = true;
                Value = Value.Substring(s1 + 3, s2 - s1 - 3);
            }

        }

        /// <summary>
        /// Gets a value indicating whether the segment is a variable.
        /// </summary>
        /// <value><c>true</c> if the segment is a variable; otherwise, <c>false</c>.</value>
        /// <remarks>
        /// A segment is considered a variable if it is enclosed in "%7B" and "%7D".
        /// </remarks>
        public bool IsVariable { get; private set; }

        /// <summary>
        /// Gets the value of the segment.
        /// </summary>
        /// <value>A string representing the segment value.</value>
        /// <remarks>
        /// If the segment is a variable, this property contains the variable name without the enclosing "%7B" and "%7D".
        /// </remarks>
        public string Value { get; private set; }

        /// <summary>
        /// Gets the encoded value of the segment.
        /// </summary>
        /// <value>A string representing the encoded value of the segment.</value>
        /// <remarks>
        /// If the segment is a variable, it is returned in the format "{variableName}". Otherwise, the raw value is returned.
        /// </remarks>
        public string EncodedValue
        {
            get
            {

                if (IsMalicious)
                    return IsVariable ? $"{{{Value}}}" : Value;

                return IsVariable ? $"{{{Value}}}" : Value;
            }
        }


        public bool IsMalicious { get; }

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
            return Value.ToString();
        }

        /// <summary>
        /// Maps a value to the segment if it is a variable.
        /// </summary>
        /// <param name="value">The value to map to the segment. Must not be null.</param>
        /// <remarks>
        /// This method replaces the variable name in the segment with the provided value.
        /// </remarks>
        /// <exception cref="InvalidOperationException">
        /// Thrown if the segment is not a variable.
        /// </exception>
        /// <example>
        /// <code lang="C#">
        /// var segment = new Segment("%7Bvariable%7D");
        /// segment.Map("mappedValue");
        /// Console.WriteLine(segment.Value); // Output: mappedValue
        /// </code>
        /// </example>
        public void Map(string value)
        {
            if (IsVariable)
            {
                Value = value;
                IsVariable = false;
            }
            else
                throw new InvalidOperationException("This segment is not a variable.");
        }


        public static implicit operator string(Segment segment)
        {
            return segment.EncodedValue;
        }

    }
}