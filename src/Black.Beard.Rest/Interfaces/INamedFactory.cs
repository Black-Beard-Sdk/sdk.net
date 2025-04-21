namespace Bb.Interfaces
{
    /// <summary>
    /// Represents a factory interface for creating objects of type <typeparamref name="TResult"/> using a key of type <typeparamref name="TKey"/>.
    /// </summary>
    /// <typeparam name="TKey">The type of the key used to create objects.</typeparam>
    /// <typeparam name="TResult">The type of object that the factory creates.</typeparam>
    /// <remarks>
    /// This interface defines a method for creating objects based on a provided key.
    /// </remarks>
    /// <example>
    /// <code lang="C#">
    /// public class MyNamedFactory : INamedFactory&lt;string, MyClass&gt;
    /// {
    ///     public MyClass Create(string name)
    ///     {
    ///         return new MyClass { Name = name };
    ///     }
    /// }
    /// </code>
    /// </example>
    public interface INamedFactory<in TKey, out TResult> : IFactory
    {
        /// <summary>
        /// Creates an instance of type <typeparamref name="TResult"/> using the specified key.
        /// </summary>
        /// <param name="name">The key used to create the object. Must not be null.</param>
        /// <returns>An instance of <typeparamref name="TResult"/>.</returns>
        /// <remarks>
        /// This method is responsible for creating and returning an object of the specified type based on the provided key.
        /// </remarks>
        /// <exception cref="ArgumentNullException">
        /// Thrown if <paramref name="name"/> is null.
        /// </exception>
        TResult Create(TKey name);
    }
}
