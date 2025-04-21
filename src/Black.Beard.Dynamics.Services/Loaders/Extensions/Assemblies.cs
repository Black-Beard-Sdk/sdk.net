using Bb.ComponentModel.Loaders;
using Bb;
using System.Reflection;
using Bb.ComponentModel.Attributes;

namespace Bb.Loaders.Extensions
{


    /// <summary>
    /// Provides methods for managing assemblies in a web application.
    /// </summary>
    public static class Assemblies
    {

        /// <summary>
        /// Gets the additional assemblies to include for route discovery.
        /// </summary>
        /// <returns>An enumerable of <see cref="Assembly"/> objects representing the additional assemblies.</returns>
        /// <remarks>
        /// This property returns all assemblies in the current application domain, excluding the executing assembly, that are relevant for route discovery.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var assemblies = Assemblies.AdditionalAssemblies;
        /// foreach (var assembly in assemblies)
        /// {
        ///     Console.WriteLine($"Assembly: {assembly.FullName}");
        /// }
        /// </code>
        /// </example>
        public static IEnumerable<Assembly> AdditionalAssemblies
        {
            get
            {
                var assembly = Assembly.GetExecutingAssembly();
                return WebAssemblies.Where(c => c != assembly);
            }
        }

        /// <summary>
        /// Gets all assemblies that contain types with route attributes.
        /// </summary>
        /// <returns>An enumerable of <see cref="Assembly"/> objects representing the assemblies containing route attributes.</returns>
        /// <remarks>
        /// This property scans all assemblies in the current application domain and includes those that contain types decorated with route attributes.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var webAssemblies = Assemblies.WebAssemblies;
        /// foreach (var assembly in webAssemblies)
        /// {
        ///     Console.WriteLine($"Web Assembly: {assembly.FullName}");
        /// }
        /// </code>
        /// </example>
        public static IEnumerable<Assembly> WebAssemblies
        {
            get
            {

                var _assemblies = AppDomain.CurrentDomain.GetAssemblies();

                foreach (var item in _assemblies)
                    if (item.ContainPage())
                        yield return item;
            }
        }

        /// <summary>
        /// Determines if the specified assembly contains types with route attributes.
        /// </summary>
        /// <param name="assembly">The <see cref="Assembly"/> to check. Must not be null.</param>
        /// <returns><see langword="true"/> if the assembly contains types with route attributes; otherwise, <see langword="false"/>.</returns>
        /// <remarks>
        /// This method checks if the assembly references "Microsoft.AspNetCore.Components" and contains types decorated with <see cref="Microsoft.AspNetCore.Components.RouteAttribute"/>.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var assembly = Assembly.GetExecutingAssembly();
        /// bool containsRoutes = assembly.ContainPage();
        /// Console.WriteLine($"Contains routes: {containsRoutes}");
        /// </code>
        /// </example>
        private static bool ContainPage(this Assembly assembly)
        {

            AssemblyName[] m = assembly.GetReferencedAssemblies();

            if (m.Any(c => !string.IsNullOrEmpty(c.Name) && c.Name.StartsWith("Microsoft.AspNetCore.Components")))
                return assembly.ExportedTypes.Any(c => c.GetCustomAttributes().OfType<Microsoft.AspNetCore.Components.RouteAttribute>().Any());

            return false;

        }


    }
}
