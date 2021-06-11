using System.Collections.ObjectModel;
using System.Xml.Serialization;

namespace Tennis_Open_Data_Standards
{
    [XmlRoot("RoundItems"), XmlType(TypeName = "RoundItems")]
    public class RoundItems
    {
        [XmlElement(IsNullable = false)]
        public Collection<RoundItem> RoundItem { get; set; }
    }
    public class RoundItem
    {
        public int Position { get; set; }
        public GoesTo WinnerGoesTo { get; set; }
        public GoesTo LoserGoesTo { get; set; }
    }
}
