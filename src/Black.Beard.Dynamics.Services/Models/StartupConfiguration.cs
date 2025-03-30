using Bb.ComponentModel.Attributes;
using Bb.ComponentModel;
using Bb.Services;

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

    }

    public class RestClientOptions
    {


        public RestClientOptions()
        {
            this.Options = new List<ClientOptionConfiguration>();
        }


        public bool UseApiKey { get; set; } = false;

        public bool ClientActivated { get; set; } = true;



        public string TokenUrl { get; set; }

        public string TokenClientId { get; set; }

        public string TokenClientSecret { get; set; }

        public List<ClientOptionConfiguration> Options { get; set; }

    }

    public enum SourceCertificate
    {
        File,
        Store
    }


    public class ClientOptionConfiguration : ClientRestOption
    {

        public string Name { get; set; }

    }



}
