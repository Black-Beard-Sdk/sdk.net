namespace Bb.Models
{

    /// <summary>
    /// Represents a collection of <see cref="Package"/> objects.
    /// </summary>
    public class Packages : List<Package>
    {

        /// <summary>
        /// Implicitly converts an array of <see cref="Package"/> objects to a <see cref="Packages"/> instance.
        /// </summary>
        /// <param name="packages">An array of <see cref="Package"/> objects to convert. Must not be null.</param>
        /// <returns>A new <see cref="Packages"/> instance containing the specified packages.</returns>
        /// <remarks>
        /// This operator allows an array of <see cref="Package"/> objects to be implicitly converted into a <see cref="Packages"/> collection, simplifying initialization.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// Package[] packageArray = { new Package { Id = "Package1" }, new Package { Id = "Package2" } };
        /// Packages packages = packageArray;
        /// Console.WriteLine($"Number of packages: {packages.Count}");
        /// </code>
        /// </example>
        public static implicit operator Packages(Package[] packages)
        {
            var p = new Packages();
            p.AddRange(packages);
            return p;
        }

    }

}
