using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net.Mail;

namespace Bb.Sdk.Net.Mails.Configurations
{


    [System.Diagnostics.DebuggerDisplay("{Name} : {Type}")]
    public abstract partial class MailProfile
    {

        static MailProfile()
        {
            MailProfile._dic = new Dictionary<string, Func<MailProfile>>();
        }

        public MailProfile()
        {
            Type = GetType().Name;
        }

        public static void AddProfile<T>()
            where T : MailProfile, new()
        {
            var type = new T().Type;
            if (!MailProfile._dic.ContainsKey(type))
                MailProfile._dic.Add(type, () => new T());
        }

        public static MailProfile Get(string profilename)
        {

            if (MailProfile._dic.TryGetValue(profilename, out Func<MailProfile> func))
                return func();

            return null;

        }

        [Required]
        public string Type { get; set; }

        [Required]
        public string Name { get; set; }

        public int TimeOut { get; set; } = 1000;

        public string SenderAddress { get; set; }

        public string SenderName { get; set; }

        public string BccAddress { get; set; }

        public bool DebugMode { get; set; }

        public string MailDebugTo { get; set; }

        public virtual MailAddress GetSenderEmail()
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

        public abstract IEmailService GetService();


        private MailAddress _bccAddress;
        private MailAddress _senderAddress;

        private static readonly Dictionary<string, Func<MailProfile>> _dic;

    }


}
