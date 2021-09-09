using System;
using System.Collections.ObjectModel;
using System.Xml.Serialization;
using Newtonsoft.Json;
using Tennis_Open_Data_Standards.Attributes;

namespace Tennis_Open_Data_Standards
{
    [NoUnboundCustom]
    [XmlRoot("ScheduleItems"), XmlType(TypeName = "ScheduleItems")]
    public class ScheduleItems
    {
        [XmlElement(IsNullable = false)]
        public Collection<ScheduleItem> ScheduleItem { get; set; }
    }

    public class ScheduleItem : CommonElements
    {
        //XML minOccurs=1 to 1
        [XmlElement(IsNullable = true)]
        [JsonProperty(Required = Required.Always)]
        public string ScheduleItemId { get; set; }
        public ScheduleItem ParentScheduleItem { get; set; }
        public string Name { get; set; }
        //XML minOccurs=0 to 1
        public DateTime? StartDate { get; set; }
        //XML minOccurs=0 to 1
        public DateTime? EndDate { get; set; }
        public string LocalTimeZone { get; set; }
        public string Description { get; set; }
    }
}