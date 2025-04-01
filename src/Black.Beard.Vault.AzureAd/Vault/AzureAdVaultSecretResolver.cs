using Azure.Identity;
using Azure.Security.KeyVault.Secrets;
using Bb.ComponentModel;
using Bb.ComponentModel.Attributes;
using Bb.Interfaces;
using Microsoft.Extensions.Configuration;

namespace Bb.Vault
{

    [ExposeClass(ConstantsCore.Service, ExposedType = typeof(IVaultSecretResolver), LifeCycle = IocScopeEnum.Singleton)]
    public class AzureAdVaultSecretResolver : IVaultSecretResolver
    {


        /// <summary>
        /// Get the secret from the vault
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        /// <remarks>
        /// The configuration file should be like this:
        /// 
        /// <code lang="json">
        /// {
        ///   "AzureKeyVault": 
        ///   {
        ///     "VaultUri": "https://your-vault-name.vault.azure.net/",
        ///     "ClientId": "your-client-id",
        ///     "ClientSecret": "your-client-secret",
        ///     "TenantId": "your-tenant-id"
        ///   }
        /// }
        /// </code
        /// 
        /// </remarks>
        /// <exception cref="NotImplementedException"></exception>

        public AzureAdVaultSecretResolver(IConfiguration configuration)
        {
            var vaultUri = new Uri(configuration["AzureKeyVault:VaultUri"]);
            var clientId = configuration["AzureKeyVault:ClientId"];
            var clientSecret = configuration["AzureKeyVault:ClientSecret"];
            var tenantId = configuration["AzureKeyVault:TenantId"];

            var credential = new ClientSecretCredential(tenantId, clientId, clientSecret);
            _secretClient = new SecretClient(vaultUri, credential);
        }

        public string GetSecret(params string[] name)
        {
            if (name == null || name.Length == 0)
                throw new ArgumentException("Secret name must be provided", nameof(name));

            var secretName = string.Join("/", name);
            KeyVaultSecret secret = _secretClient.GetSecret(secretName);

            return secret.Value;
        }

        private readonly SecretClient _secretClient;

    }

}


