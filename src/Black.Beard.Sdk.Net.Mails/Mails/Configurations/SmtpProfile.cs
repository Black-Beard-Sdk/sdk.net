using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Bb.Sdk.Net.Mails.Configurations
{


    public partial class SmtpProfile
    {

        public SmtpProfile()
        {

        }

        [Required]
        public string Name { get; set; }

        [Required]
        public string HostName { get; set; }

        [Required]
        public int Port { get; set; } = 25;

        public bool EnabledSsl { get; set; }

        public string PickupDirectoryLocation { get; set; }

        public SmtpDeliveryFormat DeliveryFormat { get; set; }

        public SmtpDeliveryMethod DeliveryMethod { get; set; }

        public int TimeOut { get; set; } = 1000;

        public string Username { get; set; }

        public string Password { get; set; }

        public int MinPool { get; set; } = 1;

        public int MaxPool { get; set; } = 1;

        public string SenderAddress { get; set; }

        public string SenderName { get; set; }

        public string BccAddress { get; set; }

        public bool DebugMode { get; set; }

        public string MailDebugTo { get; set; }


        public MailAddress GetSenderEmail()
        {

            if (_senderAddress == null)
            {
                if (!string.IsNullOrEmpty(SenderName))
                    _senderAddress = new MailAddress(SenderAddress, SenderName);

                else
                    _senderAddress = new MailAddress(SenderAddress);
            }

            return _senderAddress;
        }

        public MailAddress GetBccEmail()
        {
            if (this._bccAddress == null)
                this._bccAddress = new MailAddress(BccAddress);
            return this._bccAddress;
        }

        /// <summary>
        /// Gets the smtp client.
        /// </summary>
        /// <returns></returns>
        public SmtpClient GetClient()
        {

            var _client = new SmtpClient(HostName, Port)
            {
                EnableSsl = EnabledSsl,
                Timeout = TimeOut,
                DeliveryMethod = DeliveryMethod,
                DeliveryFormat = DeliveryFormat
            };

            if (DeliveryMethod == SmtpDeliveryMethod.SpecifiedPickupDirectory && !String.IsNullOrEmpty(PickupDirectoryLocation))
            {

                if (!Directory.Exists(PickupDirectoryLocation))
                    throw new System.IO.DirectoryNotFoundException(PickupDirectoryLocation);

                _client.PickupDirectoryLocation = PickupDirectoryLocation;
            }

            if (!string.IsNullOrEmpty(Username))
            {

                var pwd = new SecureString();

                foreach (var item in Password)
                    pwd.AppendChar(item);

                _client.Credentials = new NetworkCredential(Username, pwd);

            }

            return _client;

        }


        private MailAddress _bccAddress;
        private MailAddress _senderAddress;
    }


}
