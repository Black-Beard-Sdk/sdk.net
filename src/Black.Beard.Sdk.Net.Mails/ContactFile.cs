using Bb.Sdk.Net.Mails.Models;

namespace Black.Beard.Sdk.Net.Mails
{
    public class ContactFile
    {

        /// <summary>
        /// Gets the email.
        /// </summary>
        /// <value>
        /// The email.
        /// </value>
        public string Email { get; set; }

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




        internal ContactAddress GetContact()
        {
            return new ContactAddress(this.Email)
            {
                Civility = Civility,
                Libelle = this.Libelle,
                
            };
        }
    }

}
