using System.Net.Mail;
using Bb.Sdk.Net.Mails.Configurations;
using Bb.Sdk.Net.Mails.Renderer;
using Bb.Sdk.Net.Mails.Models;
using System;
using System.Threading.Tasks;
using Bb.Sdk.Exceptions;
using System.Diagnostics;

namespace Bb.Sdk.Net.Mails
{


    /// <summary>
    /// Mail Service notifier
    /// </summary>
    public class MailNotificationService
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="MailNotificationService"/> class.
        /// </summary>
        /// <param name="profileName">Name of the profile.</param>
        /// <param name="renderer">The renderer.</param>
        public MailNotificationService(IMessageRenderer renderer, IEmailService mailService)
        {
            this._mailService = mailService;
            this.renderer = renderer;
        }

        /// <summary>
        /// Sends the mail to the specified receivers.
        /// </summary>
        /// <param name="model">The model.</param>
        public async Task<bool> Send(MessageModelBase model)
        {

            _inTreatment = true;
            bool ok = false;

            Trace.WriteLine(string.Format("MailNotificationService : Starting render generation. model'name : {0}", model.GetType().FullName));

            object message = null;

            try
            {


                // Generate the rendered from the model
                RendererResult mailrendered = renderer.Render(model);

                // Generate the MailMessage
                message = this._mailService.GenerateMail(mailrendered, model);
                MailEventArgs eventArg = new MailEventArgs(model, message);

                _sendingCount++;
                Notify(eventArg, MailStatusEnum.Initialized);

                ok = await ExecuteSend(message, eventArg);

                return ok;

            }
            finally
            {

                if (message != null)
                {

                    if (message is IDisposable d)
                        try
                        {
                            d.Dispose();
                        }
                        catch (Exception e)
                        {
                            Trace.WriteLine(e.ToString(), erroCategory);
                        }

                    message = null;

                }

                if (ok)
                    Trace.WriteLine("MailNotificationService : sending process succesfully ended");
                else
                    Trace.WriteLine("MailNotificationService : sending process failed ended");

                _inTreatment = false;

            }


        }

        /// <summary>
        /// processe sending mail
        /// </summary>
        /// <param name="srv">The SRV.</param>
        /// <param name="message">The message.</param>
        /// <param name="eventArg">The <see cref="MailEventArgs"/> instance containing the event data.</param>
        /// <returns></returns>
        private async Task<bool> ExecuteSend(object message, MailEventArgs eventArg)
        {

            bool result = false;

            Notify(eventArg, MailStatusEnum.Sending);

            try
            {
                this._mailService.SendMail(message);
                _sendedCount++;
                Notify(eventArg, MailStatusEnum.Sended);
            }
            catch (Exception exception)
            {
                _errorCount++;
                Trace.Fail(exception.ToString());
                eventArg.Exception = exception;
                Notify(eventArg, MailStatusEnum.Error);
            }

            return await Task.FromResult(result);

        }

        private void Notify(MailEventArgs eventArg, MailStatusEnum mailStatusEnum)
        {

            eventArg.Status = mailStatusEnum;

            if (this.MailEvents != null)
                this.MailEvents(this, eventArg);
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
        private MailMessage CreateMail(RendererResult mailResult, MessageModelBase model)
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

        /// <summary>
        /// Occurs when [mail events].
        /// </summary>
        public event EventHandler<MailEventArgs> MailEvents;

        /// <summary>
        /// Gets or sets the sending count.
        /// </summary>
        /// <value>
        /// The sending count.
        /// </value>
        public int SendingCount { get { return _sendingCount; } }

        /// <summary>
        /// Gets or sets the sended count.
        /// </summary>
        /// <value>
        /// The sended count.
        /// </value>
        public int SendedCount { get { return _sendedCount; } }

        /// <summary>
        /// Gets or sets the error count.
        /// </summary>
        /// <value>
        /// The error count.
        /// </value>
        public int ErrorCount { get { return _errorCount; } }

        /// <summary>
        /// Gets the in treatment.
        /// </summary>
        /// <value>
        /// The in treatment.
        /// </value>
        public bool InTreatment { get { return _inTreatment; } }

        private MailProfile profile;
        private IEmailService _mailService;
        private IMessageRenderer renderer;
        private int _sendingCount = 0;
        private int _sendedCount = 0;
        private int _errorCount = 0;
        private bool _inTreatment;

        private static string erroCategory = System.Diagnostics.TraceLevel.Error.ToString();

    }

}
