// Ignore Spelling: Eas

using Bb;
using Bb.Interfaces;

namespace Bb.Services
{

    /// <summary>
    /// Initializer
    /// </summary>
    /// <param name="configuration"></param>
    public class VaultEas256Resolver(IConfiguration configuration) : IVaultSecretResolver
    {

        /// <summary>
        /// Retrieves a secret from the vault using the specified path.
        /// </summary>
        /// <param name="path">The path segments used to locate the secret. Must not be null or empty.</param>
        /// <returns>The decrypted secret as a string.</returns>
        /// <remarks>
        /// This method retrieves a secret from the vault by combining the provided path segments and decrypting the result using AES-256 encryption.
        /// </remarks>
        /// <exception cref="InvalidOperationException">
        /// Thrown if the secret is not initialized.
        /// </exception>
        /// <example>
        /// <code lang="C#">
        /// var resolver = new VaultEas256Resolver(configuration);
        /// var secret = resolver.GetSecret("path", "to", "secret");
        /// </code>
        /// </example>
        public string GetSecret(params string[] path)
        {
            if (string.IsNullOrEmpty(_secret))
                throw new InvalidOperationException($"The secret must be provided. Initialize value {_secretNameConfiguration}.");
            
            var secretName = string.Join("/", path);

            return secretName.DecryptStringAes256(_secret);
        }

        /// <summary>
        /// Gets the configuration key used to retrieve the secret.
        /// </summary>
        /// <value>A constant string representing the configuration key.</value>
        /// <remarks>
        /// This property provides the name of the configuration key used to initialize the secret.
        /// </remarks>
        private const string _secretNameConfiguration = "VaultEasResolver";

        /// <summary>
        /// Gets the secret value from the configuration.
        /// </summary>
        /// <value>A string representing the secret value.</value>
        /// <remarks>
        /// This field holds the secret value retrieved from the configuration using the key <see cref="_secretNameConfiguration"/>.
        /// </remarks>
        private readonly string _secret = configuration[_secretNameConfiguration];

    }

}



