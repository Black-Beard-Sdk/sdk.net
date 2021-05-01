using Bb.Sdk.Net.Mails.Configurations;
using Bb.Sdk.Net.Mails.Models;
using System;
using System.Globalization;
using System.Text;
using RazorEngine;
using RazorEngine.Templating; // For extension methods.
using Black.Beard.Sdk.Net.Mails;
using Bb.Sdk.Exceptions;

namespace Bb.Sdk.Net.Mails.Renderer
{

    /// <summary>
    /// Implementation of mail renderer based on Razor 
    /// </summary>
    public class RazorMessageRenderer : IMessageRenderer
    {

        /// <summary>
        /// The default culture
        /// </summary>
        protected readonly CultureInfo defaultCulture;

        /// <summary>
        /// Initializes a new instance of the <see cref="FolderMessageLoader" /> class.
        /// </summary>
        public RazorMessageRenderer()
        {
            this.defaultCulture = Configuration.Instance.DefaultCulture.ToCulture();
        }

        /// <summary>
        /// Gets or sets the message loader.
        /// </summary>
        /// <value>
        /// The message loader.
        /// </value>
        public IMessageLoader MessageLoader { get; set; }

        /// <summary>
        /// Uses the Razor engine to generate both html and text based mailbody
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns></returns>
        public RendererResult Render(MessageModelBase model)
        {

            RendererResult result = new RendererResult() { Subject = model.Subject };

            string htmlBody = string.Empty;

            if (!string.IsNullOrEmpty(model.HtmlTemplateName))
                result.HtmlBody = LoadMessage(model.HtmlTemplateName, model.Culture, model);

            if (!string.IsNullOrEmpty(model.TextTemplateName))
                result.TextBody = LoadMessage(model.TextTemplateName, model.Culture, model);

            if (!string.IsNullOrEmpty(model.SubjectTemplateName))
                result.Subject = LoadMessage(model.SubjectTemplateName, model.Culture, model);

            if (string.IsNullOrEmpty(result.Subject))
                result.Subject = model.Subject;

            return result;

        }

        /// <summary>
        /// Loads the template.
        /// </summary>
        /// <param name="subKey">The sub key.</param>
        /// <param name="messageKey">Name of the model.</param>
        /// <param name="culture">The culture.</param>
        /// <param name="model">The model.</param>
        /// <returns></returns>
        /// <exception cref="System.NullReferenceException">please set the property MessageLoader with a message loder implementation</exception>
        private string LoadMessage(string messageKey, CultureInfo culture, MessageModelBase model)
        {

            if (MessageLoader == null)
                throw new NullReferenceException("please set the property MessageLoader with a message loder implementation");

            StringBuilder template = MessageLoader.LoadTemplate(messageKey, culture);

            if (template != null)
            {

                string body = null;

                if (template.Length > 0)
                    body = Engine.Razor.RunCompile(template.ToString(), "templateKey", typeof(Newtonsoft.Json.Linq.JObject), model.Datas);

                return body.Trim();

            }

            throw new MissingMailViewException(messageKey);

        }

    }


}
