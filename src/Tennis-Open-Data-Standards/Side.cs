using System.Collections.ObjectModel;
using System.Xml.Serialization;
using Newtonsoft.Json;
using Tennis_Open_Data_Standards.Attributes;

namespace Tennis_Open_Data_Standards
{
    [NoUnboundCustom]
    [XmlRoot("Sides"), XmlType(TypeName = "Sides")]
    public class Sides
    {
        [XmlElement(IsNullable = false)]
        public Collection<Side> Side { get; set; }
    }
    /// <summary>
    /// Side
    /// </summary>
    /// <remarks>
    /// </remarks>
    public class Side : CommonElements
    {
        /// <summary>
        /// SideNumber
        /// </summary>
        /// <remarks>
        /// 1 or 2
        /// </remarks>
        [JsonProperty(Required = Required.Always)]
        public int SideNumber { get; set; }
        /// <summary>
        /// Score
        /// </summary>
        /// <remarks>
        /// The score according to the side's perspective. 
        /// </remarks>
        public string Score { get; set; }
        /// <summary>
        /// Participant
        /// </summary>
        /// <remarks>
        /// A team or pair as defined in participant. Not required for individuals.
        /// Please see <see cref="Participant">Participant</see>
        /// </remarks>
        public Participant Participant { get; set; }
        /// <summary>
        /// Players
        /// </summary>
        /// <remarks>
        /// The members of the team or pair who are actually playing the match
        /// </remarks>

        //XML minOccurs=0 to 1
        [NoUnboundCustom]
        [XmlElement("Players", typeof(Players))]
        public Collection<Player> Players { get; set; }
    }
}
