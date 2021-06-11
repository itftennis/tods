using System.Collections.ObjectModel;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Tennis_Open_Data_Standards
{
        [XmlRoot("Statistics"), XmlType(TypeName = "Statistics")]
        public class Statistics
        {
            [XmlElement(IsNullable = false)]
            public Collection<Statistic> Statistic { get; set; }
        }
        public class Statistic : CommonElements
    {
        //XML minOccurs=1 to 1
        [JsonProperty(Required = Required.Always)]
        public string StatisticId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Value { get; set; }
    }
}
