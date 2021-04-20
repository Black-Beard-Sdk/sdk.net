using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net.Mail;
using System.Reflection;

namespace Bb.Sdk.Net.Mails.Models
{

    /// <summary>
    /// 
    /// </summary>
    public class MessageModelBase
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageModelBase" /> class.
        /// </summary>
        /// <param name="from">From.</param>
        /// <param name="to">The receiver.</param>
        public MessageModelBase(MessageReceiverModel @from, MessageReceiverModel to)
        {
            this.From = from;
            this.To = to;
            Attachments = new List<Attachment>();
            Culture = CultureInfo.CurrentCulture;
            IsBodyHtml = true;
        }

        /// <summary>
        /// Mail subject
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// Gets or sets the name of the subject template.
        /// </summary>
        /// <value>
        /// The name of the subject template.
        /// </value>
        public string SubjectTemplateName { get; set; }

        /// <summary>
        /// Namespace path to cshtml file that represent the html view for the mail
        /// </summary>
        public string HtmlTemplateName { get; set; }

        /// <summary>
        /// Namespace path to cshtml file that represent the text view for the mail
        /// </summary>
        public string TextTemplateName { get; set; }

        /// <summary>
        /// Gets or sets a key for resolve the template. If the value is null or empty the value is equal the culture info in the mail.
        /// </summary>
        /// <value>
        /// The sub path.
        /// </value>
        public string SubKey { get; set; }

        /// <summary>
        /// ReplyTo description
        /// </summary>
        public MessageReceiverModel ReplyTo { get; set; }

        /// <summary>
        /// Gets from.
        /// </summary>
        /// <value>
        /// From.
        /// </value>
        public MessageReceiverModel From { get; private set; }

        /// <summary>
        /// Gets or sets the culture.
        /// </summary>
        /// <value>
        /// The culture.
        /// </value>
        public CultureInfo Culture { get; set; }

        /// <summary>
        /// Gets or sets the receivers list.
        /// </summary>
        /// <value>
        /// The receivers.
        /// </value>
        public MessageReceiverModel To { get; private set; }

        /// <summary>
        /// Gets or sets the attachments.
        /// </summary>
        /// <value>
        /// The attachments.
        /// </value>
        public List<Attachment> Attachments { get; private set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is body HTML.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is body HTML; otherwise, <c>false</c>.
        /// </value>
        public bool IsBodyHtml { get; set; }


    }
}
