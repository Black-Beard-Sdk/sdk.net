

namespace Bb.Http.Content
{
	/// <summary>
	/// Provides HTTP content based on a serialized JSON object, with the JSON string captured to a property
	/// so it can be read without affecting the read-once content stream.
	/// </summary>
	public class CapturedObjectContent : CapturedStringContent
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="CapturedObjectContent"/> class.
		/// </summary>
		/// <param name="json">The json.</param>
		public CapturedObjectContent(string json) : base(json, "application/json; charset=UTF-8") { }
	}
}