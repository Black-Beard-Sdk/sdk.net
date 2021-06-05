using Bb.Sdk.Net.Mails.Configurations;
using Bb.Sdk.Net.Mails.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace Bb.Sdk.Net.Mails.Renderer
{

    /// <summary>
    /// Implementation of template loader
    /// Load the template from a directory
    /// </summary>
    public class FolderMessageLoader : ITemplateLoader
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="FolderMessageLoader" /> class.
        /// </summary>
        /// <param name="folderTemplate">The folder.</param>
        public FolderMessageLoader(DirectoryInfo folderTemplate)
            : base()
        {
            this.folder = folderTemplate;
        }

        /// <summary>
        /// Loads the template.
        /// </summary>
        /// <param name="subKey">The sub key for determine where find the message.</param>
        /// <param name="MessageKey">Name of the model.</param>
        /// <param name="culture">The culture.</param>
        /// <returns></returns>
        public StringBuilder LoadTemplate(string MessageKey, CultureInfo culture)
        {

            StringBuilder body = null;

            if (!string.IsNullOrEmpty(MessageKey))
            {

                string fileName;
                fileName = Path.Combine(folder.FullName, MessageKey) + ".cshtml";

                if (File.Exists(fileName))
                    body = new StringBuilder(ContentHelper.LoadContentFromFile(fileName));

            }

            return body;

        }

        private DirectoryInfo folder;

    }
}
