namespace Bb.Curls
{
    /// <summary>
    /// Represents a command-line argument with an optional name and value.
    /// </summary>
    /// <remarks>
    /// This class is used to encapsulate a single argument, which may include a name and a value.
    /// </remarks>
    public class Argument
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Argument"/> class.
        /// </summary>
        /// <param name="value">The value of the argument. Must not be null.</param>
        /// <param name="name">The optional name of the argument. Can be null.</param>
        /// <remarks>
        /// The constructor allows creating an argument with a value and an optional name.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var argument = new Argument("value", "name");
        /// Console.WriteLine(argument.Name);  // Output: name
        /// Console.WriteLine(argument.Value); // Output: value
        /// </code>
        /// </example>
        public Argument(string value, string? name = null)
        {
            Value = value;
            Name = name;
        }

        /// <summary>
        /// Gets the name of the argument.
        /// </summary>
        /// <value>
        /// The name of the argument, or <see langword="null"/> if no name is specified.
        /// </value>
        public string? Name { get; }

        /// <summary>
        /// Gets the value of the argument.
        /// </summary>
        /// <value>
        /// The value of the argument.
        /// </value>
        public string Value { get; }

        /// <summary>
        /// Returns the string representation of the argument.
        /// </summary>
        /// <returns>The value of the argument as a string.</returns>
        /// <remarks>
        /// This method overrides <see cref="object.ToString"/> to return the value of the argument.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var argument = new Argument("value");
        /// Console.WriteLine(argument.ToString()); // Output: value
        /// </code>
        /// </example>
        public override string ToString()
        {
            return Value;
        }
    }

    /// <summary>
    /// Represents a source of command-line arguments that can be read sequentially.
    /// </summary>
    /// <remarks>
    /// This class provides methods to read arguments one by one and track the current state of the reading process.
    /// </remarks>
    public class ArgumentSource
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ArgumentSource"/> class.
        /// </summary>
        /// <param name="arguments">An array of arguments to initialize the source with. Must not be null.</param>
        /// <remarks>
        /// The constructor sets up the argument source with the provided array of arguments.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var source = new ArgumentSource(new[] { "arg1", "arg2" });
        /// while (source.ReadNext())
        /// {
        ///     Console.WriteLine(source.Current);
        /// }
        /// </code>
        /// </example>
        public ArgumentSource(string[] arguments)
        {
            this._index = -1;
            _arguments = arguments;
            this._max = _arguments.Length - 1;
            this.IsFailed = false;
            this.FailMessage = null;
        }

        /// <summary>
        /// Gets the current argument in the source.
        /// </summary>
        /// <value>
        /// The current argument as a string.
        /// </value>
        /// <remarks>
        /// This property returns the argument at the current index in the source.
        /// </remarks>
        public string Current
        {
            get
            {
                return _arguments[_index];
            }
        }

        /// <summary>
        /// Gets a value indicating whether more arguments can be read.
        /// </summary>
        /// <value>
        /// <see langword="true"/> if more arguments can be read; otherwise, <see langword="false"/>.
        /// </value>
        /// <remarks>
        /// This property checks if the reading process has not failed and there are more arguments to read.
        /// </remarks>
        public bool CanRead => !IsFailed && _index < _max;

        /// <summary>
        /// Gets a value indicating whether the reading process has failed.
        /// </summary>
        /// <value>
        /// <see langword="true"/> if the reading process has failed; otherwise, <see langword="false"/>.
        /// </value>
        public bool IsFailed { get; private set; }

        /// <summary>
        /// Gets the failure message if the reading process has failed.
        /// </summary>
        /// <value>
        /// The failure message, or <see langword="null"/> if no failure has occurred.
        /// </value>
        public string? FailMessage { get; private set; }

        /// <summary>
        /// Advances to the next argument in the source.
        /// </summary>
        /// <returns>
        /// <see langword="true"/> if the next argument is available; otherwise, <see langword="false"/>.
        /// </returns>
        /// <remarks>
        /// This method increments the index to point to the next argument in the source.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var source = new ArgumentSource(new[] { "arg1", "arg2" });
        /// while (source.ReadNext())
        /// {
        ///     Console.WriteLine(source.Current);
        /// }
        /// </code>
        /// </example>
        public bool ReadNext()
        {
            if (_index < _max)
            {
                _index++;
                return true;
            }

            return false;
        }

        /// <summary>
        /// Creates an <see cref="Argument"/> instance from the current argument.
        /// </summary>
        /// <returns>
        /// A new <see cref="Argument"/> instance containing the current argument value.
        /// </returns>
        /// <remarks>
        /// This method wraps the current argument in an <see cref="Argument"/> object.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var source = new ArgumentSource(new[] { "arg1" });
        /// source.ReadNext();
        /// var argument = source.GetArgument();
        /// Console.WriteLine(argument.Value); // Output: arg1
        /// </code>
        /// </example>
        public Argument GetArgument()
        {
            return new Argument(Current);
        }

        /// <summary>
        /// Marks the reading process as failed with a specified message.
        /// </summary>
        /// <param name="failMessage">The failure message. Must not be null.</param>
        /// <remarks>
        /// This method sets the failure state and message for the argument source.
        /// </remarks>
        internal void Failed(string failMessage)
        {
            this.IsFailed = true;
            this.FailMessage = failMessage;
        }

        private int _index;
        private readonly string[] _arguments;
        private readonly int _max;
    }
}
