using System.Collections.ObjectModel;
using System.Xml.Serialization;

namespace Tennis_Open_Data_Standards
{
    [XmlRoot("OnlineProfiles"), XmlType(TypeName = "OnlineProfiles")]
    public class OnlineProfiles
    {
        [XmlElement(IsNullable = false)]
        public Collection<OnlineProfile> OnlineProfile { get; set; }
    }
    /// <summary>
    /// OnlineProfile
    /// </summary>
    /// <remarks>
    /// Online Profile
    /// </remarks>
    public class OnlineProfile
    {
        /// <summary>
        /// Type
        /// </summary>
        /// <remarks>
        /// Type eg Twitter
        /// </remarks>
        public string Type { get; set; }
        /// <summary>
        /// Identifier
        /// </summary>
        /// <remarks>
        /// Identifier eg @ITF_Tennis
        /// </remarks>
        public string Identifier { get; set; }
    }
}
