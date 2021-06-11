using System;
using Newtonsoft.Json;

namespace Tennis_Open_Data_Standards
{
    public class ScheduleItem : CommonElements
    {
        //XML minOccurs=1 to 1
        [JsonProperty(Required = Required.Always)]
        public string ScheduleItemId { get; set; }
        public ScheduleItem ParentScheduleItem { get; set; }
        public string Name { get; set; }
        //XML minOccurs=0 to 1
        public DateTime StartDate { get; set; }
        //XML minOccurs=0 to 1
        public DateTime EndDate { get; set; }                
        public string LocalTimeZone { get; set; }
        public string Description { get; set; }
    }
}
