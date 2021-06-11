using System.Collections.ObjectModel;
using System.Xml.Serialization;

namespace Tennis_Open_Data_Standards
{
    public class TotalPrizeMoney
    {
        [XmlElement("PrizeMoney", typeof(PrizeMoney))]
        public Collection<PrizeMoney> PrizeMoney { get; set; }
    }
}
