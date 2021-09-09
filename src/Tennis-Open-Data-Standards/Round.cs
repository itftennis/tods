using System.Collections.ObjectModel;
using System.Xml.Serialization;
using Newtonsoft.Json;
using Tennis_Open_Data_Standards.Attributes;

namespace Tennis_Open_Data_Standards
{
    [XmlRoot("Rounds"), XmlType(TypeName = "Rounds")]
    public class Rounds
    {
        [XmlElement(IsNullable = false)]
        public Collection<Round> Round { get; set; }
    }
    public class Round
    {
        [JsonProperty(Required = Required.Always)]
        public int RoundNumber { get; set; }
        [NoUnboundCustom]
        [XmlElement("RoundItems", typeof(RoundItems))]
        public Collection<RoundItem> RoundItems { get; set; }
    }
}
