namespace Bb.Interfaces
{


    /// <summary>
    /// Interface for resolving and retrieving secrets from a vault or secure storage.
    /// </summary>
    public interface IVaultSecretResolver
    {

        /// <summary>
        /// Retrieves a secret value based on the provided names.
        /// </summary>
        /// <param name="path">An array of strings representing the names or keys to locate the secret. Must not be null or empty.</param>
        /// <returns>The secret value as a <see cref="string"/>.</returns>
        /// <remarks>
        /// This method resolves and retrieves a secret value from a vault or secure storage using the provided names or keys.
        /// </remarks>
        /// <exception cref="ArgumentNullException">
        /// Thrown if the provided <paramref name="path"/> is null or empty.
        /// </exception>
        /// <example>
        /// <code lang="C#">
        /// IVaultSecretResolver resolver = new MyVaultSecretResolver();
        /// string secret = resolver.GetSecret("Database", "ConnectionString");
        /// Console.WriteLine($"Retrieved secret: {secret}");
        /// </code>
        /// </example>
        string? GetSecret(params string[] path);

    }


}
