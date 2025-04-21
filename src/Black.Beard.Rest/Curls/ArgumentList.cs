
using System.Collections;

namespace Bb.Curls
{
    /// <summary>
    /// Represents a collection of <see cref="Argument"/> objects that can be enumerated and manipulated.
    /// </summary>
    /// <remarks>
    /// This class provides methods to add arguments to the list and supports enumeration through the <see cref="IEnumerable{T}"/> interface.
    /// </remarks>
    public class ArgumentList : IEnumerable<Argument>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ArgumentList"/> class.
        /// </summary>
        /// <remarks>
        /// This constructor creates an empty list of arguments.
        /// </remarks>
        public ArgumentList()
        {
            _arguments = new List<Argument>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArgumentList"/> class with the specified arguments.
        /// </summary>
        /// <param name="arguments">An array of <see cref="Argument"/> objects to initialize the list with. Must not be null.</param>
        /// <remarks>
        /// This constructor populates the list with the provided arguments.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var arguments = new Argument[] { new Argument("key1", "value1"), new Argument("key2", "value2") };
        /// var argumentList = new ArgumentList(arguments);
        /// </code>
        /// </example>
        public ArgumentList(Argument[] arguments) : this()
        {
            foreach (Argument argument in arguments)
                Add(argument);
        }

        /// <summary>
        /// Adds an <see cref="Argument"/> to the list.
        /// </summary>
        /// <param name="argument">The <see cref="Argument"/> to add. Must not be null.</param>
        /// <returns>The updated <see cref="ArgumentList"/> instance.</returns>
        /// <remarks>
        /// This method appends the specified argument to the list.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var argumentList = new ArgumentList();
        /// argumentList.Add(new Argument("key", "value"));
        /// </code>
        /// </example>
        public ArgumentList Add(Argument argument)
        {
            _arguments.Add(argument);
            return this;
        }

        /// <summary>
        /// Returns an enumerator that iterates through the <see cref="ArgumentList"/>.
        /// </summary>
        /// <returns>An enumerator of <see cref="Argument"/> objects.</returns>
        /// <remarks>
        /// This method allows enumeration of the arguments in the list.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var argumentList = new ArgumentList();
        /// foreach (var argument in argumentList)
        /// {
        ///     Console.WriteLine(argument.Key);
        /// }
        /// </code>
        /// </example>
        public IEnumerator<Argument> GetEnumerator()
        {
            return _arguments.GetEnumerator();
        }

        /// <summary>
        /// Returns an enumerator that iterates through the <see cref="ArgumentList"/>.
        /// </summary>
        /// <returns>An enumerator of <see cref="Argument"/> objects.</returns>
        /// <remarks>
        /// This method is an explicit implementation of the non-generic <see cref="IEnumerable"/> interface.
        /// </remarks>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return _arguments.GetEnumerator();
        }

        /// <summary>
        /// Implicitly converts an array of <see cref="Argument"/> objects to an <see cref="ArgumentList"/>.
        /// </summary>
        /// <param name="arguments">An array of <see cref="Argument"/> objects to convert. Must not be null.</param>
        /// <returns>An <see cref="ArgumentList"/> containing the specified arguments.</returns>
        /// <remarks>
        /// This operator allows seamless conversion from an array of arguments to an <see cref="ArgumentList"/>.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// Argument[] arguments = { new Argument("key1", "value1"), new Argument("key2", "value2") };
        /// ArgumentList argumentList = arguments;
        /// </code>
        /// </example>
        public static implicit operator ArgumentList(Argument[] arguments)
        {
            return new ArgumentList(arguments);
        }

        /// <summary>
        /// Gets the internal list of arguments.
        /// </summary>
        /// <remarks>
        /// This property holds the collection of arguments managed by the <see cref="ArgumentList"/>.
        /// </remarks>
        private List<Argument> _arguments { get; }
    
    }
}
