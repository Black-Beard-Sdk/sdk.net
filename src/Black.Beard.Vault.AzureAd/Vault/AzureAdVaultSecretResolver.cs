using Azure.Identity;
using Azure.Security.KeyVault.Secrets;
using Bb.ComponentModel;
using Bb.ComponentModel.Attributes;
using Bb.Interfaces;
using Microsoft.Extensions.Configuration;

namespace Bb.Vault
{

    [ExposeClass(ConstantsCore.Service, ExposedType = typeof(IVaultSecretResolver), LifeCycle = IocScope.Singleton)]
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

            if (configuration.GetValue("AzureKeyVault:VaultUri", out string uri)
             && configuration.GetValue("AzureKeyVault:ClientId", out string clientId)
             && configuration.GetValue("AzureKeyVault:ClientSecret", out string clientSecret)
             && configuration.GetValue("AzureKeyVault:TenantId", out string tenantId))
                {
                    var vaultUri = new Uri(uri);
                    var credential = new ClientSecretCredential(tenantId, clientId, clientSecret);
                    _secretClient = new SecretClient(vaultUri, credential);
                }
        }

        public string? GetSecret(params string[] path)
        {
            if (path == null || path.Length == 0)
                throw new ArgumentException("Secret name must be provided", nameof(path));

            var secretName = string.Join("/", path);
            KeyVaultSecret secret = _secretClient.GetSecret(secretName);

            return secret.Value;
        }

        private readonly SecretClient _secretClient;        

    }

    internal static class Extensions
    {

        public static bool GetValue(this IConfiguration configuration, string name, out string result)
        {
            var r = configuration[name];
            if (string.IsNullOrEmpty(r))
                throw new InvalidOperationException("Configuration is not set " + name);
            result = r;
            return true;
        }

    }

}


