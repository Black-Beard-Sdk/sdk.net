namespace Bb.Middleware.EntryFullLogger
{

    /// <summary>
    /// Interface for creating a log model that contains details of HTTP requests and responses.
    /// </summary>
    public interface IRequestResponseLogModelCreator
    {

        /// <summary>
        /// Gets the log model containing the details of the request and response.
        /// </summary>
        /// <value>A <see cref="RequestResponseLogModel"/> object representing the log details.</value>
        /// <remarks>
        /// This property provides access to the log model that encapsulates the details of the HTTP request and response.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var logCreator = new MyRequestResponseLogModelCreator();
        /// var logModel = logCreator.LogModel;
        /// Console.WriteLine($"Request: {logModel.Request}, Response: {logModel.Response}");
        /// </code>
        /// </example>
        RequestResponseLogModel LogModel { get; }
        
        /// <summary>
        /// Generates a string representation of the log model.
        /// </summary>
        /// <returns>A <see cref="string"/> containing the serialized log details.</returns>
        /// <remarks>
        /// This method converts the log model into a string format for logging or debugging purposes.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var logCreator = new MyRequestResponseLogModelCreator();
        /// string logString = logCreator.LogString();
        /// Console.WriteLine($"Log: {logString}");
        /// </code>
        /// </example>
        string LogString();

    }


}
