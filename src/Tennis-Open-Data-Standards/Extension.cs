using System.Collections.ObjectModel;
using System.Xml.Serialization;
using Tennis_Open_Data_Standards.Attributes;

namespace Tennis_Open_Data_Standards
{
    [NoUnboundCustom]
    [XmlRoot("Extensions"), XmlType(TypeName = "Extensions")]
    public class Extensions
    {
        [XmlElement(IsNullable = false)]
        public Collection<Extension> Extension { get; set; }
    }
    /// <summary>
    /// Extension
    /// </summary>
    /// <remarks>
    /// Extensions can be used to capture additional information that does not yet have a place elsewhere in the TODS.  Please see Extensions.
    /// </remarks>
    public class Extension
    {
        /// <summary>
        /// Name
        /// </summary>
        /// <remarks>
        /// The name of the suggested extension eg AgeMin OR AgeMax
        /// </remarks>
        public string Name { get; set; }
        /// <summary>
        /// Value
        /// </summary>
        /// <remarks>
        /// The value of the suggested extension eg 12 OR 16
        /// </remarks>
        public string Value { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        /// <remarks>
        /// A description of the Extension
        /// </remarks>
        public string Description { get; set; }
    }
}
