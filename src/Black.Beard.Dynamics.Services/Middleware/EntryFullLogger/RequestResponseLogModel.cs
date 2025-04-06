namespace Bb.Middleware.EntryFullLogger
{

    public class RequestResponseLogModel
    {

        /// <summary>
        /// Gets or sets the unique identifier for the log entry.
        /// </summary>
        /// <value>A <see cref="string"/> representing the unique log identifier.</value>
        /// <remarks>
        /// This property is automatically initialized with a new GUID when the log model is created.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var logModel = new RequestResponseLogModel();
        /// Console.WriteLine($"Log ID: {logModel.LogId}");
        /// </code>
        /// </example>
        public string LogId { get; set; }           /*Guid.NewGuid().ToString()*/

        /// <summary>
        /// Gets or sets the name of the node or project associated with the log entry.
        /// </summary>
        /// <value>A <see cref="string"/> representing the node or project name.</value>
        /// <remarks>
        /// This property is used to identify the source of the log entry, such as the project or application name.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var logModel = new RequestResponseLogModel();
        /// logModel.Node = "MyProject";
        /// Console.WriteLine($"Node: {logModel.Node}");
        /// </code>
        /// </example>
        public string Node { get; set; }            /*project name*/

        /// <summary>
        /// Gets or sets the client IP address associated with the request.
        /// </summary>
        /// <value>A <see cref="string"/> representing the client IP address.</value>
        /// <remarks>
        /// This property captures the IP address of the client making the HTTP request.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var logModel = new RequestResponseLogModel();
        /// logModel.ClientIp = "192.168.1.1";
        /// Console.WriteLine($"Client IP: {logModel.ClientIp}");
        /// </code>
        /// </example>
        public string ClientIp { get; set; }

        /// <summary>
        /// Gets or sets the trace identifier for the request.
        /// </summary>
        /// <value>A <see cref="string"/> representing the trace identifier.</value>
        /// <remarks>
        /// This property is typically populated with the <c>HttpContext.TraceIdentifier</c> value to correlate logs with specific requests.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var logModel = new RequestResponseLogModel();
        /// logModel.TraceId = "abc123";
        /// Console.WriteLine($"Trace ID: {logModel.TraceId}");
        /// </code>
        /// </example>
        public string TraceId { get; set; }         /*HttpContext TraceIdentifier*/


        /// <summary>
        /// Gets or sets the UTC timestamp of when the request was received.
        /// </summary>
        /// <value>A <see cref="DateTime?"/> representing the request timestamp in UTC.</value>
        /// <remarks>
        /// This property records the time the HTTP request was received by the server.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var logModel = new RequestResponseLogModel();
        /// logModel.RequestDateTimeUtc = DateTime.UtcNow;
        /// Console.WriteLine($"Request Time: {logModel.RequestDateTimeUtc}");
        /// </code>
        /// </example>
        public DateTime? RequestDateTimeUtc { get; set; }

        /// <summary>
        /// Gets or sets the UTC timestamp of when the request was received at the action level.
        /// </summary>
        public DateTime? RequestDateTimeUtcActionLevel { get; set; }

        /// <summary>
        /// Gets or sets the path of the HTTP request.
        /// </summary>
        public string RequestPath { get; set; }

        /// <summary>
        /// Gets or sets the query string of the HTTP request.
        /// </summary>
        public string RequestQuery { get; set; }

        /// <summary>
        /// Gets or sets the list of query parameters for the HTTP request.
        /// </summary>
        public List<KeyValuePair<string, string>> RequestQueries { get; set; }

        /// <summary>
        /// Gets or sets the HTTP method used for the request (e.g., GET, POST).
        /// </summary>
        public string RequestMethod { get; set; }

        /// <summary>
        /// Gets or sets the scheme used for the request (e.g., HTTP, HTTPS).
        /// </summary>
        public string RequestScheme { get; set; }

        /// <summary>
        /// Gets or sets the host of the request (e.g., example.com).
        /// </summary>
        public string RequestHost { get; set; }

        /// <summary>
        /// Gets or sets the port of the request.
        /// </summary>
        public Dictionary<string, string> RequestHeaders { get; set; }

        /// <summary>
        /// Gets or sets the body of the HTTP request.
        /// </summary>
        public string RequestBody { get; set; }

        /// <summary>
        /// Gets or sets the content type of the HTTP request.
        /// </summary>
        public string RequestContentType { get; set; }


        /// <summary>
        /// Gets or sets the UTC timestamp of when the response was sent.
        /// </summary>
        /// <value>A <see cref="DateTime?"/> representing the response timestamp in UTC.</value>
        /// <remarks>
        /// This property records the time the HTTP response was sent by the server.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var logModel = new RequestResponseLogModel();
        /// logModel.ResponseDateTimeUtc = DateTime.UtcNow;
        /// Console.WriteLine($"Response Time: {logModel.ResponseDateTimeUtc}");
        /// </code>
        /// </example>
        public DateTime? ResponseDateTimeUtc { get; set; }

        /// <summary>
        /// Gets or sets the UTC timestamp of when the response was sent at the action level.
        /// </summary>
        public DateTime? ResponseDateTimeUtcActionLevel { get; set; }

        /// <summary>
        /// Gets or sets the status code of the HTTP response.
        /// </summary>
        public string ResponseStatus { get; set; }

        /// <summary>
        /// Gets or sets the status code of the HTTP response at the action level.
        /// </summary>
        public Dictionary<string, string> ResponseHeaders { get; set; }

        /// <summary>
        /// Gets or sets the body of the HTTP response.
        /// </summary>
        public string ResponseBody { get; set; }

        /// <summary>
        /// Gets or sets the content type of the HTTP response.
        /// </summary>
        public string ResponseContentType { get; set; }


        /// <summary>
        /// Gets or sets a value indicating whether the request was successful.
        /// </summary>
        public bool? IsExceptionActionLevel { get; set; }

        /// <summary>
        /// Gets or sets the exception message if an error occurred during the request or response.
        /// </summary>
        /// <value>A <see cref="string"/> representing the exception message.</value>
        /// <remarks>
        /// This property captures the error message if an exception occurred during the processing of the request or response.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var logModel = new RequestResponseLogModel();
        /// logModel.ExceptionMessage = "An error occurred.";
        /// Console.WriteLine($"Exception: {logModel.ExceptionMessage}");
        /// </code>
        /// </example>
        public string ExceptionMessage { get; set; }

        /// <summary>
        /// Gets or sets the stack trace of the exception if an error occurred.
        /// </summary>
        /// <value>A <see cref="string"/> representing the exception stack trace.</value>
        /// <remarks>
        /// This property captures the stack trace of the exception for debugging purposes.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var logModel = new RequestResponseLogModel();
        /// logModel.ExceptionStackTrace = "StackTrace details...";
        /// Console.WriteLine($"Stack Trace: {logModel.ExceptionStackTrace}");
        /// </code>
        /// </example>
        public string ExceptionStackTrace { get; set; }


        /// <summary>
        /// Initializes a new instance of the <see cref="RequestResponseLogModel"/> class.
        /// </summary>
        /// <remarks>
        /// This constructor initializes the log model with a unique identifier for each request and response log entry.
        /// </remarks>
        public RequestResponseLogModel()
        {
            LogId = Guid.NewGuid().ToString();
        }

    }


}
