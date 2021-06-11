using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Tennis_Open_Data_Standards
{
    [XmlRoot("Contacts"), XmlType(TypeName = "Contacts")]
    public class Contacts
    {
        [XmlElement(IsNullable = false)]
        public Collection<Contact> Contact { get; set; }
    }

    public class Contact
    {
        /// <summary>
        /// ContactType
        /// </summary>
        /// <remarks>
        /// Please see <see href="~ContactType">ContactType</see>
        /// </remarks>
        public string ContactType { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        /// <remarks>
        /// The name of the contact.
        /// </remarks>
        public string Name { get; set; }
        /// <summary>
        /// Telephone
        /// </summary>
        /// <remarks>
        /// The contacts telephone number.
        /// </remarks>
        [Phone] // Custom phone validation
        public string Telephone { get; set; }
        /// <summary>
        /// MobileTelephone
        /// </summary>
        /// <remarks>
        /// The contacts mobile telephone number.
        /// </remarks>
        public string MobileTelephone { get; set; }
        /// <summary>
        /// Fax
        /// </summary>
        /// <remarks>
        /// The contacts fax number.
        /// </remarks>
        public string Fax { get; set; }
        /// <summary>
        /// EmailAddress
        /// </summary>
        /// <remarks>
        /// The contacts email address.
        /// </remarks>
        [EmailAddress]
        public string EmailAddress { get; set; }
        /// <summary>
        /// Website
        /// </summary>
        /// <remarks>
        /// The contacts website.
        /// </remarks>
        public string Website { get; set; }
        /// <summary>
        /// IsPrivate
        /// </summary>
        /// <remarks>
        /// If the details are private or can be published online. Usually for tournament directors, referees etc.
        /// </remarks>

        //XML minOccurs=0 to 1
        public bool IsPrivate { get; set; }
    }
}
