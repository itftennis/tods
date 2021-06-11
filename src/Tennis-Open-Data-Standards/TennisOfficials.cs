using System.Collections.ObjectModel;
using System.Xml.Serialization;

namespace Tennis_Open_Data_Standards
{
    public class TennisOfficials
    {
        [XmlElement("TennisOfficial", typeof(Participant))]
        public Collection<Participant> TennisOfficial { get; set; }
    }
}
