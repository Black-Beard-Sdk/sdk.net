namespace Bb.Exceptions
{
	/// <summary>
	/// Represents an exception that is thrown when a required variable is missing.
	/// </summary>
	[Serializable]
	public class MissingVariableException : Exception
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="MissingVariableException"/> class.
		/// </summary>
		/// <remarks>
		/// This constructor creates an exception without any additional context or message.
		/// </remarks>
		public MissingVariableException() { }

		/// <summary>
		/// Initializes a new instance of the <see cref="MissingVariableException"/> class with a specified error message.
		/// </summary>
		/// <param name="message">List of variable not found.</param>
		/// <remarks>
		/// Use this constructor to provide a custom error message when throwing the exception.
		/// </remarks>
		/// <example>
		/// <code lang="C#">
		/// throw new MissingVariableException("The required variable 'X' is missing.");
		/// </code>
		/// </example>
		public MissingVariableException(string message) : base($"The variables are not found ({message})") { }

		/// <summary>
		/// Initializes a new instance of the <see cref="MissingVariableException"/> class with a specified error message and a reference to the inner exception that is the cause of this exception.
		/// </summary>
		/// <param name="message">The message that describes the error.</param>
		/// <param name="inner">The exception that is the cause of the current exception.</param>
		/// <remarks>
		/// Use this constructor to provide additional context by including an inner exception.
		/// </remarks>
		/// <example>
		/// <code lang="C#">
		/// try
		/// {
		///     // Some operation that causes an exception
		/// }
		/// catch (Exception ex)
		/// {
		///     throw new MissingVariableException("A required variable is missing.", ex);
		/// }
		/// </code>
		/// </example>
		public MissingVariableException(string message, Exception inner) : base(message, inner) { }

    }
}
