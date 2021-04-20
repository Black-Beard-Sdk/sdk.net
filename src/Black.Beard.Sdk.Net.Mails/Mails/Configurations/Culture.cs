using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Bb.Sdk.Net.Mails.Configurations
{

    /// <summary>
    /// Culture attribute contains a culture specified by the code
    /// </summary>
    public class CultureAttribute : Attribute
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="CultureAttribute"/> class.
        /// </summary>
        /// <param name="culture">The IExplorerCode code culture.</param>
        public CultureAttribute(string culture)
        {
            this.Culture = CultureInfo.GetCultureInfo(culture);
        }

        /// <summary>
        /// Gets the culture associated the constructor code. 
        /// </summary>
        /// <value>
        /// The culture.
        /// </value>
        public CultureInfo Culture { get; private set; }

    }
}
