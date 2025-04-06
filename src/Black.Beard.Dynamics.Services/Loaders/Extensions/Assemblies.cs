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

        ///// <summary>
        ///// Ensure required assemblies are loaded
        ///// </summary>
        //public static ExposedAssemblyRepositories Resolve(string filename, string[] configPaths)
        //{

        //    foreach (var repertoireConfig in configPaths)
        //    {

        //        var _currentDirectory = Directory.GetCurrentDirectory();
        //        var dir = _currentDirectory.Combine(repertoireConfig).AsDirectory();
        //        var files = dir.GetFiles(filename, SearchOption.AllDirectories);
        //        foreach (var file in files)
        //            try
        //            {
        //                ExposedAssemblyRepositories assemblies
        //                    = file.LoadFromFileAndDeserialize<ExposedAssemblyRepositories>();
                        
        //                return assemblies;
        //            }
        //            catch (Exception ex)
        //            {
        //                throw;
        //            }
        //    }

        //    return null;

        //}

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

            if (m.Any(c => c.Name.StartsWith("Microsoft.AspNetCore.Components")))
                return assembly.ExportedTypes.Any(c => c.GetCustomAttributes().OfType<Microsoft.AspNetCore.Components.RouteAttribute>().Any());

            return false;

        }

        /// <summary>
        /// Determines if the specified assembly contains types with route attributes, based on a specific referenced assembly name.
        /// </summary>
        /// <param name="assembly">The <see cref="Assembly"/> to check. Must not be null.</param>
        /// <returns><see langword="true"/> if the assembly contains types with route attributes; otherwise, <see langword="false"/>.</returns>
        /// <remarks>
        /// This method checks if the assembly references the assembly containing <see cref="ExposeClassAttribute"/> and contains types decorated with <see cref="Microsoft.AspNetCore.Components.RouteAttribute"/>.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var assembly = Assembly.GetExecutingAssembly();
        /// bool containsRoutes = assembly.ContainPage2();
        /// Console.WriteLine($"Contains routes: {containsRoutes}");
        /// </code>
        /// </example>
        private static bool ContainPage2(this Assembly assembly)
        {

            var name = typeof(ExposeClassAttribute).Assembly.FullName;
            AssemblyName[] m = assembly.GetReferencedAssemblies();

            if (m.Any(c => c.Name.StartsWith(name)))
                return assembly.ExportedTypes.Any(c => c.GetCustomAttributes().OfType<Microsoft.AspNetCore.Components.RouteAttribute>().Any());

            return false;

        }

        /// <summary>
        /// Determines if the specified assembly contains types with route attributes, based on a specific text to search in referenced assembly names.
        /// </summary>
        /// <param name="assembly">The <see cref="Assembly"/> to check. Must not be null.</param>
        /// <param name="textToSearch">The text to search for in the referenced assembly names. Must not be null or empty.</param>
        /// <returns><see langword="true"/> if the assembly contains types with route attributes; otherwise, <see langword="false"/>.</returns>
        /// <remarks>
        /// This method checks if the assembly references an assembly whose name starts with the specified text and contains types decorated with <see cref="Microsoft.AspNetCore.Components.RouteAttribute"/>.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var assembly = Assembly.GetExecutingAssembly();
        /// bool containsRoutes = assembly.ContainPage2("Microsoft.AspNetCore.Components");
        /// Console.WriteLine($"Contains routes: {containsRoutes}");
        /// </code>
        /// </example>
        private static bool ContainPage2(this Assembly assembly, string textToSearch)
        {
            AssemblyName[] m = assembly.GetReferencedAssemblies();
            if (m.Any(c => c.Name.StartsWith(textToSearch)))
                return assembly.ExportedTypes.Any(c => c.GetCustomAttributes().OfType<Microsoft.AspNetCore.Components.RouteAttribute>().Any());

            return false;

        }

    }
}
