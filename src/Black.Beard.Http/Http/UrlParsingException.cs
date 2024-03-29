﻿namespace Bb.Http
{
    /// <summary>
    /// An exception that is thrown when an HTTP response could not be parsed to a particular format.
    /// </summary>
    public class UrlParsingException : UrlHttpException
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="UrlParsingException"/> class.
		/// </summary>
		/// <param name="call">Details of the HTTP call that caused the exception.</param>
		/// <param name="expectedFormat">The format that could not be parsed to, i.e. JSON.</param>
		/// <param name="inner">The inner exception.</param>
		public UrlParsingException(UrlCall call, string expectedFormat, Exception inner) : base(call, BuildMessage(call, expectedFormat), inner) {
			ExpectedFormat = expectedFormat;
		}

		/// <summary>
		/// The format that could not be parsed to, i.e. JSON.
		/// </summary>
		public string ExpectedFormat { get; }

		private static string BuildMessage(UrlCall call, string expectedFormat) {
			var msg = $"Response could not be deserialized to {expectedFormat}";
			return msg + ((call == null) ? "." : $": {call}");
		}
	}
}