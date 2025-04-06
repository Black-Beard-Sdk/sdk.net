namespace Bb.Models
{

    /// <summary>
    /// Represents a package with an identifier and version.
    /// </summary>
    public class Package
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Package"/> class.
        /// </summary>
        /// <remarks>
        /// This constructor initializes a new package instance with default values.
        /// </remarks>
        public Package()
        {
            // ...existing code...
        }

        /// <summary>
        /// Gets or sets the unique identifier of the package.
        /// </summary>
        /// <value>A <see cref="string"/> representing the package identifier.</value>
        /// <remarks>
        /// This property is used to uniquely identify a package within the application.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var package = new Package();
        /// package.Id = "MyPackage";
        /// Console.WriteLine($"Package ID: {package.Id}");
        /// </code>
        /// </example>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the version of the package.
        /// </summary>
        /// <value>A <see cref="string"/> representing the package version.</value>
        /// <remarks>
        /// This property specifies the version of the package, which can be used for version control or dependency management.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var package = new Package();
        /// package.Version = "1.0.0";
        /// Console.WriteLine($"Package Version: {package.Version}");
        /// </code>
        /// </example>
        public string Version { get; set; }

        /// <summary>
        /// Implicitly converts a <see cref="string"/> to a <see cref="Package"/> instance.
        /// </summary>
        /// <param name="value">A <see cref="string"/> representing the package identifier. Must not be null or empty.</param>
        /// <returns>A new <see cref="Package"/> instance with the <see cref="Id"/> property set to the specified value.</returns>
        /// <remarks>
        /// This operator allows a string to be implicitly converted into a <see cref="Package"/> object, simplifying initialization.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// Package package = "MyPackage";
        /// Console.WriteLine($"Package ID: {package.Id}");
        /// </code>
        /// </example>
        public static implicit operator Package(string value)
        {
            return new Package() { Id = value };
        }
    }
}
