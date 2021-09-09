using System.Collections.ObjectModel;
using System.Xml.Serialization;
using Tennis_Open_Data_Standards.Attributes;

namespace Tennis_Open_Data_Standards
{
    [NoUnboundCustom]
    [XmlRoot("Statistics"), XmlType(TypeName = "Statistics")]
    public class Statistics
    {
        [XmlElement(IsNullable = false)]
        public Collection<Statistic> Statistic { get; set; }
    }
    public class Statistic : CommonElements
    {
        /// <summary>
        /// Name
        /// </summary>
        /// <remarks>
        /// The name of the statistic eg Aces
        /// </remarks>
        public string Name { get; set; }
        public string Code { get; set; }
        public string Value { get; set; }
    }
}
