namespace Bb.Exceptions
{

    /// <summary>
    /// Represents an exception that is thrown when a required certificate cannot be found.
    /// </summary>
    /// <remarks>
    /// This exception is used to indicate issues related to missing certificates in the application.
    /// </remarks>
    [Serializable]
    public class CertificateNotFoundException : Exception
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="CertificateNotFoundException"/> class.
        /// </summary>
        public CertificateNotFoundException() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="CertificateNotFoundException"/> class with a specified error message.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        /// <remarks>
        /// Use this constructor to provide a custom error message when the exception is thrown.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// throw new CertificateNotFoundException("Certificate with ID 1234 not found.");
        /// </code>
        /// </example>
        public CertificateNotFoundException(string message) : base(message) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="CertificateNotFoundException"/> class with a specified error message and a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        /// <param name="inner">The exception that is the cause of the current exception.</param>
        /// <remarks>
        /// Use this constructor to provide additional context about the error by including an inner exception.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// try
        /// {
        ///     // Some operation that may fail
        /// }
        /// catch (Exception ex)
        /// {
        ///     throw new CertificateNotFoundException("Certificate operation failed.", ex);
        /// }
        /// </code>
        /// </example>
        /// <exception cref="ArgumentNullException">Thrown if <paramref name="message"/> is null.</exception>
        public CertificateNotFoundException(string message, Exception inner) : base(message, inner) { }

    }


}
