using System;
using System.Collections.ObjectModel;
using System.Xml.Serialization;

namespace Tennis_Open_Data_Standards
{
    [XmlRoot(DataType = "Addresses", ElementName = "Addresses")]
    [XmlType(TypeName = "Addresses")]
    [Serializable()]
    public class Addresses
    {
        [XmlElement(IsNullable = false)]
        public Collection<Address> Address { get; set; }
    }
    public class Address
    {
        /// <summary>
        /// AddressType
        /// </summary>
        /// <remarks>
        /// Please see <see href="~AddressType">AddressType</see>
        /// </remarks>
        public string AddressType { get; set; }
        /// <summary>
        /// AddressLine1
        /// </summary>
        /// <remarks>
        /// Address Line 1
        /// </remarks>
        public string AddressLine1 { get; set; }
        /// <summary>
        /// AddressLine2
        /// </summary>
        /// <remarks>
        /// Address Line 2
        /// </remarks>
        public string AddressLine2 { get; set; }
        /// <summary>
        /// AddressLine3
        /// </summary>
        /// <remarks>
        /// Address Line 3
        /// </remarks>
        public string AddressLine3 { get; set; }
        /// <summary>
        /// City
        /// </summary>
        /// <remarks>
        /// City
        /// </remarks>
        public string City { get; set; }
        /// <summary>
        /// State
        /// </summary>
        /// <remarks>
        /// State
        /// </remarks>
        public string State { get; set; }
        /// <summary>
        /// PostalCode
        /// </summary>
        /// <remarks>
        /// PostalCode
        /// </remarks>
        public string PostalCode { get; set; }
        /// <summary>
        /// Country Code
        /// </summary>
        /// <remarks>
        /// The Country (ISO3166-3 standards). Please see Wikipedia <see href="https://en.wikipedia.org/wiki/ISO_3166-1_alpha-3"> ISO_3166-1_alpha-3</see>
        /// </remarks>
        public string CountryCode { get; set; }
        /// <summary>
        /// Latitude
        /// </summary>
        /// <remarks>
        /// Latitude as per Google Maps eg <strong>51°27'32.2"N</strong> 0°15'19.0"W OR <strong>51.458947</strong>, -0.255283
        /// </remarks>
        public string Latitude { get; set; }
        /// <summary>
        /// Longitude
        /// </summary>
        /// <remarks>
        /// Longitude as per Google Maps eg 51°27'32.2"N <strong>0°15'19.0"W</strong> OR 51.458947, <strong>-0.255283</strong>
        /// </remarks>
        public string Longitude { get; set; }
    }
}
