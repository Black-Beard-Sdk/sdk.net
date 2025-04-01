
using Bb.ComponentModel;
using Bb.Nugets;

namespace Bb.Services
{
    public class PackageManager
    {

        public PackageManager(ILogger<PackageManager> logger)
        {

            this._logger = logger;

        }


        public async Task Test()
        {

            var service = new NuGetDownloader(null)
              .FilterFiles(c => c.EndsWith(".dll"))
              .SetRepositoryFolder("c:\\tmp\\nuget")
              .FilterFramworks((a, b, c) =>
              {
                  return true;
              })
              ;

            var items = await service.GetPackageFilesAsync("Black.Beard.ComponentModel");


            List<AssemblyMatched> assemblies = new List<AssemblyMatched>();

            var addon = new AddonsResolver();

            foreach (var item in items)
            {
                assemblies = addon.SearchListReferences(item).ToList();
                var filteredAssemblies = assemblies.Where(c => !c.IsLoaded && !c.IsSdk).ToList();
                foreach (var assembly in filteredAssemblies)
                    assemblies.Add(assembly);
            }

        }


        private readonly ILogger<PackageManager> _logger;


    }

}



