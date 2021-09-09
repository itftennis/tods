using System.Collections.ObjectModel;
using System.Xml.Serialization;
using Newtonsoft.Json;
using Tennis_Open_Data_Standards.Attributes;

namespace Tennis_Open_Data_Standards
{
    [NoUnboundCustom]
    [XmlRoot("Players"), XmlType(TypeName = "Players")]
    public class Players
    {
        [XmlElement(IsNullable = false)]
        public Collection<Player> Player { get; set; }
    }
    public class Player
    {
        [JsonProperty(Required = Required.Always)]
        public int PlayerNumber { get; set; }
        [JsonProperty(Required = Required.Always)]
        public Participant Participant { get; set; }
    }
}
