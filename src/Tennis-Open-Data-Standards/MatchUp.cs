using System;
using System.Collections.ObjectModel;
using System.Xml.Serialization;
using Newtonsoft.Json;
using Tennis_Open_Data_Standards.Attributes;

namespace Tennis_Open_Data_Standards
{
    [XmlRoot("MatchUps"), XmlType(TypeName = "MatchUps")]
    public class MatchUps
    {
        [XmlElement(IsNullable = false)]
        public Collection<MatchUp> MatchUp { get; set; }
    }
    /// <summary>
    /// MatchUp
    /// </summary>
    /// <remarks>
    /// A contest in which at least two or more players compete. 
    /// Please see the <see href="https://itftennis.atlassian.net/wiki/spaces/TODS/pages/1272938561/Introduction+to+the+Match">Introduction to the match</see>
    /// </remarks>

    public class MatchUp : CommonElements
    {
        /// <summary>
        /// MatchUpId
        /// </summary>
        /// <remarks>
        /// A unique MatchUp identifier. 
        /// Please see the <see href="https://itftennis.atlassian.net/wiki/spaces/TODS/pages/1273102565/Including+Multiple+Identifiers">How to Include multiple Identifiers</see>
        /// </remarks>

        //XML minOccurs=1 to 1
        [XmlElement(IsNullable = true)]
        [JsonProperty(Required = Required.Always)]
        public string MatchUpId { get; set; }
        /// <summary>
        /// DrawId
        /// </summary>
        /// <remarks>
        /// An optional field to link MatchUps to a draw if not using the Event->Stage->Draw->Rounds structure
        /// Please see the <see cref="Draw">Draw</see>
        /// </remarks>

        //XML minOccurs=0 to 1
        //[JsonProperty(Required = Required.Always)]
        public string DrawId { get; set; }
        /// <summary>
        /// RoundNumber
        /// </summary>
        /// <remarks>
        /// The round of the draw in the tournament. i.e. first round or semi-final
        /// </remarks>

        //XML minOccurs=0 to 1
        public int? RoundNumber { get; set; }
        /// <summary>
        /// Round Position
        /// </summary>
        /// <remarks>
        /// The MatchUp position with the aforementioned round number. e.g. a semi-final with have 2 round MatchUps. The round position of the MatchUp being played will be 1 or 2 as a result.
        /// </remarks>

        //XML minOccurs=0 to 1
        public int? RoundPosition { get; set; }
        /// <summary>
        /// MatchUp Type
        /// </summary>
        /// <remarks>
        /// Please see <see href="~MatchUpType">MatchUpType</see>'
        /// </remarks>
        public string MatchUpType { get; set; }
        /// <summary>
        /// MatchUp Format
        /// </summary>
        /// <remarks>
        /// MatchUp Format Code
        /// Please see the <see href="https://itftennis.atlassian.net/wiki/spaces/TODS/pages/1272840309/MatchUp+Format+Code">MatchUp Format Code</see>
        /// </remarks>
        public string MatchUpFormat { get; set; }
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
        /// When the MatchUp started
        /// </remarks>

        //XML minOccurs=0 to 1
        public DateTime? StartDate { get; set; }
        /// <summary>
        /// EndDate
        /// </summary>
        /// <remarks>
        /// When the MatchUp ended
        /// </remarks>

        //XML minOccurs=0 to 1
        public DateTime? EndDate { get; set; }
        /// <summary>
        /// MatchUpDuration
        /// </summary>
        /// <remarks>
        /// MatchUp Duration in total minutes of play
        /// </remarks>
        public string MatchUpDuration { get; set; }

        [XmlElement("OrderOfPlayItem", typeof(OrderOfPlayItem))]
        public OrderOfPlayItem OrderOfPlayItem { get; set; }
        [XmlElement("ScheduleItem", typeof(ScheduleItem))]
        public Collection<ScheduleItem> ScheduleItems { get; set; }
        /// <summary>
        /// MatchUpStatus
        /// </summary>
        /// <remarks>
        /// Please see <see href="~MatchUpStatus">MatchUpStatus</see>
        /// </remarks>
        public string MatchUpStatus { get; set; }
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
        [NoUnboundCustom]
        [XmlElement("Sides", typeof(Sides))]
        public Collection<Side> Sides { get; set; }
        /// <summary>
        /// Sets
        /// </summary>
        /// <remarks>
        /// A hierarchy containing multiple set details
        /// </remarks>

        //XML minOccurs=0 to 1
        [NoUnboundCustom]
        [XmlElement("Sets", typeof(Sets))]
        public Collection<Set> Sets { get; set; }
    }
}
