using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography;

namespace Bb.Services
{
    public static class CertificateHelpers
    {


        public static X509Certificate2 LoadCertificateFromFile(FileInfo certPath, string certPassword)
        {
            return new X509Certificate2(certPath.FullName, certPassword);
        }

        public static X509Certificate2 LoadCertificateFromStore(string subjectName)
        {
            return Environment.OSVersion.Platform switch
            {
                PlatformID.Win32NT => Windows.LoadCertificateFromStore(subjectName),
                PlatformID.Unix => Unix.LoadCertificateFromStore(subjectName),
                _ => throw new PlatformNotSupportedException()
            };
        }


        


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

        public static void SaveCertificateToFile(X509Certificate2 certificate, string filePath, string password)
        {
            File.WriteAllBytes(filePath, certificate.Export(X509ContentType.Pfx, password));
        }

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
                    break;
            }
        }



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



