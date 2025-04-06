namespace Bb.Models
{

    /// <summary>
    /// Represents the options for configuring a REST client.
    /// </summary>
    public class RestClientOptions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestClientOptions"/> class.
        /// </summary>
        /// <remarks>
        /// This constructor initializes the RestClientOptions with default values, including an empty list of client option configurations.
        /// </remarks>
        public RestClientOptions()
        {
            this.Options = new List<ClientOptionConfiguration>();
        }

        /// <summary>
        /// Gets or sets a value indicating whether an API key should be used for authentication.
        /// </summary>
        /// <value><see langword="true"/> if an API key should be used; otherwise, <see langword="false"/>.</value>
        /// <remarks>
        /// This property determines whether the client will use an API key for authentication when making requests.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var options = new RestClientOptions();
        /// options.UseApiKey = true;
        /// Console.WriteLine($"Use API Key: {options.UseApiKey}");
        /// </code>
        /// </example>
        public bool UseApiKey { get; set; } = false;

        /// <summary>
        /// Gets or sets a value indicating whether the client is activated.
        /// </summary>
        /// <value><see langword="true"/> if the client is activated; otherwise, <see langword="false"/>.</value>
        /// <remarks>
        /// This property determines whether the client is enabled and can make requests.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var options = new RestClientOptions();
        /// options.ClientActivated = true;
        /// Console.WriteLine($"Client Activated: {options.ClientActivated}");
        /// </code>
        /// </example>
        public bool ClientActivated { get; set; } = true;

        /// <summary>
        /// Gets or sets the URL used to obtain a token for authentication.
        /// </summary>
        /// <value>A <see cref="string"/> representing the token URL.</value>
        /// <remarks>
        /// This property specifies the endpoint used to retrieve an authentication token for the client.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var options = new RestClientOptions();
        /// options.TokenUrl = "https://example.com/token";
        /// Console.WriteLine($"Token URL: {options.TokenUrl}");
        /// </code>
        /// </example>
        public string TokenUrl { get; set; }

        /// <summary>
        /// Gets or sets the client ID used for token authentication.
        /// </summary>
        /// <value>A <see cref="string"/> representing the client ID.</value>
        /// <remarks>
        /// This property specifies the client ID required to authenticate with the token endpoint.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var options = new RestClientOptions();
        /// options.TokenClientId = "my-client-id";
        /// Console.WriteLine($"Token Client ID: {options.TokenClientId}");
        /// </code>
        /// </example>
        public string TokenClientId { get; set; }

        /// <summary>
        /// Gets or sets the client secret used for token authentication.
        /// </summary>
        /// <value>A <see cref="string"/> representing the client secret.</value>
        /// <remarks>
        /// This property specifies the client secret required to authenticate with the token endpoint.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var options = new RestClientOptions();
        /// options.TokenClientSecret = "my-client-secret";
        /// Console.WriteLine($"Token Client Secret: {options.TokenClientSecret}");
        /// </code>
        /// </example>
        public string TokenClientSecret { get; set; }

        /// <summary>
        /// Gets or sets the list of client option configurations.
        /// </summary>
        /// <value>A <see cref="List{T}"/> of <see cref="ClientOptionConfiguration"/> objects.</value>
        /// <remarks>
        /// This property contains the configurations for multiple clients that can be used by the RestClient.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var options = new RestClientOptions();
        /// options.Options.Add(new ClientOptionConfiguration { Name = "Client1" });
        /// Console.WriteLine($"Number of client options: {options.Options.Count}");
        /// </code>
        /// </example>
        public List<ClientOptionConfiguration> Options { get; set; }
    }
}
