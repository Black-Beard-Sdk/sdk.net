using Bb.Sdk.Exceptions;
using Bb.Sdk.Net.Mails.Configurations;
using Bb.Sdk.Net.Mails.Models;
using Bb.Sdk.Net.Mails.Renderer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Bb.Sdk.Net.Mails.Senders
{

    /// <summary>
    /// manage the sending mail
    /// </summary>
    public class SmtpService : IEmailService
    {

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
        public void SendMail(object email)
        {

            var m = (MailMessage)email;

            Trace.WriteLine(string.Format("MailService : sending email at {0}", m.To.Select(o => o.Address).Aggregate((current, next) => current = current + "; " + next)));
            _client.Send(m);
            Trace.WriteLine("MailService : email sended succefully");
        }

        /// <summary>
        /// Creates the mail.
        /// </summary>
        /// <param name="mailResult">The mail result.</param>
        /// <param name="model">The model.</param>
        /// <returns></returns>
        /// <exception cref="Bb.Sdk.Exceptions.InvalidAddressException">
        /// </exception>
        /// <exception cref="Bb.Sdk.Exceptions.MissingMailViewException"></exception>
        /// <exception cref="Exception"></exception>
        public object GenerateMail(RendererResult mailResult, MessageModelBase model)
        {

            if (!model.To.IsValidEmail)
                throw new InvalidAddressException(string.Format("invalid receiver email address '{0}'", model.To.Email));

            MailMessage message = new MailMessage();

            try
            {
                message.Subject = mailResult.Subject;
            }
            catch (Exception)
            {
                throw new InvalidEmailSubjectContentException();
            }


            if (model.From != null)
                message.From = model.From.GetAdress();

            else if (!string.IsNullOrEmpty(this.profile.SenderAddress))
                message.From = this.profile.GetSenderEmail();

            else
                throw new MissingEmailException("sender");


            // Si on est en debug, on envoie uniquement les mails a _MailDebugTo
            if (this.profile.DebugMode)
                message.To.Add(new MailAddress(this.profile.MailDebugTo));

            else
            {

                if (this.profile.BccAddress != null)
                    message.Bcc.Add(profile.GetBccEmail());

                if (model.To != null)
                    message.To.Add(model.To.GetAdress());
                else
                    throw new MissingEmailException("receiver");

            }




            if (!object.ReferenceEquals(model.ReplyTo, null) && string.IsNullOrEmpty(model.ReplyTo.Email))
            {
                if (!model.ReplyTo.IsValidEmail)
                    throw new InvalidAddressException(string.Format("invalid reply email address '{0}'", model.To.Email));

                message.ReplyToList.Add(model.ReplyTo.GetAdress());

            }

            if (!string.IsNullOrEmpty(mailResult.TextBody) && !string.IsNullOrEmpty(mailResult.HtmlBody))
                throw new MissingMailViewException(string.Format("the mail template can't be resolved for the culture {0}.", model.Culture.IetfLanguageTag));

            if (!string.IsNullOrEmpty(mailResult.TextBody))
            {
                AlternateView textView = AlternateView.CreateAlternateViewFromString(mailResult.TextBody);
                message.AlternateViews.Add(textView);
            }

            if (!string.IsNullOrEmpty(mailResult.HtmlBody))
            {
                AlternateView htmlView = AlternateView.CreateAlternateViewFromString(mailResult.HtmlBody, null, "text/html");
                message.AlternateViews.Add(htmlView);
                message.Body = mailResult.HtmlBody;
                message.IsBodyHtml = true;
            }

            foreach (var item in model.Attachments)
                message.Attachments.Add(item);

            return message;
        }


        private SmtpProfile profile;
        private SmtpClient _client;
        private ContactAddress BccAddress;
        private ContactAddress fromAddress;

    }

}
