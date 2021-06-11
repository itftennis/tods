using System;
using System.Collections.ObjectModel;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Tennis_Open_Data_Standards
{
    [XmlRoot("Ties"), XmlType(TypeName = "Ties")]
    public class Ties
    {
        [XmlElement(IsNullable = false)]
        public Collection<Tie> Tie { get; set; }
    }
    public class Tie : CommonElements
    {
        /// <summary>
        /// TieId
        /// </summary>
        /// <remarks>
        /// A unique tie Identifier. Please see the 'How to Include multiple Identifiers'
        /// </remarks>

        //XML minOccurs=1 to 1
        [JsonProperty(Required = Required.Always)]
        public string TieId { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        /// <remarks>
        /// The name of the tie. eg Great Britain vs USA
        /// </remarks>
        public string Name { get; set; }
        /// <summary>
        /// RoundNumber
        /// </summary>
        /// <remarks>
        /// The round of the draw in the tournament or tie. i.e. first round or semi-final
        /// </remarks>

        //XML minOccurs=0 to 1
        public int? RoundNumber { get; set; }
        /// <summary>
        /// RoundPosition
        /// </summary>
        /// <remarks>
        /// The tie position with the aforementioned round number. e.g. a semi-final with have 2 round matches. The round position of the tie being played will be 1 or 2 as a result.
        /// </remarks>

        //XML minOccurs=0 to 1
        public int? RoundPosition { get; set; }
        /// <summary>
        /// SortOrder
        /// </summary>
        /// <remarks>
        /// The order in which the games are played
        /// </remarks>

        //XML minOccurs=0 to 1
        public int? SortOrder { get; set; }
        /// <summary>
        /// StartDate
        /// </summary>
        /// <remarks>
        /// When the tie started
        /// </remarks>

        //XML minOccurs=0 to 1
        public DateTime StartDate { get; set; }
        /// <summary>
        /// EndDate
        /// </summary>
        /// <remarks>
        /// When the tie ended
        /// </remarks>

        //XML minOccurs=0 to 1
        public DateTime? EndDate { get; set; }
        public OrderOfPlayItem OrderOfPlayItem { get; set; }
        /// <summary>
        /// Venue
        /// </summary>
        /// <remarks>
        /// The place the tie is played
        /// </remarks>
        public Venue Venue { get; set; }
        /// <summary>
        /// TieStatus
        /// </summary>
        /// <remarks>
        /// Please see <see href="~TieStatus">TieStatus</see>
        /// </remarks>
        public string TieStatus { get; set; }
        /// <summary>
        /// TieFormat
        /// </summary>
        /// <remarks>
        /// Please see the <see href="https://itftennis.atlassian.net/wiki/spaces/TODS/pages/1272840309/Match+Format+Code">Match Format Code</see> document for more information.
        /// </remarks>
        public string TieFormat { get; set; }
        /// <summary>
        /// Score
        /// </summary>
        /// <remarks>
        /// This is your Tie score, not tennis match scores.
        /// </remarks>
        public string Score { get; set; }
        /// <summary>
        /// WinningSide
        /// </summary>
        /// <remarks>
        /// 1 or 2
        /// </remarks>

        //XML minOccurs=0 to 1
        public int? WinningSide { get; set; }
        /// <summary>
        /// WinnerGoesTo
        /// </summary>
        /// <remarks>
        /// Please see <see href="~WinnerGoesTo">WinnerGoesTo</see>
        /// </remarks>
        public GoesTo WinnerGoesTo { get; set; }
        /// <summary>
        /// LoserGoesTo
        /// </summary>
        /// <remarks>
        /// Please see <see href="~LoserGoesTo">LoserGoesTo</see>
        /// </remarks>
        public GoesTo LoserGoesTo { get; set; }
        /// <summary>
        /// Sides
        /// </summary>
        /// <remarks>
        /// A hierarchy containing multiple side details
        /// </remarks>

        //XML minOccurs=0 to 1
        [XmlElement("Sides", typeof(Sides))]
        public Collection<Side> Sides { get; set; }

        //XML minOccurs=0 to 1
        [XmlElement("Matches", typeof(Matches))]
        public Collection<Match> Matches { get; set; }
    }
}
