// Ignore Spelling: Middleware

using Bb.ComponentModel;
using Bb.ComponentModel.Attributes;

namespace Bb.Middleware.EntryFullLogger
{
    /// <summary>
    /// Represents the options for configuring the request and response logger.
    /// </summary>

    [ExposeClass(Context = ConstantsCore.Configuration, ExposedType = typeof(RequestResponseLoggerOption), LifeCycle = IocScope.Singleton)]
    public class RequestResponseLoggerOption
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestResponseLoggerOption"/> class.
        /// </summary>
        /// <remarks>
        /// This constructor initializes the default settings for the request and response logger options.
        /// </remarks>
        public RequestResponseLoggerOption()
        {

        }

        /// <summary>
        /// Gets or sets a value indicating whether the request and response logging is enabled.
        /// </summary>
        /// <value><see langword="true"/> if logging is enabled; otherwise, <see langword="false"/>.</value>
        /// <remarks>
        /// This property determines whether the request and response logging functionality is active.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var options = new RequestResponseLoggerOption();
        /// options.IsEnabled = true;
        /// Console.WriteLine($"Logging enabled: {options.IsEnabled}");
        /// </code>
        /// </example>
        public bool IsEnabled { get; set; }

        /// <summary>
        /// Gets or sets the name associated with the logger.
        /// </summary>
        /// <value>A <see cref="string"/> representing the name of the logger.</value>
        /// <remarks>
        /// This property specifies the name used to identify the logger in logs or configurations.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var options = new RequestResponseLoggerOption();
        /// options.Name = "RequestLogger";
        /// Console.WriteLine($"Logger Name: {options.Name}");
        /// </code>
        /// </example>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the date and time format used in the logs.
        /// </summary>
        /// <value>A <see cref="string"/> representing the date and time format.</value>
        /// <remarks>
        /// This property specifies the format in which date and time values are logged.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var options = new RequestResponseLoggerOption();
        /// options.DateTimeFormat = "yyyy-MM-dd HH:mm:ss";
        /// Console.WriteLine($"DateTime Format: {options.DateTimeFormat}");
        /// </code>
        /// </example>
        public string DateTimeFormat { get; set; }

    }


}
