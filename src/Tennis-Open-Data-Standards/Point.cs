using System;
using System.Collections.ObjectModel;
using System.Xml.Serialization;
using Newtonsoft.Json;
using Tennis_Open_Data_Standards.Attributes;

namespace Tennis_Open_Data_Standards
{
    [NoUnboundCustom]
    [XmlRoot("Points"), XmlType(TypeName = "Points")]
    public class Points
    {
        [XmlElement(IsNullable = false)]
        public Collection<Point> Point { get; set; }
    }
    public class Point
    {
        [JsonProperty(Required = Required.Always)]
        public int PointNumber { get; set; }
        //XML minOccurs=0 to 1
        public DateTime? Timestamp { get; set; }
        /// <summary>
        /// Side1Score
        /// </summary>
        /// <remarks>
        /// Deuce scoring - 15, 30, 40, Adv
        /// </remarks>
        public string Side1Score { get; set; }
        /// <summary>
        /// Side2Score
        /// </summary>
        /// <remarks>
        /// Deuce scoring - 15, 30, 40, Adv
        /// </remarks>
        public string Side2Score { get; set; }
        /// <summary>
        /// PointDuration
        /// </summary>
        /// <remarks>
        /// Point duration in total minutes
        /// </remarks>
        public string PointDuration { get; set; }
        /// <summary>
        /// WinningSide
        /// </summary>
        /// <remarks>
        /// Side 1 or 2 
        /// </remarks>
        //XML minOccurs=0 to 1
        public int? WinningSide { get; set; }
        /// <summary>
        /// WinReason
        /// </summary>
        /// <remarks>
        /// Please see <see href="~WinReason">WinReason</see>
        /// </remarks>
        public string WinReason { get; set; }
        /// <summary>
        /// Shots
        /// </summary>
        /// <remarks>
        /// A hierarchy containing multiple shot details
        /// </remarks>

        //XML minOccurs=0 to 1
        [NoUnboundCustom]
        [XmlElement("Shots", typeof(Shots))]
        public Collection<Shot> Shots { get; set; }
    }
}
