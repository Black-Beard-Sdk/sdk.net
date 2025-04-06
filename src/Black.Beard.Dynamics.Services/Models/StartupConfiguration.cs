using Bb.ComponentModel.Attributes;
using Bb.ComponentModel;
using Bb.Loaders.Extensions;

namespace Bb.Models
{


    /// <summary>
    /// Represents the startup configuration for the application.
    /// </summary>
    [ExposeClass(ConstantsCore.Configuration, LifeCycle = IocScopeEnum.Singleton)]
    public class StartupConfiguration
    {

        public StartupConfiguration()
        {
            BearerOptions = new List<BearerOption>();
            this.PolicyFiles = new HashSet<string>();
            this.RestClient = new RestClientOptions();
            this.Packages = new Packages();
            this.Folders = new HashSet<string>();
            this.AssemblyNames = new HashSet<string>();
        }

        /// <summary>
        /// Gets or sets a value indicating whether exceptions should be logged.
        /// </summary>
        /// <value>A boolean value indicating whether exception logging is enabled. Default is <c>true</c>.</value>
        /// <remarks>
        /// This property determines if exceptions encountered during application execution should be logged.
        /// </remarks>
        public bool LogExceptions { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether informational messages should be logged.
        /// </summary>
        /// <value>A boolean value indicating whether informational logging is enabled. Default is <c>true</c>.</value>
        /// <remarks>
        /// This property determines if informational messages should be logged during application execution.
        /// </remarks>
        public bool LogInfo { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether static files should be served.
        /// </summary>
        /// <value>A boolean value indicating whether static file serving is enabled. Default is <c>false</c>.</value>
        /// <remarks>
        /// This property determines if the application should serve static files.
        /// </remarks>
        public bool UseStaticFiles { get; set; } = false;

        /// <summary>
        /// Gets or sets a value indicating whether routing is enabled.
        /// </summary>
        /// <value>A boolean value indicating whether routing is enabled. Default is <c>true</c>.</value>
        /// <remarks>
        /// This property determines if the application should use routing for request handling.
        /// </remarks>
        public bool UseRouting { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether the Blazor hub should be mapped.
        /// </summary>
        /// <value>A boolean value indicating whether Blazor hub mapping is enabled. Default is <c>false</c>.</value>
        /// <remarks>
        /// This property determines if the application should map the Blazor hub for SignalR communication.
        /// </remarks>
        public bool MapBlazorHub { get; set; } = false;

        /// <summary>
        /// Gets or sets the fallback page for routing.
        /// </summary>
        /// <value>A string representing the fallback page path.</value>
        /// <remarks>
        /// This property specifies the fallback page to use when no other route matches.
        /// </remarks>
        public string MapFallbackToPage { get; set; }

        /// <summary>
        /// Gets or sets the HTTPS certificate configuration.
        /// </summary>
        /// <value>A <see cref="Certificate"/> object representing the HTTPS certificate configuration.</value>
        /// <remarks>
        /// This property holds the configuration for the HTTPS certificate used by the application.
        /// </remarks>
        public Certificate HttpsCertificate { get; set; }

        /// <summary>
        /// Gets or sets the list of bearer token options.
        /// </summary>
        /// <value>A list of <see cref="BearerOption"/> objects representing the bearer token options.</value>
        /// <remarks>
        /// This property contains the configuration for bearer token authentication.
        /// </remarks>
        public List<BearerOption> BearerOptions { get; set; }

        /// <summary>
        /// Gets or sets the collection of policy file paths.
        /// </summary>
        /// <value>A <see cref="HashSet{T}"/> of strings representing the policy file paths.</value>
        /// <remarks>
        /// This property holds the paths to policy files used for application configuration.
        /// </remarks>
        public HashSet<string> PolicyFiles { get; set; }

        /// <summary>
        /// Gets or sets the REST client options.
        /// </summary>
        /// <value>A <see cref="RestClientOptions"/> object representing the REST client configuration.</value>
        /// <remarks>
        /// This property contains the configuration options for REST client usage.
        /// </remarks>
        public RestClientOptions RestClient { get; set; }

        /// <summary>
        /// Gets or sets the collection of NuGet package configurations.
        /// </summary>
        /// <value>A <see cref="Packages"/> object representing the NuGet package configurations.</value>
        /// <remarks>
        /// This property holds the configuration for NuGet packages used by the application.
        /// </remarks>
        public Packages Packages { get; set; }

        /// <summary>
        /// Gets or sets the collection of folder paths.
        /// </summary>
        /// <value>A <see cref="HashSet{T}"/> of strings representing the folder paths.</value>
        /// <remarks>
        /// This property contains the paths to folders used by the application.
        /// </remarks>
        public HashSet<string> Folders { get; set; }

        /// <summary>
        /// Gets or sets the collection of assembly names.
        /// </summary>
        /// <value>A <see cref="HashSet{T}"/> of strings representing the assembly names.</value>
        /// <remarks>
        /// This property holds the names of assemblies used by the application.
        /// </remarks>
        public HashSet<string> AssemblyNames { get; set; }

    }

}
