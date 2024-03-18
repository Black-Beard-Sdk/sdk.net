

namespace Bb.Http.Configuration
{
    /// <summary>
    /// Interface for defining a strategy for creating, caching, and reusing IFlurlClient instances and
    /// their underlying HttpClient instances. It is generally preferable to derive from FlurlClientFactoryBase
    /// and only override methods as needed, rather than implementing this interface from scratch.
    /// </summary>
    public interface IUrlClientFactory : IDisposable
	{
		/// <summary>
		/// Strategy to create a FlurlClient or reuse an existing one, based on the URL being called.
		/// </summary>
		/// <param name="url">The URL being called.</param>
		/// <returns></returns>
		IUrlClient Get(Url url);

		/// <summary>
		/// Defines how HttpClient should be instantiated and configured by default. Do NOT attempt
		/// to cache/reuse HttpClient instances here - that should be done at the FlurlClient level
		/// via a custom FlurlClientFactory that gets registered globally.
		/// </summary>
		/// <param name="handler">The HttpMessageHandler used to construct the HttpClient.</param>
		/// <returns></returns>
		HttpClient CreateHttpClient(HttpMessageHandler handler);

		/// <summary>
		/// Defines how the HttpMessageHandler used by HttpClients that are created by
		/// this factory should be instantiated and configured. 
		/// </summary>
		/// <returns></returns>
		HttpMessageHandler CreateMessageHandler();
	}
}