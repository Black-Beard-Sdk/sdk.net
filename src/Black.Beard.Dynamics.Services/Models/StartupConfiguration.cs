using Bb.ComponentModel.Attributes;
using Bb.ComponentModel;
using Bb.Extensions;

namespace Bb.Models
{

    [ExposeClass(ConstantsCore.Configuration, LifeCycle = IocScopeEnum.Singleton)]
    public class StartupConfiguration
    {

        public StartupConfiguration()
        {
            BearerOptions = new List<BearerOption>();
            this.PolicyFiles = new HashSet<string>();
        }

        public bool LogExceptions { get; set; } = true;

        public bool LogInfo { get; set; } = true;

        public bool UseApiKey { get; set; } = false;

        public bool UseStaticFiles { get; set; } = false;

        public bool UseRouting { get; set; } = false;

        public bool MapBlazorHub { get; set; } = false;

        public string MapFallbackToPage { get; set; } = "/Home";

        public Certificate HttpsCertificate { get; set; }

        public List<BearerOption> BearerOptions { get; set; }

        public HashSet<string> PolicyFiles { get;  set; }

    }

    public class Certificate
    {

        public string SourcePath { get; set; }

        public string Password { get; set; } = "password";

        public SourceCertificate TypeSource { get; set; } = SourceCertificate.File;

    }

    public enum SourceCertificate
    {
        File,
        Store
    }


}
