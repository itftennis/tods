using System;
using System.Collections.ObjectModel;
using System.Xml.Serialization;
using Newtonsoft.Json;
using Tennis_Open_Data_Standards.Attributes;

namespace Tennis_Open_Data_Standards
{
    [Serializable()]
    /// <summary>
    /// The Tennis class.    
    /// </summary>

    /// <remarks>
    /// This is a root element and holds all the collections 
    /// </remarks>
    public class Tennis : ITennis
    {
        /// <summary>
        /// ProviderId
        /// </summary>
        /// <remarks>
        /// An identifier for the party providing the data. 
        /// Please see the <see href="https://itftennis.atlassian.net/wiki/spaces/TODS/pages/1273102565/Including+Multiple+Identifiers">How to Include multiple Identifiers</see>
        /// </remarks>
        [JsonProperty(Required = Required.Always)]
        [XmlElement(ElementName = "ProviderId", IsNullable = true)]
        public string ProviderId { get; set; }

        /// <summary>
        /// Date
        /// </summary>
        /// <remarks>
        /// The date the document is provided.
        /// </remarks>
        [JsonProperty(Required = Required.Always)]        
        public DateTime Date { get; set; }
        /// <summary>
        /// DataStandardsVersion
        /// </summary>
        /// <remarks>
        /// The version of the data standards the file is using.
        /// </remarks>

        //XML minOccurs=1 to 1
        [JsonProperty(Required = Required.Always)]
        [XmlElement(ElementName = "DataStandardsVersion", IsNullable = true)]
        public string DataStandardsVersion { get; set; }
        /// <summary>
        /// CodesVersion
        /// </summary>
        /// <remarks>
        /// The version of the Standard Codes the file is using.
        /// </remarks>
        public string CodesVersion { get; set; }
        /// <summary>
        /// OrderOfPlays
        /// </summary>
        /// <remarks>
        /// Please see <see cref="OrderOfPlays">OrderOfPlays</see>
        /// </remarks>
        //XML minOccurs=0 to 1  
        [NoUnboundCustom]
        [XmlElement("OrderOfPlays", typeof(OrderOfPlays))]               
        public Collection<OrderOfPlay> OrderOfPlays { get; set; }
        /// <summary>
        /// Tournaments
        /// </summary>
        /// <remarks>
        /// Please see <see cref="Tournaments">Tournaments</see>
        /// </remarks>
        [NoUnboundCustom]
        [XmlElement("Tournaments", typeof(Tournaments))]
        public Collection<Tournament> Tournaments { get; set; }
        /// <summary>
        /// Courts
        /// </summary>
        /// <remarks>
        /// Please see <see cref="Courts">Courts</see>
        /// </remarks>
        [NoUnboundCustom]
        [XmlElement("Courts", typeof(Courts))]
        public Collection<Court> Courts { get; set; }
        /// <summary>
        /// Persons
        /// </summary>
        /// <remarks>
        /// Please see <see cref="Persons">Persons</see>
        /// </remarks>
        [NoUnboundCustom]
        [XmlElement("Persons", typeof(Persons))]
        public Collection<Person> Persons { get; set; }
        /// <summary>
        /// Teams
        /// </summary>
        /// <remarks>
        /// Please see <see cref="Teams">Teams</see>
        /// </remarks>
        [NoUnboundCustom]
        [XmlElement("Teams", typeof(Teams))]
        public Collection<Team> Teams { get; set; }
        /// <summary>
        /// Rankings
        /// </summary>
        /// <remarks>
        /// Please see <see cref="Rankings">Rankings</see>
        /// </remarks>
        [NoUnboundCustom]
        [XmlElement("Rankings", typeof(Rankings))] 
        public Collection<Ranking> Rankings { get; set; }
        /// <summary>
        /// Venues
        /// </summary>
        /// <remarks>
        /// Please see <see cref="Venues">Venues</see>
        /// </remarks>
        [NoUnboundCustom]
        [XmlElement("Venues", typeof(Venues))]
        public Collection<Venue> Venues { get; set; }
        /// <summary>
        /// Statistics
        /// </summary>
        /// <remarks>
        /// Please see <see cref="Statistics">Statistics</see>
        /// </remarks>
        [NoUnboundCustom]
        [XmlElement("Statistics", typeof(Statistics))]
        public Collection<Statistic> Statistics { get; set; }
        /// <summary>
        /// Organisations
        /// </summary>
        /// <remarks>
        /// Please see <see cref="Organisations">Organisations</see>
        /// </remarks>
        [NoUnboundCustom]
        [XmlElement("Organisations", typeof(Organisations))]
        public Collection<Organisation> Organisations { get; set; }
        /// <summary>
        /// Extensions
        /// </summary>
        /// <remarks>
        /// Please see <see cref="Extensions">Extensions</see>
        /// </remarks>
        [NoUnboundCustom]
        [XmlElement("Extensions", typeof(Extensions))]        
        public Collection<Extension> Extensions { get; set; }
        /// <summary>
        /// WorldTennisNumbers
        /// </summary>
        /// <remarks>
        /// Please see <see cref="WorldTennisNumbers">WorldTennisNumbers</see>
        /// </remarks>
        [NoUnboundCustom]
        [XmlElement("WorldTennisNumbers", typeof(WorldTennisNumbers))]
        public Collection<WorldTennisNumber> WorldTennisNumbers { get; set; }

    }
}
