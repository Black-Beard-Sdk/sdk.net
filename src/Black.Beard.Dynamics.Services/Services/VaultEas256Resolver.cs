using Bb;
using Bb.Interfaces;

namespace Bb.Services
{

    public class VaultEas256Resolver : IVaultSecretResolver
    {

        public VaultEas256Resolver(IConfiguration configuration)
        {
            _secret = configuration[_secretNameConfiguration];
        }

        public string GetSecret(params string[] path)
        {

            if (string.IsNullOrEmpty(_secret))
                throw new InvalidOperationException($"The secret must be provided. Initialize value {_secretNameConfiguration}.");
            
            var secretName = string.Join("/", path);

            return secretName.DecryptStringAes256(_secret);

        }

        private const string _secretNameConfiguration = "VaultEasResolver";

        private readonly string _secret;


    }

}



