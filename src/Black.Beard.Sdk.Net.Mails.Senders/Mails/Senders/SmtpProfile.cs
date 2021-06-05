using Bb.Sdk.Net.Mails.Configurations;
using Newtonsoft.Json;
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

namespace Bb.Sdk.Net.Mails.Senders
{

    public partial class SmtpProfile : MailProfile
    {

        public SmtpProfile()
        {
            
        }

        [Required]
        public string HostName { get; set; }

        [Required]
        public int Port { get; set; } = 25;

        public bool EnabledSsl { get; set; }

        public string PickupDirectoryLocation { get; set; }

        public SmtpDeliveryFormat DeliveryFormat { get; set; }

        public SmtpDeliveryMethod DeliveryMethod { get; set; }

        [JsonConverter(typeof(SecureConverter))]
        public string Username { get; set; }

        [JsonConverter(typeof(SecureConverter))]
        public string Password { get; set; }

        public override IEmailService GetService()
        {
            return new SmtpService((SmtpProfile)this);
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
            else
            {
                _client.UseDefaultCredentials = false;
                _client.Credentials = new NetworkCredential();
            }

            return _client;

        }


        private MailAddress _bccAddress;
        private MailAddress _senderAddress;
    }


}
