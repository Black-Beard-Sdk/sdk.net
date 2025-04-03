using Bb.ComponentModel.Attributes;
using Bb.ComponentModel;
using Bb.Loaders.Extensions;

namespace Bb.Models
{


    [ExposeClass(ConstantsCore.Configuration, LifeCycle = IocScopeEnum.Singleton)]
    public class StartupConfiguration
    {

        public StartupConfiguration()
        {
            BearerOptions = new List<BearerOption>();
            this.PolicyFiles = new HashSet<string>();
            this.RestClient = new RestClientOptions();
            this.Packages = new Packages();
            this.Folders = new HashSet<string>();
            this.AssemblyNames = new HashSet<string>();
        }

        public bool LogExceptions { get; set; } = true;

        public bool LogInfo { get; set; } = true;

        public bool UseStaticFiles { get; set; } = false;

        public bool UseRouting { get; set; } = true;

        public bool MapBlazorHub { get; set; } = false;

        public string MapFallbackToPage { get; set; }

        public Certificate HttpsCertificate { get; set; }

        public List<BearerOption> BearerOptions { get; set; }

        public HashSet<string> PolicyFiles { get; set; }

        public RestClientOptions RestClient { get; set; }

        public Packages Packages { get; set; }

        public HashSet<string> Folders { get; set; }

        public HashSet<string> AssemblyNames { get; set; }

    }

}
