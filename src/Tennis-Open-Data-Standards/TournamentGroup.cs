using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;
using Tennis_Open_Data_Standards.Attributes;

namespace Tennis_Open_Data_Standards
{
    [NoUnboundCustom]
    [XmlRoot("TournamentGroups"), XmlType(TypeName = "TournamentGroups")]
    public class TournamentGroups
    {
        [XmlElement(IsNullable = false)]
        public Collection<TournamentGroup> TournamentGroup { get; set; }
    }

    public class TournamentGroup
    {
        [Key]
        public string TournamentGroupId { get; set; }
        public string Group { get; set; }
    }
}
