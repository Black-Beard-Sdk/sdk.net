using Bb.ComponentModel;
using Bb.ComponentModel.Attributes;
using Bb.Models;
using Bb.Nugets;
using NuGet.Common;
using System.Diagnostics;
using System.Reflection;

namespace Bb.Services
{


    /// <summary>
    /// manage downloading of nuget packages
    /// </summary>
    /// <param name="logger"></param>
    [ExposeClass(ConstantsCore.Service, LifeCycle = IocScope.Singleton)]
    public class PackageManager(ILogger<PackageManager>? logger)
    {


        /// <summary>
        /// add the type to looking for in assemblies
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public PackageManager WithReference(Type type)
        {
            _addon.WithReference(type);
            return this;
        }

        /// <summary>
        /// Set the root directory for storing nuget packages
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public PackageManager SetTarget(string path)
        {
            _target = path;
            return this;
        }

        /// <summary>
        /// Resolves a collection of packages by downloading and processing them.
        /// </summary>
        /// <param name="packages">The collection of packages to resolve. Must not be null.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        /// <remarks>
        /// This method processes each package in the collection by downloading and resolving its dependencies.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var packages = new Packages { new Package("PackageA"), new Package("PackageB") };
        /// await packageManager.Resolve(packages);
        /// </code>
        /// </example>
        public async Task Resolve(Packages packages)
        {
            foreach (var package in packages)
                await Resolve(package);
        }

        /// <summary>
        /// Resolves a single package by downloading and processing it.
        /// </summary>
        /// <param name="package">The package to resolve. Must not be null.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        /// <remarks>
        /// This method downloads the specified package and resolves its dependencies.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var package = new Package("PackageA");
        /// await packageManager.Resolve(package);
        /// </code>
        /// </example>
        public async Task Resolve(Package package)
        {
            Version? version = null;
            if (!string.IsNullOrEmpty(package.Version) && !Version.TryParse(package.Version, out version))
                _logger?.LogWarning("The version {Version} is not valid. Switch on latest version", package.Version);

            await Resolve(package.Id, version);
        }

        /// <summary>
        /// Resolves a NuGet package by its ID and optional version.
        /// </summary>
        /// <param name="packageId">The ID of the package to resolve. Must not be null or empty.</param>
        /// <param name="version">The optional version of the package. If null, the latest version is used.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        /// <remarks>
        /// This method downloads the specified NuGet package by its ID and resolves its dependencies.
        /// </remarks>
        /// <exception cref="ArgumentNullException">
        /// Thrown if <paramref name="packageId"/> is null or empty.
        /// </exception>
        /// <example>
        /// <code lang="C#">
        /// await packageManager.Resolve("Newtonsoft.Json", new Version("13.0.1"));
        /// </code>
        /// </example>
        public async Task Resolve(string packageId, Version? version = null)
        {
            NuGet.Common.ILogger l = this._logger != null
                    ? new NuGetILogger(this._logger)
                    : new NuGetLogger();

            var downloader = new NuGetDownloader(l)
                  .FilterFiles(c => c.EndsWith(".dll"))
                  .SetRepositoryFolder(_target)
                  .FilterFramworks((a, b, c) =>
                  {
                      return true;
                  });

            var items = await downloader.GetPackageFilesAsync(packageId, version);
            foreach (var item in items)
            {
                var ass = _addon.SearchListReferences(item).ToList();
                List<AssemblyMatched> filteredAssemblies = ass.Where(c => !c.IsSdk).ToList();
                foreach (var assembly in filteredAssemblies)
                {
                    _logger?.LogInformation("append assembly {AssemblyName}", assembly.AssemblyName);
                    _assemblies.Add(assembly);
                }
            }
        }

        /// <summary>
        /// Gets the resolved assemblies.
        /// </summary>
        /// <value>An array of <see cref="AssemblyMatched"/> representing the resolved assemblies.</value>
        /// <remarks>
        /// This property provides access to the assemblies that have been resolved during the package resolution process.
        /// </remarks>
        public AssemblyMatched[] Assemblies => _assemblies.ToArray();

        private readonly ILogger<PackageManager>? _logger = logger;
        private readonly List<AssemblyMatched> _assemblies = new List<AssemblyMatched>();
        private string _target = Path.GetTempPath().Combine(Assembly.GetExecutingAssembly().GetName().Name, ".nuget");
        private readonly AddonsResolver _addon = new AddonsResolver();

        private class NuGetILogger : NuGet.Common.ILogger
        {
            private readonly Microsoft.Extensions.Logging.ILogger _logger;

            public NuGetILogger(Microsoft.Extensions.Logging.ILogger logger)
            {
                _logger = logger;
            }

            public void LogDebug(string data) => _logger?.LogDebug(data);
            public void LogVerbose(string data) => _logger?.LogTrace(data);
            public void LogInformation(string data) => _logger?.LogInformation(data);
            public void LogMinimal(string data) => _logger?.LogInformation(data);
            public void LogWarning(string data) => _logger?.LogWarning(data);
            public void LogError(string data) => _logger?.LogError(data);
            public void LogInformationSummary(string data) => _logger?.LogInformation(data);
            public void Log(NuGet.Common.LogLevel level, string data)
            {
                switch (level)
                {
                    case NuGet.Common.LogLevel.Debug:
                        LogDebug(data);
                        break;
                    case NuGet.Common.LogLevel.Verbose:
                        LogVerbose(data);
                        break;
                    case NuGet.Common.LogLevel.Information:
                        LogInformation(data);
                        break;
                    case NuGet.Common.LogLevel.Minimal:
                        LogMinimal(data);
                        break;
                    case NuGet.Common.LogLevel.Warning:
                        LogWarning(data);
                        break;
                    case NuGet.Common.LogLevel.Error:
                        LogError(data);
                        break;
                }
            }

            public Task LogAsync(NuGet.Common.LogLevel level, string data)
            {
                Log(level, data);
                return Task.CompletedTask;
            }

            public void Log(ILogMessage message) => Log(message.Level, message.Message);

            public Task LogAsync(ILogMessage message)
            {
                Log(message);
                return Task.CompletedTask;
            }

        }

        private class NuGetLogger : NuGet.Common.ILogger
        {

            public NuGetLogger()
            {
            }

            public void LogDebug(string data) => Trace.TraceInformation(data);
            public void LogVerbose(string data) => Trace.TraceInformation(data);
            public void LogInformation(string data) => Trace.TraceInformation(data);
            public void LogMinimal(string data) => Trace.TraceInformation(data);
            public void LogWarning(string data) => Trace.TraceWarning(data);
            public void LogError(string data) => Trace.TraceError(data);
            public void LogInformationSummary(string data) => Trace.TraceInformation(data);
            public void Log(NuGet.Common.LogLevel level, string data)
            {
                switch (level)
                {
                    case NuGet.Common.LogLevel.Debug:
                        LogDebug(data);
                        break;
                    case NuGet.Common.LogLevel.Verbose:
                        LogVerbose(data);
                        break;
                    case NuGet.Common.LogLevel.Information:
                        LogInformation(data);
                        break;
                    case NuGet.Common.LogLevel.Minimal:
                        LogMinimal(data);
                        break;
                    case NuGet.Common.LogLevel.Warning:
                        LogWarning(data);
                        break;
                    case NuGet.Common.LogLevel.Error:
                        LogError(data);
                        break;
                }
            }

            public Task LogAsync(NuGet.Common.LogLevel level, string data)
            {
                Log(level, data);
                return Task.CompletedTask;
            }

            public void Log(ILogMessage message) => Log(message.Level, message.Message);

            public Task LogAsync(ILogMessage message)
            {
                Log(message);
                return Task.CompletedTask;
            }

        }

    }

}



