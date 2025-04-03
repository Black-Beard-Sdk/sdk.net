namespace Bb.Models
{
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



}
