using Bb.Sdk.Net.Mails.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Bb.Sdk.Net.Mails
{

    /// <summary>
    /// Mail event
    /// </summary>
    public class MailEventArgs : EventArgs
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="MailEventArgs" /> class.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <param name="mail">The mail.</param>
        public MailEventArgs(MessageModelBase model, object mail)
        {
            this.Model = model;
            this.Mail = mail;
        }

        /// <summary>
        /// Gets or sets the model.
        /// </summary>
        /// <value>
        /// The model.
        /// </value>
        public MessageModelBase Model { get; set; }

        /// <summary>
        /// Gets or sets the mail convert by the mail service.
        /// </summary>
        /// <value>
        /// The mail.
        /// </value>
        public object Mail { get; set; }

        /// <summary>
        /// Gets the status.
        /// </summary>
        /// <value>
        /// The status.
        /// </value>
        public MailStatusEnum Status { get; internal set; }

        /// <summary>
        /// Gets the exception.
        /// </summary>
        /// <value>
        /// The exception.
        /// </value>
        public Exception Exception { get; internal set; }

    }


    /// <summary>
    /// status for mail processing
    /// </summary>
    public enum MailStatusEnum
    {

        /// <summary>
        /// The mail is initialized and reader to start
        /// </summary>
        Initialized,

        /// <summary>
        /// The mail is sending
        /// </summary>
        Sending,

        /// <summary>
        /// The mail is sended
        /// </summary>
        Sended,

        /// <summary>
        /// The mail was in error
        /// </summary>
        Error,
    }

}
