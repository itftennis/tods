using System.Collections.ObjectModel;
using System.Xml.Serialization;
using Newtonsoft.Json;
using Tennis_Open_Data_Standards.Attributes;

namespace Tennis_Open_Data_Standards
{
    [NoUnboundCustom]
    [XmlRoot("Rankings"), XmlType(TypeName = "Rankings")]
    public class Rankings
    {
        [XmlElement(IsNullable = false)]
        public Collection<Ranking> Ranking { get; set; }
    }
    public class Ranking
    {
        [JsonProperty(Required = Required.Always)]
        //XML minOccurs=1 to 1
        [XmlElement(IsNullable = true)]
        public string RankingId { get; set; }
        public string Name { get; set; }
        public string Discipline { get; set; }
        public string WheelchairClass { get; set; }
        public string RankingType { get; set; }
        public string AgeCategory { get; set; }
        public string Gender { get; set; }
        //XML minOccurs=0 to 1
        [NoUnboundCustom]
        [XmlElement("RankingItems", typeof(RankingItems))]
        public Collection<RankingItem> RankingItems { get; set; }
    }
}
