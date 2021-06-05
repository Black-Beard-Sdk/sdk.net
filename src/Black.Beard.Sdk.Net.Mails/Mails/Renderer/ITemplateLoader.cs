using Bb.Sdk.Net.Mails.Models;
using System.Globalization;
using System.Text;

namespace Bb.Sdk.Net.Mails.Renderer
{

    /// <summary>
    /// load the template
    /// </summary>
    public interface ITemplateLoader
    {

        /// <summary>
        /// Loads the template.
        /// </summary>
        /// <param name="subKey">The sub key for determine where find the message.</param>
        /// <param name="MessageKey">Name of the model.</param>
        /// <param name="culture">The culture.</param>
        /// <returns>the template</returns>
        StringBuilder LoadTemplate(string MessageKey, CultureInfo culture);


    }
}