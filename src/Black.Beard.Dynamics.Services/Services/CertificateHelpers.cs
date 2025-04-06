using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography;

namespace Bb.Services
{
    public static class CertificateHelpers
    {

        /// <summary>
        /// Loads a certificate from a file.
        /// </summary>
        /// <param name="certPath">The file path of the certificate. Must not be null.</param>
        /// <param name="certPassword">The password for the certificate. Must not be null or empty.</param>
        /// <returns>The loaded <see cref="X509Certificate2"/> instance.</returns>
        /// <remarks>
        /// This method loads a certificate from the specified file path using the provided password.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var certificate = CertificateHelpers.LoadCertificateFromFile(new FileInfo("path/to/cert.pfx"), "password");
        /// </code>
        /// </example>
        public static X509Certificate2 LoadCertificateFromFile(FileInfo certPath, string certPassword)
        {
            return new X509Certificate2(certPath.FullName, certPassword);
        }

        /// <summary>
        /// Loads a certificate from the store by subject name.
        /// </summary>
        /// <param name="subjectName">The subject name of the certificate. Must not be null or empty.</param>
        /// <returns>The loaded <see cref="X509Certificate2"/> instance.</returns>
        /// <remarks>
        /// This method retrieves a certificate from the certificate store based on the subject name.
        /// </remarks>
        /// <exception cref="PlatformNotSupportedException">
        /// Thrown if the current platform is not supported.
        /// </exception>
        /// <example>
        /// <code lang="C#">
        /// var certificate = CertificateHelpers.LoadCertificateFromStore("MyCertificate");
        /// </code>
        /// </example>
        public static X509Certificate2 LoadCertificateFromStore(string subjectName)
        {
            return Environment.OSVersion.Platform switch
            {
                PlatformID.Win32NT => Windows.LoadCertificateFromStore(subjectName),
                PlatformID.Unix => Unix.LoadCertificateFromStore(subjectName),
                _ => throw new PlatformNotSupportedException()
            };
        }

        /// <summary>
        /// Creates a self-signed certificate.
        /// </summary>
        /// <param name="subjectName">The subject name for the certificate. Must not be null or empty.</param>
        /// <param name="password">The password to protect the certificate. Must not be null or empty.</param>
        /// <returns>The created <see cref="X509Certificate2"/> instance.</returns>
        /// <remarks>
        /// This method generates a self-signed certificate with a validity of 5 years.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var certificate = CertificateHelpers.CreateSelfSignedCertificate("MyCertificate", "password");
        /// </code>
        /// </example>
        public static X509Certificate2 CreateSelfSignedCertificate(string subjectName, string password)
        {
            using (RSA rsa = RSA.Create(2048))
            {

                var cn = $"CN={subjectName}";
                var request = new CertificateRequest(new X500DistinguishedName(cn), rsa, HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);

                request.CertificateExtensions.Add(new X509BasicConstraintsExtension(false, false, 0, false));
                request.CertificateExtensions.Add(new X509KeyUsageExtension(X509KeyUsageFlags.DigitalSignature, false));
                request.CertificateExtensions.Add(new X509SubjectKeyIdentifierExtension(request.PublicKey, false));

                var certificate = request.CreateSelfSigned(DateTimeOffset.Now, DateTimeOffset.Now.AddYears(5));

                return new X509Certificate2(certificate.Export(X509ContentType.Pfx, password), password, X509KeyStorageFlags.PersistKeySet);
            }
        }

        /// <summary>
        /// Saves a certificate to a file.
        /// </summary>
        /// <param name="certificate">The certificate to save. Must not be null.</param>
        /// <param name="filePath">The file path where the certificate will be saved. Must not be null or empty.</param>
        /// <param name="password">The password to protect the certificate. Must not be null or empty.</param>
        /// <remarks>
        /// This method exports the certificate to a file in PFX format.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// CertificateHelpers.SaveCertificateToFile(certificate, "path/to/cert.pfx", "password");
        /// </code>
        /// </example>
        public static void SaveCertificateToFile(X509Certificate2 certificate, string filePath, string password)
        {
            File.WriteAllBytes(filePath, certificate.Export(X509ContentType.Pfx, password));
        }

        /// <summary>
        /// Stores a certificate in the certificate store.
        /// </summary>
        /// <param name="certificate">The certificate to store. Must not be null.</param>
        /// <remarks>
        /// This method adds the certificate to the appropriate certificate store based on the platform.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// CertificateHelpers.StoreCertificate(certificate);
        /// </code>
        /// </example>
        public static void StoreCertificate(X509Certificate2 certificate)
        {

            switch (Environment.OSVersion.Platform)
            {
                case PlatformID.Unix:
                    Unix.StoreCertificate(certificate);
                        break;
                
                case PlatformID.Win32Windows:
                case PlatformID.Win32NT:
                    Windows.StoreCertificate(certificate);
                        break;

                case PlatformID.Win32S:
                case PlatformID.WinCE:
                case PlatformID.Xbox:
                case PlatformID.MacOSX:
                case PlatformID.Other:
                default:
                    throw new PlatformNotSupportedException("The current platform is not supported for storing certificates.");
            }
        }



        /// <summary>
        /// Stores a certificate in the certificate store.
        /// </summary>
        public static class Windows
        {

            public static X509Certificate2 LoadCertificateFromStore(string subjectName)
            {
                using (var store = new X509Store(StoreName.My, StoreLocation.CurrentUser))
                {
                    store.Open(OpenFlags.ReadOnly);
                    var certs = store.Certificates.Find(X509FindType.FindBySubjectName, subjectName, false);
                    if (certs.Count > 0)
                    {
                        return certs[0];
                    }
                    else
                    {
                        throw new Exception($"Certificat avec le nom de sujet '{subjectName}' non trouvé dans le magasin.");
                    }
                }
            }

            public static void StoreCertificate(X509Certificate2 certificate)
            {
                using (var store = new X509Store(StoreName.My, StoreLocation.CurrentUser))
                {
                    store.Open(OpenFlags.ReadWrite);
                    store.Add(certificate);
                }
            }

        }

        public static class Unix
        {

            public static X509Certificate2 LoadCertificateFromStore(string subjectName)
            {
                using (var store = new X509Store(StoreName.My, StoreLocation.CurrentUser))
                {
                    store.Open(OpenFlags.ReadOnly);
                    var certs = store.Certificates.Find(X509FindType.FindBySubjectName, subjectName, false);
                    if (certs.Count > 0)
                    {
                        return certs[0];
                    }
                    else
                    {
                        throw new Exception($"Certificat avec le nom de sujet '{subjectName}' non trouvé dans le magasin.");
                    }
                }
            }

            public static void StoreCertificate(X509Certificate2 certificate)
            {
                using (var store = new X509Store(StoreName.My, StoreLocation.CurrentUser))
                {
                    store.Open(OpenFlags.ReadWrite);
                    store.Add(certificate);
                }
            }

        }
    }



}



