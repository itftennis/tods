using System.Collections.ObjectModel;
using System.Xml.Serialization;

namespace Tennis_Open_Data_Standards
{
    [XmlRoot("Rounds"), XmlType(TypeName = "Rounds")]
    public class Rounds
    {
        [XmlElement(IsNullable = false)]
        public Collection<Round> Round { get; set; }
    }
    public class Round
    {
        public int RoundNumber { get; set; }
        [XmlElement("RoundItems", typeof(RoundItems))]
        public Collection<RoundItem> RoundItems { get; set; }
    }
}
