using System;
using System.Collections.ObjectModel;
using System.Xml.Serialization;
using Newtonsoft.Json;
using Tennis_Open_Data_Standards.Attributes;

namespace Tennis_Open_Data_Standards
{

    [XmlRoot("WorldTennisNumbers"), XmlType(TypeName = "WorldTennisNumbers")]
    public class WorldTennisNumbers
    {
        [XmlElement(IsNullable = false)]
        public Collection<WorldTennisNumber> WorldTennisNumber { get; set; }
    }
    public class WorldTennisNumber : CommonElements
    {

        //XML minOccurs=1 to 1
        [XmlElement(IsNullable = true)]
        [JsonProperty(Required = Required.Always)]
        public string TennisId { get; set; }
        [JsonProperty(Required = Required.Always)]
        //XML minOccurs=1 to 1        
        public decimal TennisNumber { get; set; }
        [JsonProperty(Required = Required.Always)]
        //XML minOccurs=1 to 1
        [XmlElement(IsNullable = true)]
        public string WorldTennisNumberType { get; set; }
        [JsonProperty(Required = Required.Always)]

        //XML minOccurs=1 to 1        
        public decimal Confidence { get; set; }
        [JsonProperty(Required = Required.Always)]

        //XML minOccurs=1 to 1        
        public DateTime RatingDate { get; set; }
        
        //XML minOccurs=0 to 1        
        [NoUnboundCustom]
        [XmlElement("MatchUps", typeof(MatchUps))]
        public Collection<MatchUp> MatchUps { get; set; }
    }
}