using Bb.Interfaces;
using Bb.Urls;
using RestSharp;
using System.Collections.Concurrent;

namespace Bb.Services
{

    /// <summary>
    /// Factory class for creating instances of <see cref="RestClient"/> with a specified base URL.
    /// </summary>
    public class RestClientFactory : IRestClientFactory
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="RestClientFactory"/> class.
        /// </summary>
        /// <param name="optionFactory">The <see cref="IOptionClientFactory"/> instance used to create client options. Must not be null.</param>
        /// <param name="factory">The <see cref="IHttpClientFactory"/> instance used to create client http.</param>
        /// <remarks>
        /// This constructor initializes the factory with the specified option factory for creating <see cref="RestClientOptions"/>.
        /// </remarks>
        /// <exception cref="NullReferenceException">
        /// Thrown if <paramref name="optionFactory"/> is null.
        /// </exception>
        public RestClientFactory(IOptionClientFactory? optionFactory, IHttpClientFactory? factory)
        {
            _optionFactory = optionFactory ?? GlobalSettings.OptionFactory ?? throw new ArgumentNullException("optionFactory");
            _factory = factory;
        }

        /// <summary>
        /// Creates a <see cref="RestClient"/> instance using the specified base URL.
        /// </summary>
        /// <param name="baseUrl">The base URL for the REST client. Must not be null.</param>
        /// <returns>A <see cref="RestClient"/> instance configured with the specified base URL.</returns>
        /// <remarks>
        /// This method retrieves or creates a <see cref="RestClient"/> instance for the specified base URL. 
        /// If a client for the URL already exists, it is reused.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var factory = new RestClientFactory(optionFactory);
        /// var client = factory.Create(new Uri("https://example.com"));
        /// </code>
        /// </example>
        public RestClient Create(Uri baseUrl)
        {
            var url = new Url(baseUrl).Root;
            RestClient client = CreateImpl(url);
            return client;
        }

        /// <summary>
        /// Creates a <see cref="RestClient"/> instance using the specified name or URL.
        /// </summary>
        /// <param name="name">The name or URL for the REST client. Must not be null or empty.</param>
        /// <returns>A <see cref="RestClient"/> instance configured with the specified name or URL.</returns>
        /// <remarks>
        /// This method retrieves or creates a <see cref="RestClient"/> instance for the specified name or URL. 
        /// If a client for the URL already exists, it is reused.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var factory = new RestClientFactory(optionFactory);
        /// var client = factory.Create("https://example.com");
        /// </code>
        /// </example>
        public RestClient Create(string name)
        {
            var url = new Url(name).Root;
            RestClient client = CreateImpl(url);
            return client;
        }

        /// <summary>
        /// Creates a <see cref="RestClient"/> instance using the specified <see cref="Url"/>.
        /// </summary>
        /// <param name="name">The <see cref="Url"/> instance for the REST client. Must not be null.</param>
        /// <returns>A <see cref="RestClient"/> instance configured with the specified <see cref="Url"/>.</returns>
        /// <remarks>
        /// This method retrieves or creates a <see cref="RestClient"/> instance for the specified <see cref="Url"/>. 
        /// If a client for the URL already exists, it is reused.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var factory = new RestClientFactory(optionFactory);
        /// var client = factory.Create(new Url("https://example.com"));
        /// </code>
        /// </example>
        public RestClient Create(Url name)
        {
            var url = name.Root;
            RestClient client = CreateImpl(url);
            return client;
        }


        private RestClient CreateImpl(string url)
        {

            RestClient client;

            var options = _optionFactory.Create(url);

            if (_factory == null)
                client = new RestClient(options, null, null, true);
            else
                client = new RestClient(_factory.CreateClient(url), options, true);

            return client; 

        }

        private readonly IOptionClientFactory _optionFactory;
        private readonly IHttpClientFactory? _factory;
    }

}
