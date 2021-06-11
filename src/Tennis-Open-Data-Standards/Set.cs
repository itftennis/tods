using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;
using Newtonsoft.Json;
using Tennis_Open_Data_Standards.Attributes;

namespace Tennis_Open_Data_Standards
{
    [NoUnboundCustom]
    [XmlRoot("Sets"), XmlType(TypeName = "Sets")]
    public class Sets
    {
        [XmlElement(IsNullable = false)]
        public Collection<Set> Set { get; set; }
    }

    public class Set 
    {
        /// <summary>
        /// SetNumber
        /// </summary>
        /// <remarks>
        /// A number representing the set. Usually 1-5
        /// </remarks>
        [Key]
        [JsonProperty(Required = Required.Always)]
        public int SetNumber { get; set; }
        public CommonElements CommonElements { get; set; }        
        /// <summary>
        /// Timestamp
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        //XML minOccurs=0 to 1
        public DateTime? Timestamp { get; set; }
        /// <summary>
        /// SetFormat
        /// </summary>
        /// <remarks>
        /// Please see the 'Match Format Code' document for more information.
        /// </remarks>
        public string SetFormat { get; set; }
        /// <summary>
        /// Side1Score
        /// </summary>
        /// <remarks>
        /// The Set score for Side 1
        /// </remarks>
        //XML minOccurs=0 to 1
        public int? Side1Score { get; set; }
        /// <summary>
        /// Side2Score
        /// </summary>
        /// <remarks>
        /// The Set score for Side 2
        /// </remarks>
        //XML minOccurs=0 to 1
        public int? Side2Score { get; set; }
        /// <summary>
        /// Side1TieBreakScore
        /// </summary>
        /// <remarks>
        /// The Tie break score within the Set for Side 1 
        /// </remarks>
        //XML minOccurs=0 to 1
        public int? Side1TieBreakScore { get; set; }
        /// <summary>
        /// Side2TieBreakScore
        /// </summary>
        /// <remarks>
        /// The Tie break score within the Set for Side 2
        /// </remarks>
        //XML minOccurs=0 to 1
        public int? Side2TieBreakScore { get; set; }
        /// <summary>
        /// SetDuration
        /// </summary>
        /// <remarks>
        /// Set Duration in total minutes
        /// </remarks>
        public string SetDuration { get; set; }
        /// <summary>
        /// WinningSide
        /// </summary>
        /// <remarks>
        /// Side 1 or 2 
        /// </remarks>
        //XML minOccurs=0 to 1
        public int? WinningSide { get; set; }
        /// <summary>
        /// Games
        /// </summary>
        /// <remarks>
        /// A hierarchy containing multiple game details
        /// </remarks>
        
        //XML minOccurs=0 to 1
        [XmlElement("Games", typeof(Games))]
        public Collection<Game> Games { get; set; }
    }
}
