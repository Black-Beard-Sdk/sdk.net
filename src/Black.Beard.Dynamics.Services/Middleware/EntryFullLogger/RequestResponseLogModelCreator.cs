using Bb.ComponentModel;
using Bb.ComponentModel.Attributes;


namespace Bb.Middleware.EntryFullLogger
{

    /// <summary>
    /// Represents a factory for creating request and response log models.
    /// </summary>
    [ExposeClass(Context = ConstantsCore.Service, ExposedType = typeof(IRequestResponseLogModelCreator), LifeCycle = IocScopeEnum.Singleton)]
    public class RequestResponseLogModelCreator : IRequestResponseLogModelCreator
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestResponseLogModelCreator"/> class.
        /// </summary>
        /// <remarks>
        /// This constructor initializes the log model creator with a new instance of <see cref="RequestResponseLogModel"/> to capture request and response details.
        /// </remarks>
        public RequestResponseLogModelCreator()
        {
            LogModel = new RequestResponseLogModel();
        }

        /// <summary>
        /// Gets the log model containing the details of the request and response.
        /// </summary>
        /// <value>A <see cref="RequestResponseLogModel"/> object representing the log details.</value>
        /// <remarks>
        /// This property provides access to the log model that encapsulates the details of the HTTP request and response.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var logModelCreator = new RequestResponseLogModelCreator();
        /// var logModel = logModelCreator.LogModel;
        /// Console.WriteLine($"Log ID: {logModel.LogId}");
        /// </code>
        /// </example>
        public RequestResponseLogModel LogModel { get; private set; }

        /// <summary>
        /// Generates a string representation of the log model.
        /// </summary>
        /// <returns>A <see cref="string"/> containing the serialized log details.</returns>
        /// <remarks>
        /// This method serializes the log model into a JSON string for logging or debugging purposes.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var logModelCreator = new RequestResponseLogModelCreator();
        /// string logString = logModelCreator.LogString();
        /// Console.WriteLine($"Serialized Log: {logString}");
        /// </code>
        /// </example>
        public string LogString()
        {
            var jsonString = LogModel.Serialize(true);
            return jsonString;
        }

    }


}
