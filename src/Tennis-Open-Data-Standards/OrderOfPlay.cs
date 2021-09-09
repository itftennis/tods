using System;
using System.Collections.ObjectModel;
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
    public class OrderOfPlay : CommonElements
    {        
        [JsonProperty(Required = Required.Always)]
        //XML minOccurs=1 to 1
        [XmlElement(IsNullable = true)]
        public string OrderOfPlayId { get; set; }
        public ScheduleItem ScheduleItem { get; set; }
        public string Name { get; set; }
        public DateTime? StartDate { get; set; }        
        public string LocalTimeZone { get; set; }
        public Venue Venue { get; set; }
        [NoUnboundCustom]
        [XmlElement("OrderOfPlayItems", typeof(OrderOfPlayItems))]
        //XML minOccurs=0 to 1
        public Collection<OrderOfPlayItem> OrderOfPlayItems { get; set; }
    }
}
