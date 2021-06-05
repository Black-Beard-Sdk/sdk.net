using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace Bb.Sdk.Net.Mails.Models
{

    public class DataFile
    {

        public DataFile()
        {
            this.Attachments = new List<string>();
        }

        /// <summary>
        /// Mail subject
        /// </summary>
        public string Subject { get; set; }

        public string TemplateSubject { get; set; }

        /// <summary>
        /// Gets or sets a key for resolve the template. If the value is null or empty the value is equal the culture info in the mail.
        /// </summary>
        /// <value>
        /// The sub path.
        /// </value>
        public string HtmlTemplateName { get; set; }

        public string TextTemplateName { get; set; }

        public ContactFile From { get; set; }

        public ContactFile To { get; set; }

        public ContactFile ReplyTo { get; set; }

        public List<string> Attachments { get; set; }

        public JToken Datas { get; set; }

    }

}
