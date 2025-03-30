namespace Bb.Models
{
    public class Certificate
    {

        public string SourcePath { get; set; }

        public string Password { get; set; } = "password";

        public SourceCertificate TypeSource { get; set; } = SourceCertificate.File;

    }


}
