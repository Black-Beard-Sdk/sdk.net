using Bb.Sdk.Net.Mails.Configurations;
using System.Collections.Generic;

namespace Bb.Sdk.Net.Mails.Models
{

    public class DataModel
    {

        public DataModel()
        {
            this.Mails = new List<DataFile>();

        }


        public List<DataFile> Mails { get; set; }

        public CultureEnum Culture { get; set; }

        public IEnumerable<MessageModelBase> GetDatas()
        {

            var culture = Culture.ToCulture();

            foreach (var item in this.Mails)
            {

                ContactAddress f = null;
                if (item.From != null)
                    f = item.From.GetContact();

                ContactAddress t = null;
                if (item.To != null)
                    t = item.To.GetContact();

                var model = new MessageModelBase(f, t)
                {
                    Culture = culture,
                    Subject = item.Subject,
                    SubjectTemplateName = item.TemplateSubject,
                    HtmlTemplateName = item.HtmlTemplateName,
                    TextTemplateName = item.TextTemplateName,
                    ReplyTo = item.ReplyTo != null ? item.ReplyTo.GetContact() : null,
                    Datas = item.Datas,
                };

                foreach (var attachment in item.Attachments)
                    model.Attachments.Add(new System.Net.Mail.Attachment(attachment));

                yield return model;

            }


        }



    }

}

