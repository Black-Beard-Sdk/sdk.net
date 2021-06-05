using Bb.Sdk.Net.Mails.Configurations;
using Bb.Sdk.Net.Mails.Senders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bb.Sdk.Net.Mails
{
    
    public static class RegisterProfiles
    {

        public static void Register()
        {

            MailProfile.AddProfile<SmtpProfile>();

        }


    }

}
