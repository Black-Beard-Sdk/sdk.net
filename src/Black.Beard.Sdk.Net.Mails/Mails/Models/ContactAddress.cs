using System.Net.Mail;
using System.Text.RegularExpressions;

namespace Bb.Sdk.Net.Mails.Models
{

    /// <summary>
    /// MailReceiverModel
    /// </summary>
    public class ContactAddress
    {

        private static Regex _regex = new Regex(@"^((([a-z]|\d|[!#\$%&'\*\+\-\/=\?\^_`{\|}~]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])+(\.([a-z]|\d|[!#\$%&'\*\+\-\/=\?\^_`{\|}~]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])+)*)|((\x22)((((\x20|\x09)*(\x0d\x0a))?(\x20|\x09)+)?(([\x01-\x08\x0b\x0c\x0e-\x1f\x7f]|\x21|[\x23-\x5b]|[\x5d-\x7e]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(\\([\x01-\x09\x0b\x0c\x0d-\x7f]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF]))))*(((\x20|\x09)*(\x0d\x0a))?(\x20|\x09)+)?(\x22)))@((([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])*([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))\.)+(([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])*([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))\.?$", RegexOptions.Compiled | RegexOptions.IgnoreCase);


        /// <summary>
        /// Initializes a new instance of the <see cref="ContactAddress" /> class.
        /// </summary>
        /// <param name="mail">The mail.</param>
        /// <exception cref="System.ArgumentException">mail</exception>
        public ContactAddress(string mail)
        {

            if (string.IsNullOrEmpty(mail))
                throw new System.ArgumentException("mail");

            this.Email = mail;
            this.IsValidEmail = _regex.IsMatch(mail);

        }

        /// <summary>
        /// Gets the email.
        /// </summary>
        /// <value>
        /// The email.
        /// </value>
        public string Email { get; private set; }

        /// <summary>
        /// Gets or sets the libelle.
        /// </summary>
        /// <value>
        /// The libelle.
        /// </value>
        public string Libelle { get; set; }

        /// <summary>
        /// Gets or sets the civilite.
        /// </summary>
        /// <value>
        /// The civilite.
        /// </value>
        public string Civility { get; set; }

        /// <summary>
        /// Gets a value indicating whether this instance has valid email.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is valid email; otherwise, <c>false</c>.
        /// </value>
        public bool IsValidEmail { get; private set; }



        public MailAddress GetAdress()
        {
            if (!string.IsNullOrEmpty(Libelle))
                return new MailAddress(Email, Libelle);
            else
                return new MailAddress(Email);
        }

    }

}
