using System;
using System.Collections.Generic;
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

        public string Name { get; set; }


        public string HostName { get; set; }

        public int Port { get; set; }

        public bool EnabledSsl { get; set; }

        public string PickupDirectoryLocation { get; set; }

        public SmtpDeliveryFormat DeliveryFormat { get; set; }

        public SmtpDeliveryMethod DeliveryMethod { get; set; }

        public int TimeOut { get; set; }

        public string Username { get; set; }

        public SecureString Password { get; set; }

        public int MinPool { get; set; } = 1;

        public int MaxPool { get; set; } = 1;

        public string SenderAddress { get; set; }

        public string SenderName { get; set; }

        public string BccAddress { get; set; }

        public bool DebugMode { get; set; }

        public string MailDebugTo { get; set; }


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
                {
                    throw new System.IO.DirectoryNotFoundException(PickupDirectoryLocation);
                }
                _client.PickupDirectoryLocation = PickupDirectoryLocation;
            }

            if (!string.IsNullOrEmpty(Username))
                _client.Credentials = new NetworkCredential(Username, Password);

            return _client;

        }
    
    
    }


}
