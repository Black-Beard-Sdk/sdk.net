using Bb.Urls;
using RestSharp;

namespace Bb.Interfaces
{
    /// <summary>
    /// Represents a factory interface for creating <see cref="RestClient"/> instances.
    /// </summary>
    /// <remarks>
    /// This interface extends multiple <see cref="INamedFactory{TKey, TResult}"/> interfaces to provide mechanisms for creating <see cref="RestClient"/> instances 
    /// based on different types of keys, such as <see cref="Uri"/>, <see cref="string"/>, and <see cref="Url"/>.
    /// </remarks>
    /// <example>
    /// <code lang="C#">
    /// public class RestClientFactory : IRestClientFactory
    /// {
    ///     public RestClient Create(Uri uri)
    ///     {
    ///         return new RestClient(uri);
    ///     }
    ///
    ///     public RestClient Create(string name)
    ///     {
    ///         return new RestClient(new Uri($"https://api.example.com/{name}"));
    ///     }
    ///
    ///     public RestClient Create(Url url)
    ///     {
    ///         return new RestClient(url.Root);
    ///     }
    /// }
    /// </code>
    /// </example>
    public interface IRestClientFactory 
        : INamedFactory<Uri, RestClient>
        , INamedFactory<string, RestClient>
        , INamedFactory<Url, RestClient>
    {
    }
}
