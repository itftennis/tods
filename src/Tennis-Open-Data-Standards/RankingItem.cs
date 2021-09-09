using System.Collections.ObjectModel;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Tennis_Open_Data_Standards
{
    [XmlRoot("RankingItems"), XmlType(TypeName = "RankingItems")]
    public class RankingItems
    {
        [XmlElement(IsNullable = false)]
        public Collection<RankingItem> RankingItem { get; set; }
    }
    public class RankingItem
    {
        //XML minOccurs=1 to 1
        [XmlElement(IsNullable = true)]        
        public string Type { get; set; }
        //XML minOccurs=1 to 1
        public int? SortOrder { get; set; }
        //XML minOccurs=1 to 1        
        [JsonProperty(Required = Required.Always)]
        public int Rank { get; set; }
        public string Result { get; set; }
        public string RankingItemCode { get; set; }
        public Person Person { get; set; }
        public Team Team { get; set; }
    }
}
