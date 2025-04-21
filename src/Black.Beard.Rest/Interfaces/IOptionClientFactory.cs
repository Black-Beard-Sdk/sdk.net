using RestSharp;

namespace Bb.Interfaces
{
    /// <summary>
    /// Represents a factory interface for creating <see cref="RestClientOptions"/> instances using a string key.
    /// </summary>
    /// <remarks>
    /// This interface extends <see cref="INamedFactory{TKey, TResult}"/> to provide a mechanism for creating <see cref="RestClientOptions"/> based on a string key.
    /// </remarks>
    /// <example>
    /// <code lang="C#">
    /// public class OptionClientFactory : IOptionClientFactory
    /// {
    ///     public RestClientOptions Create(string name)
    ///     {
    ///         // Example implementation
    ///         return new RestClientOptions { BaseUrl = new Uri($"https://api.example.com/{name}") };
    ///     }
    /// }
    /// </code>
    /// </example>
    public interface IOptionClientFactory
        : INamedFactory<string, RestClientOptions>
    {

        /// <summary>
        /// Gets or sets an interceptor for modifying the <see cref="RestClientOptions"/> before use.
        /// </summary>
        Action<RestClientOptions> Interceptor { get; set; }


    }

}
