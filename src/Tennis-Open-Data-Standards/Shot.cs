using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;
using Newtonsoft.Json;
using Tennis_Open_Data_Standards.Attributes;

namespace Tennis_Open_Data_Standards
{
    [NoUnboundCustom]
    [XmlRoot("Shots"), XmlType(TypeName = "Shots")]
    public class Shots
    {
        [XmlElement(IsNullable = false)]
        public Collection<Shot> Shot { get; set; }
    }
    /// <summary>
    /// Shots
    /// </summary>
    /// <remarks>
    /// A hierarchy containing multiple shot details
    /// </remarks>
    public class Shot
    {
        
        /// <summary>
        /// Number
        /// </summary>
        /// <remarks>
        /// Number of the shot in the rally.
        /// </remarks>
        [Key]
        [JsonProperty(Required = Required.Always)]
        public int ShotNumber { get; set; }
        /// <summary>
        /// ShotType
        /// </summary>
        /// <remarks>
        /// Please see <see href="~ShotType">ShotType</see>
        /// </remarks>
        public string ShotType { get; set; }
        /// <summary>
        /// ShotDetail
        /// </summary>
        /// <remarks>
        /// Please see <see href="~ShotDetail">ShotDetail</see>
        /// </remarks>
        public string ShotDetail { get; set; }
        /// <summary>
        /// Side
        /// </summary>
        /// <remarks>
        /// Side 1 or 2 
        /// </remarks>
        public string Side { get; set; }
        /// <summary>
        /// Participant
        /// </summary>
        /// <remarks>
        /// The Participant that hit made the shot (usually only for doubles)
        /// </remarks>
        public Participant Participant { get; set; }
        /// <summary>
        /// ShotOutcome
        /// </summary>
        /// <remarks>
        /// Please see <see href="~ShotOutcome">ShotOutcome</see>
        /// </remarks>
        public string ShotOutcome { get; set; }
        /// <summary>
        /// Returned
        /// </summary>
        /// <remarks>
        /// Yes or No
        /// </remarks>
        public string Returned { get; set; }
        /// <summary>
        /// Speed
        /// </summary>
        /// <remarks>
        /// Mph, m/s, Kmph
        /// </remarks>
        
        //XML minOccurs=0 to 1
        public decimal? Speed { get; set; }
        /// <summary>
        /// Spin
        /// </summary>
        /// <remarks>
        /// RPM or VX,VY,VZ
        /// </remarks>
        public string Spin { get; set; }
        /// <summary>
        /// ShotMadeFrom
        /// </summary>
        /// <remarks>
        /// Please see <see href="~ShotMadeFrom">ShotMadeFrom</see> OR X,Y
        /// </remarks>
        public string ShotMadeFrom { get; set; }
        /// <summary>
        /// BounceAt
        /// </summary>
        /// <remarks>
        /// X,Y
        /// </remarks>
        public string BounceAt { get; set; }
    }
}
