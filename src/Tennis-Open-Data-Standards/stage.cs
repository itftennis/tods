using System.Collections.ObjectModel;
using System.Xml.Serialization;
using Newtonsoft.Json;
using Tennis_Open_Data_Standards.Attributes;

namespace Tennis_Open_Data_Standards
{
    [NoUnboundCustom]
    [XmlRoot("Stages"), XmlType(TypeName = "Stages")]
    public class Stages
    {
        [XmlElement(IsNullable = false)]
        public Collection<Stage> Stage { get; set; }
    }
    public class Stage
    {
        //XML minOccurs=1 to 1
        [XmlElement(IsNullable = true)]
        [JsonProperty(Required = Required.Default)]
        public string StageId { get; set; }

        //XML minOccurs=0 to 1
        public int? SortOrder { get; set; }        
        public string Name { get; set; }
        public string StageType { get; set; }

        //XML minOccurs=0 to 1
        [NoUnboundCustom]
        [XmlElement("Entries", typeof(Entries))]
        public Collection<Entry> Entries { get; set; }

        //XML minOccurs=0 to 1
        [NoUnboundCustom]
        [XmlElement("Draws", typeof(Draws))]
        public Collection<Draw> Draws { get; set; }
    }
}
