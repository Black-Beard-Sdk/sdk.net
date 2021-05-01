using Bb.Sdk.Exceptions;
using Bb.Sdk.Net.Mails.Configurations;
using Bb.Sdk.Net.Mails.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Bb.Sdk.Net.Mails
{

    /// <summary>
    /// manage the sending mail
    /// </summary>
    public class SmtpService
    {

        private SmtpProfile profile;
        private SmtpClient _client;
        private ContactAddress BccAddress;
        private ContactAddress fromAddress;

        /// <summary>
        /// Initializes a new instance of the <see cref="SmtpService"/> class.
        /// </summary>
        /// <param name="profile">The profile.</param>
        public SmtpService(SmtpProfile profile)
        {

            this.profile = profile;
            _client = profile.GetClient();

            if (!string.IsNullOrEmpty(this.profile.SenderAddress))
            {
                this.fromAddress = new ContactAddress(this.profile.SenderAddress) { Libelle = this.profile.SenderName };
                if (!this.fromAddress.IsValidEmail)
                    throw new InvalidAddressException(string.Format("invalid reply email address '{0}'", this.fromAddress.Email));
            }

            if (!string.IsNullOrEmpty(this.profile.BccAddress))
            {
                this.BccAddress = new ContactAddress(this.profile.BccAddress);
                if (!this.BccAddress.IsValidEmail)
                    throw new InvalidAddressException(string.Format("invalid reply email address '{0}'", this.BccAddress.Email));
            }

        }

        /// <summary>
        /// Sends the mail.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <exception cref="Exception">
        /// Problème lors de la connexion du client SMTP : + smtpException.Message
        /// or
        /// Problème lors de l'envoie de mail + exception.Message
        /// </exception>
        public void SendMail(MailMessage email)
        {
            Trace.WriteLine(string.Format("MailService : sending email at {0}", email.To.Select(o => o.Address).Aggregate((current, next) => current = current + "; " + next)));
            _client.Send(email);
            Trace.WriteLine("MailService : email sended succefully");
        }

    }

}
