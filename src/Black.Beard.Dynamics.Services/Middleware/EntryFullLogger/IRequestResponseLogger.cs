namespace Bb.Middleware.EntryFullLogger
{

    /// <summary>
    /// Interface for logging HTTP request and response details.
    /// </summary>
    public interface IRequestResponseLogger
    {
        /// <summary>
        /// Logs the request and response details using the provided log model creator.
        /// </summary>
        /// <param name="logCreator">An instance of <see cref="IRequestResponseLogModelCreator"/> used to create the log model. Must not be null.</param>
        /// <remarks>
        /// This method captures and logs the details of HTTP requests and responses by utilizing the provided log model creator.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var logger = new MyRequestResponseLogger();
        /// var logCreator = new MyLogModelCreator();
        /// logger.Log(logCreator);
        /// </code>
        /// </example>
        void Log(IRequestResponseLogModelCreator logCreator);
    }

}
