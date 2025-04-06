namespace Bb.Services
{
    /// <summary>
    /// Represents a container for storing a value of type <typeparamref name="T"/>.
    /// </summary>
    /// <typeparam name="T">The type of the value to store in the bag.</typeparam>
    /// <remarks>
    /// This class provides a simple container for holding a value of type <typeparamref name="T"/>. 
    /// It is typically used to pass or store values in scenarios where mutability is required.
    /// </remarks>
    public class Bag<T>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Bag{T}"/> class.
        /// </summary>
        /// <remarks>
        /// This constructor creates an empty bag with no initial value.
        /// </remarks>
        public Bag()
        {
        }

        /// <summary>
        /// Gets or sets the value stored in the bag.
        /// </summary>
        /// <value>The value of type <typeparamref name="T"/> stored in the bag.</value>
        /// <remarks>
        /// The value can be accessed or modified internally within the assembly.
        /// </remarks>
        public T Value { get; internal set; }
    }
}
