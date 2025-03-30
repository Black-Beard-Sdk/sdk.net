namespace Bb.Extensions
{




    public class BearerOption
    {

        public string Name { get; set; }

        public bool ValidateIssuer { get; set; } = true;

        public bool ValidateAudience { get; set; } = true;

        public bool ValidateLifetime { get; set; } = true;

        public bool ValidateIssuerSigningKey { get; set; } = true;

        public string ValidIssuer { get; set; } = "true";

        public string ValidAudience { get; set; } = "true";

        public string IssuerSigningKey { get; set; } = "true";

    }


}
