using Bb.Sdk.Net.Mails.Configurations;
using Bb.Sdk.Net.Mails.Renderer;
using System.Linq;
using System.Collections.Generic;

namespace Bb.Sdk.Net.Mails
{


    public class MailNotificationServiceProvider
    {

        public MailNotificationServiceProvider()
        {
            this._dicTemplateLoader = new Dictionary<string, ITemplateLoader>();
        }

        public MailNotificationServiceProvider AddTemplateLoader(string templateLoadName, ITemplateLoader templateLoader)
        {
            this._dicTemplateLoader.Add(templateLoadName, templateLoader);
            return this;
        }


        private IMessageRenderer GetRenderer(string keyTemplate)
        {

            if (!this._dicTemplateLoader.TryGetValue(keyTemplate, out ITemplateLoader templateLoader))
                throw new KeyNotFoundException(keyTemplate);
                        
            RazorMessageRenderer render = new RazorMessageRenderer(templateLoader);

            return render;

        }

        private IEmailService GetMailService(string profileName)
        {
            var profile = Configuration.Instance.Profiles.FirstOrDefault(c => c.Name == profileName);
            if (profile == null)
                throw new Sdk.Exceptions.MissingProfileException(profileName);

            IEmailService mailService = profile.GetService();

            return mailService;
        }

        public MailNotificationService GetService(string profileName)
        {

            IMessageRenderer renderer = GetRenderer(profileName);
            IEmailService mailService = GetMailService(profileName);

            MailNotificationService service = new MailNotificationService(renderer, mailService);

            return service;

        }

        private Dictionary<string, ITemplateLoader> _dicTemplateLoader;

    }

}
