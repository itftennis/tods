using System;
using System.Collections.ObjectModel;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Tennis_Open_Data_Standards
{
    [XmlRoot("Matches"), XmlType(TypeName = "Matches")]
    public class Matches
    {
        [XmlElement(IsNullable = false)]
        public Collection<Match> Match { get; set; }
    }
    /// <summary>
    /// Match
    /// </summary>
    /// <remarks>
    /// A contest in which at least two or more players compete. 
    /// Please see the <see href="https://itftennis.atlassian.net/wiki/spaces/TODS/pages/1272938561/Introduction+to+the+Match">Introduction to the match</see>
    /// </remarks>

    public class Match : CommonElements
    {
        /// <summary>
        /// MatchId
        /// </summary>
        /// <remarks>
        /// A unique match identifier. 
        /// Please see the <see href="https://itftennis.atlassian.net/wiki/spaces/TODS/pages/1273102565/Including+Multiple+Identifiers">How to Include multiple Identifiers</see>
        /// </remarks>

        //XML minOccurs=1 to 1
        [JsonProperty(Required = Required.Always)]
        public string MatchId { get; set; }
        /// <summary>
        /// RoundNumber
        /// </summary>
        /// <remarks>
        /// The round of the draw in the tournament or tie. i.e. first round or semi-final
        /// </remarks>

        //XML minOccurs=0 to 1
        public int? RoundNumber { get; set; }
        /// <summary>
        /// Round Position
        /// </summary>
        /// <remarks>
        /// The match position with the aforementioned round number. e.g. a semi-final with have 2 round matches. The round position of the match being played will be 1 or 2 as a result.
        /// </remarks>
        
            //XML minOccurs=0 to 1
        public int? RoundPosition { get; set; }
        /// <summary>
        /// Match Type
        /// </summary>
        /// <remarks>
        /// Please see <see href="~MatchType">MatchType</see>'
        /// </remarks>
        public string MatchType { get; set; }
        /// <summary>
        /// Match Format
        /// </summary>
        /// <remarks>
        /// Match Format Code
        /// Please see the <see href="https://itftennis.atlassian.net/wiki/spaces/TODS/pages/1272840309/Match+Format+Code">Match Format Code</see>
        /// </remarks>
        public string MatchFormat { get; set; }
        /// <summary>
        /// Indoor Outdoor
        /// </summary>
        /// <remarks>
        /// Please see <see href="~IndoorOutdoor">IndoorOutdoor</see>
        /// </remarks>
        public string IndoorOutdoor { get; set; }
        /// <summary>
        /// Surface Category
        /// </summary>
        /// <remarks>
        /// Please see <see href="~SurfaceCategory">SurfaceCategory</see>
        /// </remarks>
        public string SurfaceCategory { get; set; }
        /// <summary>
        /// Court
        /// </summary>
        /// <remarks>
        /// Please see <see cref="Court">Court</see>
        /// </remarks>
        public Court Court { get; set; }
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
        /// Please see <see cref="GoesTo">GoesTo</see>
        /// </remarks>
        public GoesTo WinnerGoesTo { get; set; }
        /// <summary>
        /// LoserGoesTo
        /// </summary>
        /// <remarks>
        /// Please see <see cref="GoesTo">GoesTo</see>
        /// </remarks>
        public GoesTo LoserGoesTo { get; set; }
        /// <summary>
        /// Score
        /// </summary>
        /// <remarks>
        /// The result from the winner's perspective. e.g. 6-4, 4-6, 7-6(7-5)
        /// </remarks>
        public string Score { get; set; }
        /// <summary>
        /// StartDate
        /// </summary>
        /// <remarks>
        /// When the match started
        /// </remarks>

        //XML minOccurs=0 to 1
        public DateTime StartDate { get; set; }
        /// <summary>
        /// EndDate
        /// </summary>
        /// <remarks>
        /// When the match ended
        /// </remarks>

        //XML minOccurs=0 to 1
        public DateTime? EndDate { get; set; }
        /// <summary>
        /// MatchDuration
        /// </summary>
        /// <remarks>
        /// Match Duration in total minutes of play
        /// </remarks>
        public string MatchDuration { get; set; }
        
        [XmlElement("OrderOfPlayItem", typeof(OrderOfPlayItem))]
        public OrderOfPlayItem OrderOfPlayItem { get; set; }
        /// <summary>
        /// MatchStatus
        /// </summary>
        /// <remarks>
        /// Please see <see href="~MatchStatus">MatchStatus</see>
        /// </remarks>
        public string MatchStatus { get; set; }
        /// <summary>
        /// Temperature
        /// </summary>
        /// <remarks>
        /// Temperature in degrees
        /// </remarks>

        //XML minOccurs=0 to 1
        public decimal? Temperature { get; set; }
        /// <summary>
        /// Humidity
        /// </summary>
        /// <remarks>
        /// Humidity as a percentage
        /// </remarks>

        //XML minOccurs=0 to 1
        public decimal? Humidity { get; set; }
        /// <summary>
        /// Sides
        /// </summary>
        /// <remarks>
        /// A hierarchy containing multiple side details
        /// </remarks>

        //XML minOccurs=0 to 1
        [XmlElement("Sides", typeof(Sides))]
        public Collection<Side> Sides { get; set; }
        /// <summary>
        /// Sets
        /// </summary>
        /// <remarks>
        /// A hierarchy containing multiple set details
        /// </remarks>

        //XML minOccurs=0 to 1
        [XmlElement("Sets", typeof(Sets))]
        public Collection<Set> Sets { get; set; }
    }
}
