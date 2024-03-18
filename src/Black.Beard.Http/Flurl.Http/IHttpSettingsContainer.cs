using Bb.Http.Configuration;
using Bb.Util;

namespace Bb.Http
{
	/// <summary>
	/// Defines stateful aspects (headers, cookies, etc) common to both IFlurlClient and IFlurlRequest
	/// </summary>
	public interface IHttpSettingsContainer
	{
	    /// <summary>
	    /// Gets the FlurlHttpSettings object used by this client or request.
	    /// </summary>
	    UrlHttpSettings Settings { get; }

		/// <summary>
		/// Collection of headers sent on this request or all requests using this client.
		/// </summary>
		INameValueList<string> Headers { get; }
    }
}
