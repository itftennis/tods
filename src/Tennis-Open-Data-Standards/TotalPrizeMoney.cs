using System.Collections.ObjectModel;
using System.Xml.Serialization;
using Tennis_Open_Data_Standards.Attributes;

namespace Tennis_Open_Data_Standards
{
    [NoUnboundCustom]
    public class TotalPrizeMoney
    {
        [XmlElement("PrizeMoney", typeof(PrizeMoney))]
        public Collection<PrizeMoney> PrizeMoney { get; set; }
    }
}
