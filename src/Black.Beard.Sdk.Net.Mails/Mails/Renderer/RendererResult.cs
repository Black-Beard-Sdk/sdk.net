
namespace Bb.Sdk.Net.Mails.Renderer
{

    /// <summary>
    /// Renderer result
    /// </summary>
    public class RendererResult
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="RendererResult"/> class.
        /// </summary>
        public RendererResult()
        {

        }

        /// <summary>
        /// Gets or sets the HTML body.
        /// </summary>
        /// <value>
        /// The HTML body.
        /// </value>
        public string HtmlBody { get; set; }

        /// <summary>
        /// Gets the subject of the message.
        /// </summary>
        /// <value>
        /// The subject.
        /// </value>
        public string Subject { get; internal set; }

        /// <summary>
        /// Gets or sets the text body.
        /// </summary>
        /// <value>
        /// The text body.
        /// </value>
        public string TextBody { get; set; }


    }
}
