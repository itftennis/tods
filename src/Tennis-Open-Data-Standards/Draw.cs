using System;
using System.Collections.ObjectModel;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Tennis_Open_Data_Standards
{
    [XmlRoot("Draws"), XmlType(TypeName = "Draws")]
    public class Draws
    {
        [XmlElement(IsNullable = false)]
        public Collection<Draw> Draw { get; set; }
    }
    /// <summary>
    /// 
    /// </summary>
    public class Draw : CommonElements
    {
        /// <summary>
        /// Draw Id
        /// </summary>
        /// <remarks>
        /// A unique draw identifier. 
        /// Please see the <see href="https://itftennis.atlassian.net/wiki/spaces/TODS/pages/1273102565/Including+Multiple+Identifiers">How to Include multiple Identifiers</see>
        /// </remarks>

        //XML minOccurs=1 to 1
        [JsonProperty(Required = Required.Always)]
        public string DrawId { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        /// <remarks>
        /// The name of the draw.
        /// </remarks>
        public string Name { get; set; }
        /// <summary>
        /// DrawStructure
        /// </summary>
        /// <remarks>
        /// Please see <see href="~DrawStructure">DrawStructure</see>
        /// </remarks>
        public string DrawStructure { get; set; }

        //XML minOccurs=0 to 1
        [XmlElement("Rounds", typeof(Rounds))]
        
        //XML minOccurs=0 to 1
        public Collection<Round> Rounds { get; set; }
        /// <summary>
        /// SortOrder
        /// </summary>
        /// <remarks>
        /// A number representing the order of the draw within the event.
        /// </remarks>

        //XML minOccurs=0 to 1
        public int? SortOrder { get; set; }
        /// <summary>
        /// StartDate
        /// </summary>
        /// <remarks>
        /// The start date of the draw.
        /// </remarks>

        //XML minOccurs=0 to 1
        public DateTime StartDate { get; set; }
        /// <summary>
        /// EndDate
        /// </summary>
        /// <remarks>
        /// The end date of the draw.
        /// </remarks>

        //XML minOccurs=0 to 1
        public DateTime EndDate { get; set; }
        /// <summary>
        /// DrawSize
        /// </summary>
        /// <remarks>
        /// The total number of places available in the first round. Usually 128, 64, 32, 16 or 8.
        /// </remarks>

        //XML minOccurs=0 to 1
        public int? DrawSize { get; set; }
        /// <summary>
        /// NoOfRounds
        /// </summary>
        /// <remarks>
        /// How many rounds does the draw span. eg for a 32 draw size, this would be 5 rounds (Round 1, Round 2, Quarterfinals, Semifinals, Finals)
        /// </remarks>

        //XML minOccurs=0 to 1
        public int? NoOfRounds { get; set; }
        /// <summary>
        /// DrawStatus
        /// </summary>
        /// <remarks>
        /// Please see <see href="~DrawStatus">DrawStatus</see>
        /// </remarks>
        public string DrawStatus { get; set; }
        /// <summary>
        /// Entries
        /// </summary>
        /// <remarks>
        /// Please see <see cref="Entries">Entries</see>
        /// </remarks>

        //XML minOccurs=0 to 1
        [XmlElement("Entries", typeof(Entries))]
        public Collection<Entry> Entries { get; set; }
        /// <summary>
        /// Matches
        /// </summary>
        /// <remarks>
        /// Please see <see cref="Matches">Matches</see>
        /// </remarks>

        //XML minOccurs=0 to 1
        [XmlElement("Matches", typeof(Matches))]
        public Collection<Match> Matches { get; set; }
        /// <summary>
        /// Ties
        /// </summary>
        /// <remarks>
        /// Please see <see cref="Ties">Ties</see>
        /// </remarks>

        //XML minOccurs=0 to 1
        [XmlElement("Ties", typeof(Ties))]
        public Collection<Tie> Ties { get; set; }
    }
}
