namespace Bb.Models
{

    /// <summary>
    /// Represents a certificate used for authentication or encryption.
    /// </summary>
    public class Certificate
    {

        /// <summary>
        /// Gets or sets the source path of the certificate.
        /// </summary>
        /// <value>A <see cref="string"/> representing the file path or location of the certificate.</value>
        /// <remarks>
        /// This property specifies the location of the certificate file, which can be used for authentication or encryption purposes.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var certificate = new Certificate();
        /// certificate.SourcePath = "path/to/certificate.pfx";
        /// Console.WriteLine($"Certificate Source Path: {certificate.SourcePath}");
        /// </code>
        /// </example>
        public string SourcePath { get; set; }

        /// <summary>
        /// Gets or sets the password for the certificate.
        /// </summary>
        /// <value>A <see cref="string"/> representing the password used to access the certificate.</value>
        /// <remarks>
        /// This property is used to provide the password required to load the certificate from the specified source.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var certificate = new Certificate();
        /// certificate.Password = "my-secure-password";
        /// Console.WriteLine($"Certificate Password: {certificate.Password}");
        /// </code>
        /// </example>
        public string Password { get; set; } = "password";

        /// <summary>
        /// Gets or sets the type of the certificate source.
        /// </summary>
        /// <value>A <see cref="SourceCertificate"/> enumeration value representing the source type of the certificate.</value>
        /// <remarks>
        /// This property indicates whether the certificate is loaded from a file, a store, or another source.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var certificate = new Certificate();
        /// certificate.TypeSource = SourceCertificate.File;
        /// Console.WriteLine($"Certificate Source Type: {certificate.TypeSource}");
        /// </code>
        /// </example>
        public SourceCertificate TypeSource { get; set; } = SourceCertificate.File;

    }


}
