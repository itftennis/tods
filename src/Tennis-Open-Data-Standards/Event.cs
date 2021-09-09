using System;
using System.Collections.ObjectModel;
using System.Xml.Serialization;
using Newtonsoft.Json;
using Tennis_Open_Data_Standards.Attributes;

namespace Tennis_Open_Data_Standards
{
    [XmlRoot("Events"), XmlType(TypeName = "Events")]
    public class Events
    {
        [XmlElement(IsNullable = false)]
        public Collection<Event> Event { get; set; }
    }
    public class Event : CommonElements
    {
        /// <summary>
        /// EventId
        /// </summary>
        /// <remarks>
        /// A unique event identifier. 
        /// Please see the <see href="https://itftennis.atlassian.net/wiki/spaces/TODS/pages/1273102565/Including+Multiple+Identifiers">How to Include multiple Identifiers</see>
        /// </remarks>

        //XML minOccurs=1 to 1
        [XmlElement(IsNullable = true)]
        [JsonProperty(Required = Required.Always)]
        public string EventId { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        /// <remarks>
        /// The name of the event eg Regional U16 Level 1 Boys
        /// </remarks>
        public string Name { get; set; }
        /// <summary>
        /// List of person ID's for officials
        /// </summary>
        /// <remarks>
        /// Please see <see cref="TennisOfficials">TennisOfficials</see>
        /// </remarks>
        public TennisOfficials TennisOfficials { get; set; }
        /// <summary>
        /// Discipline
        /// </summary>
        /// <remarks>
        /// The Discipline eg Tennis, Beach Tennis, Wheelchair Tennis etc
        /// </remarks>
        public string Discipline { get; set; }
        /// <summary>
        /// Event Level
        /// </summary>
        /// <remarks>
        /// Please see the 
        /// <see href="https://itftennis.atlassian.net/wiki/spaces/TODS/pages/1272873121/Tournament+Level">Tournament Level</see> document for more information
        /// </remarks>
        public string EventLevel { get; set; }
        /// <summary>
        /// EventType
        /// </summary>
        /// <remarks>
        /// Please see <see href="~EventType">EventType</see>
        /// </remarks>
        public string EventType { get; set; }
        /// <summary>
        /// WheelchairClass
        /// </summary>
        /// <remarks>
        /// Please see <see href="~WheelchairClass">WheelchairClass</see>
        /// </remarks>
        public string WheelchairClass { get; set; }
        /// <summary>
        /// BallType
        /// </summary>
        /// <remarks>
        /// Please see <see href="~BallType">BallType</see>
        /// </remarks>
        public string BallType { get; set; }
        /// <summary>
        /// Surface Category
        /// </summary>
        /// <remarks>
        /// Please see <see href="~SurfaceCategory">SurfaceCategory</see>
        /// </remarks>
        public string SurfaceCategory { get; set; }
        /// <summary>
        /// Age Category
        /// </summary>
        /// <remarks>
        /// Please see <see href="~AgeCategory">AgeCategory</see>
        /// </remarks>
        public string AgeCategory { get; set; }
        /// <summary>
        /// AgeCategoryCutoffDate
        /// </summary>
        /// <remarks>
        /// Please see <see href="~AgeCategory">AgeCategory</see>
        /// </remarks>
        public DateTime? AgeCategoryCutoffDate { get; set; }
        /// <summary>        /// Gender
        /// </summary>
        /// <remarks>
        /// Please see <see href="~Gender">Gender</see>
        /// </remarks>
        public string Gender { get; set; }
        /// <summary>
        /// Start Date
        /// </summary>
        /// <remarks>
        /// The start date of the event
        /// </remarks>

        //XML minOccurs=0 to 1
        public DateTime? StartDate { get; set; }
        /// <summary>
        /// End Date
        /// </summary>
        /// <remarks>
        /// The end date of the event
        /// </remarks>

        //XML minOccurs=0 to 1
        public DateTime? EndDate { get; set; }
        /// <summary>
        /// Entries
        /// </summary>
        /// <remarks>
        /// Please see <see cref="Entries">Entries</see>
        /// </remarks>

        //XML minOccurs=0 to 1
        [NoUnboundCustom]
        [XmlElement("Entries", typeof(Entries))]
        public Collection<Entry> Entries { get; set; }
        /// <summary>
        /// Stages
        /// </summary>
        /// <remarks>
        /// Please see <see cref="Stages">Stages</see>
        /// </remarks>

        //XML minOccurs=0 to 1
        [NoUnboundCustom]
        [XmlElement("Stages", typeof(Stages))]
        public Collection<Stage> Stages { get; set; }
    }
}
