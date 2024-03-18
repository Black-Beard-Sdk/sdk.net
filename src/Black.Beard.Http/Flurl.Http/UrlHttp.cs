using Bb.Http.Configuration;

namespace Bb.Http
{
	/// <summary>
	/// A static container for global configuration settings affecting Flurl.Http behavior.
	/// </summary>
	public static class UrlHttp
	{
		private static readonly object _configLock = new object();

		private static Lazy<GlobalUrlHttpSettings> _settings =
			new Lazy<GlobalUrlHttpSettings>(() => new GlobalUrlHttpSettings());

		/// <summary>
		/// Globally configured Flurl.Http settings. Should normally be written to by calling FlurlHttp.Configure once application at startup.
		/// </summary>
		public static GlobalUrlHttpSettings GlobalSettings => _settings.Value;

		/// <summary>
		/// Provides thread-safe access to Flurl.Http's global configuration settings. Should only be called once at application startup.
		/// </summary>
		/// <param name="configAction">the action to perform against the GlobalSettings.</param>
		public static void Configure(Action<GlobalUrlHttpSettings> configAction) {
			lock (_configLock) {
				configAction(GlobalSettings);
			}
		}

		/// <summary>
		/// Provides thread-safe access to a specific IFlurlClient, typically to configure settings and default headers.
		/// The URL is used to find the client, but keep in mind that the same client will be used in all calls to the same host by default.
		/// </summary>
		/// <param name="url">the URL used to find the IFlurlClient.</param>
		/// <param name="configAction">the action to perform against the IFlurlClient.</param>
		public static void ConfigureClient(string url, Action<IUrlClient> configAction) => 
			GlobalSettings.FlurlClientFactory.ConfigureClient(url, configAction);
	}
}