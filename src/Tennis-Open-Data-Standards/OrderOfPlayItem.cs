using System;
using System.Collections.ObjectModel;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Tennis_Open_Data_Standards
{
    [XmlRoot("OrderOfPlayItems"), XmlType(TypeName = "OrderOfPlayItems")]
    public class OrderOfPlayItems
    {
        [XmlElement(IsNullable = false)]
        public Collection<OrderOfPlayItem> OrderOfPlayItem { get; set; }
    }
    public class OrderOfPlayItem : CommonElements
    {
        //XML minOccurs=1 to 1
        [JsonProperty(Required = Required.Always)]
        public string OrderOfPlayItemId { get; set; }
        public string Name { get; set; }
        //XML minOccurs=0 to 1
        public DateTime? StartDate { get; set; }
        //XML minOccurs=0 to 1
        public DateTime? EndDate { get; set; }        
        public string StartType { get; set; }
        public string EndType { get; set; }
        //XML minOccurs=0 to 1
        public int? StartDelay { get; set; }        
        public ScheduleItem ScheduleItem { get; set; }
        public OrderOfPlayItem PreviousOrderOfPlayItem { get; set; }
        public string Description { get; set; }

        // Needs Revisiting ?
        //public Tournament Tournament { get; set; }
        //public Match Match { get; set; }
        //public Tie Tie { get; set; }
    }
}
