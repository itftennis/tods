using System;
using System.Collections.ObjectModel;
using System.Xml.Serialization;
using Newtonsoft.Json;
using Tennis_Open_Data_Standards.Attributes;

namespace Tennis_Open_Data_Standards
{
    [NoUnboundCustom]
    [XmlRoot("Games"), XmlType(TypeName = "Games")]
    public class Games
    {
        [XmlElement(IsNullable = false)]
        public Collection<Game> Game { get; set; }
    }
    public class Game : CommonElements
    {
        [JsonProperty(Required = Required.Always)]
        public int GameNumber { get; set; }
        //XML minOccurs=0 to 1
        public DateTime? Timestamp { get; set; }        
        public string GameFormat { get; set; }
        public string GameDuration { get; set; }
        //XML minOccurs=0 to 1
        public int? WinningSide { get; set; }

        //XML minOccurs=0 to 1
        [NoUnboundCustom]
        [XmlElement("Points", typeof(Points))]
        public Collection<Point> Points { get; set; }
    }
}
