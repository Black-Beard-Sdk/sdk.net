using Bb.ComponentModel.Attributes;
using Bb.ComponentModel;
using Bb.Interfaces;
using VaultSharp;
using VaultSharp.V1.AuthMethods.Token;
using VaultSharp.V1.Commons;

namespace Black.Beard.Vault.VaultSharp.Vault
{

    [ExposeClass(ConstantsCore.Service, ExposedType = typeof(IVaultSecretResolver), LifeCycle = IocScopeEnum.Singleton)]
    public class VaultSharpSecretResolver : IVaultSecretResolver
    {

        public VaultSharpSecretResolver(string vaultAddress, string token)
        {
            var authMethod = new TokenAuthMethodInfo(token);
            var vaultClientSettings = new VaultClientSettings(vaultAddress, authMethod);
            _vaultClient = new VaultClient(vaultClientSettings);
        }
        
        public string GetSecret(params string[] path)
        {

            string secretPath = string.Empty;
            string secretKey = string.Empty;

            var secretName = string.Join("/", path);
            var path2 = secretName.Split('/');

            if (path2.Length > 1)
                secretPath = string.Join("/", path2.Take(path2.Length - 2));

            secretKey = path2[path2.Length - 1];

            var query = _vaultClient.V1.Secrets.KeyValue.V2.ReadSecretAsync(secretPath);
            Secret<SecretData> secret = query.Result;
            
            return secret.Data.Data[secretKey].ToString();

        }

        private readonly VaultClient _vaultClient;

    }
}
