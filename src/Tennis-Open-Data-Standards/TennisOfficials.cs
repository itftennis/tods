using System.Collections.ObjectModel;
using System.Xml.Serialization;
using Tennis_Open_Data_Standards.Attributes;

namespace Tennis_Open_Data_Standards
{
    [NoUnboundCustom]
    public class TennisOfficials
    {
        [XmlElement("TennisOfficial", typeof(Participant))]
        public Collection<Participant> TennisOfficial { get; set; }
    }
}
