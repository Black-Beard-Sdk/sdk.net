
using Bb.ComponentModel;
using Bb.ComponentModel.Attributes;
using Bb.Loaders;
using Bb.Models;
using Bb.Nugets;
using NuGet.Common;
using System.Diagnostics;
using System.Reflection;

namespace Bb.Services
{


    [ExposeClass(ConstantsCore.Service, LifeCycle = IocScopeEnum.Singleton)]
    public class PackageManager
    {

        public PackageManager(ILogger<PackageManager>? logger)
        {
            this._logger = logger;
            _assemblies = new List<AssemblyMatched>();
            _addon = new AddonsResolver();
            _target = Path.GetTempPath().Combine(Assembly.GetExecutingAssembly().GetName().Name, ".nuget");
        }

        public PackageManager WithReference(Type type)
        {
            _addon.WithReference(type);
            return this;
        }

        public PackageManager SetTarget(string path)
        {
            _target = path;
            return this;
        }

        public async Task Resolve(Packages packages)
        {

            foreach (var package in packages)
                await Resolve(package);

        }

        public async Task Resolve(Package package)
        {

            Version version = null;
            if (!string.IsNullOrEmpty(package.Version) && !Version.TryParse(package.Version, out version))
                _logger?.LogWarning($"The version {package.Version} is not valid. Switch on latest version");

            await Resolve(package.Id, version);

        }

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
                    _logger?.LogInformation($"append assembly {assembly.AssemblyName}");
                    _assemblies.Add(assembly);
                }
            }

        }

        public AssemblyMatched[] Assemblies => _assemblies.ToArray();

        private readonly ILogger<PackageManager> _logger;
        private List<AssemblyMatched> _assemblies;
        private string _target;
        private readonly AddonsResolver _addon;

        private class NuGetILogger : NuGet.Common.ILogger
        {
            private readonly Microsoft.Extensions.Logging.ILogger _logger;

            public NuGetILogger(Microsoft.Extensions.Logging.ILogger logger)
            {
                _logger = logger;
            }

            public void LogDebug(string data) => _logger.LogDebug(data);
            public void LogVerbose(string data) => _logger.LogTrace(data);
            public void LogInformation(string data) => _logger.LogInformation(data);
            public void LogMinimal(string data) => _logger.LogInformation(data);
            public void LogWarning(string data) => _logger.LogWarning(data);
            public void LogError(string data) => _logger.LogError(data);
            public void LogInformationSummary(string data) => _logger.LogInformation(data);
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

            public void LogDebug(string data) => Trace.WriteLine(data);
            public void LogVerbose(string data) => Trace.WriteLine(data);
            public void LogInformation(string data) => Trace.TraceInformation(data);
            public void LogMinimal(string data) => Trace.WriteLine(data);
            public void LogWarning(string data) => Trace.TraceWarning(data);
            public void LogError(string data) => Trace.TraceError(data);
            public void LogInformationSummary(string data) => Trace.WriteLine(data);
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



