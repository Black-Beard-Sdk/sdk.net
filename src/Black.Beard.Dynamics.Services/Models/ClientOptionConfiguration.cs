using Bb.Services;

namespace Bb.Models
{

    /// <summary>
    /// Represents a client option configuration for REST clients.
    /// </summary>
    public class ClientOptionConfiguration : ClientRestOption
    {

        /// <summary>
        /// Gets or sets the name of the client option configuration.
        /// </summary>
        /// <value>A <see cref="string"/> representing the name of the configuration.</value>
        /// <remarks>
        /// This property is used to identify the specific client option configuration in the application.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var clientOption = new ClientOptionConfiguration();
        /// clientOption.Name = "MyClientOption";
        /// Console.WriteLine($"Client Option Name: {clientOption.Name}");
        /// </code>
        /// </example>
        public string Name { get; set; }

    }



}
