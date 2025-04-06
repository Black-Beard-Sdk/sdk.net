namespace Bb.Models
{
    /// <summary>
    /// Specifies the source type of a certificate.
    /// </summary>
    /// <remarks>
    /// This enumeration defines the possible sources from which a certificate can be loaded, such as a file or a certificate store.
    /// </remarks>
    public enum SourceCertificate
    {
        /// <summary>
        /// Indicates that the certificate is loaded from a file.
        /// </summary>
        /// <example>
        /// <code lang="C#">
        /// var certificate = new Certificate();
        /// certificate.TypeSource = SourceCertificate.File;
        /// Console.WriteLine($"Certificate Source: {certificate.TypeSource}");
        /// </code>
        /// </example>
        File,

        /// <summary>
        /// Indicates that the certificate is loaded from a certificate store.
        /// </summary>
        /// <example>
        /// <code lang="C#">
        /// var certificate = new Certificate();
        /// certificate.TypeSource = SourceCertificate.Store;
        /// Console.WriteLine($"Certificate Source: {certificate.TypeSource}");
        /// </code>
        /// </example>
        Store
    }
}
