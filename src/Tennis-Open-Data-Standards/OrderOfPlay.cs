using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;
using Newtonsoft.Json;
using Tennis_Open_Data_Standards.Attributes;

namespace Tennis_Open_Data_Standards
{
    [NoUnboundCustom]
    [XmlRoot("OrderOfPlays"), XmlType(TypeName = "OrderOfPlays")]
    public class OrderOfPlays
    {
        [XmlElement(IsNullable = false)]
        public Collection<OrderOfPlay> OrderOfPlay { get; set; }
    }
    public class OrderOfPlay
    {
        [Key]
        [JsonProperty(Required = Required.Always)]
        //XML minOccurs=1 to 1
        public string OrderOfPlayId { get; set; }
        public CommonElements CommonElements { get; set; }        
        public ScheduleItem ScheduleItem { get; set; }
        public string Name { get; set; }
        public DateTime? StartDate { get; set; }        
        public string LocalTimeZone { get; set; }
        public Venue Venue { get; set; }
        [XmlElement("OrderOfPlayItems", typeof(OrderOfPlayItems))]
        //XML minOccurs=0 to 1
        public Collection<OrderOfPlayItem> OrderOfPlayItems { get; set; }
    }
}
