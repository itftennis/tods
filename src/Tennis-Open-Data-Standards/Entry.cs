using System.Collections.ObjectModel;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Tennis_Open_Data_Standards
{
    [XmlRoot("Entries"), XmlType(TypeName = "Entries")]
    public class Entries
    {
        [XmlElement(IsNullable = false)]
        public Collection<Entry> Entry { get; set; }
    }
    public class Entry : CommonElements
    {
        /// <summary>
        /// Entry Id
        /// </summary>
        /// <remarks>
        /// A unique entry identifier. 
        /// Please see the <see href="https://itftennis.atlassian.net/wiki/spaces/TODS/pages/1273102565/Including+Multiple+Identifiers">How to Include multiple Identifiers</see>
        /// </remarks>

        //XML minOccurs=1 to 1
        [XmlElement(IsNullable = true)]
        [JsonProperty(Required = Required.Always)]
        public string EntryId { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        /// <remarks>
        /// The name of the entry.
        /// </remarks>
        public string Name { get; set; }
        /// <summary>
        /// Participant
        /// </summary>
        /// <remarks>
        /// A team or pair as defined in participant. Not required for individuals.
        /// Please see <see cref="Participant">Participant</see>
        /// </remarks>
        public Participant Participant { get; set; }
        /// <summary>
        /// ParticipantType
        /// </summary>
        /// <remarks>
        /// Please see <see href="~ParticipantType">ParticipantType</see>
        /// </remarks>
        public string ParticipantType { get; set; }
        /// <summary>
        /// EntryStatus
        /// </summary>
        /// <remarks>
        /// Please see <see href="~EntryStatus">EntryStatus</see>
        /// </remarks>
        public string EntryStatus { get; set; }
        /// <summary>
        /// Points
        /// </summary>
        /// <remarks>
        /// Points.
        /// </remarks>
        public string Points { get; set; }
        /// <summary>
        /// FinalPosition
        /// </summary>
        /// <remarks>
        /// The highest position reached.
        /// </remarks>
        // codes?
        public string FinalPosition { get; set; }
        /// <summary>
        /// Wins
        /// </summary>
        /// <remarks>
        /// The number of wins.
        /// </remarks>

        //XML minOccurs=0 to 1
        public int? Wins { get; set; }
        /// <summary>
        /// Losses
        /// </summary>
        /// <remarks>
        /// The number of losses.
        /// </remarks>

        //XML minOccurs=0 to 1
        public int? Losses { get; set; }
        /// <summary>
        /// Seed
        /// </summary>
        /// <remarks>
        /// The Entries seed position.
        /// </remarks>

        //XML minOccurs=0 to 1
        public int? Seed { get; set; }
    }
}
