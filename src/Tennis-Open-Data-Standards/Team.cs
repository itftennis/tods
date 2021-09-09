using System.Collections.ObjectModel;
using System.Xml.Serialization;
using Newtonsoft.Json;
using Tennis_Open_Data_Standards.Attributes;

namespace Tennis_Open_Data_Standards
{
    [XmlRoot("Teams"), XmlType(TypeName = "Teams")]
    public class Teams
    {
        [XmlElement(IsNullable = false)]
        public Collection<Team> Team { get; set; }
    }
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// A collection of persons forming one side of a MatchUp, competition or tournament
    /// </remarks>
    public class Team : CommonElements
    {
        /// <summary>
        /// TeamId
        /// </summary>
        /// <remarks>
        /// A unique team Identifier. Please see the <see href="https://itftennis.atlassian.net/wiki/spaces/TODS/pages/1273102565/Including+Multiple+Identifiers">How to Include multiple Identifiers</see>
        /// </remarks>

        //XML minOccurs=1 to 1
        [XmlElement(IsNullable = true)]
        [JsonProperty(Required = Required.Always)]
        public string TeamId { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        /// <remarks>
        /// Uses ASCII only, based on ICAO and ISO/IEC 7501-1 standards. Please see the <see href="https://itftennis.atlassian.net/wiki/spaces/TODS/pages/1272938619/Transliteration+of+Names+to+Latin+Script">Transliteration of Names to Latin Script</see> document
        /// <seealso href="https://en.wikipedia.org/wiki/Machine-readable_passport" />
        /// <seealso href="https://www.iso.org/standard/45562.html" />        /// </remarks>
        public string Name { get; set; }
        /// <summary>
        /// NativeTeamName
        /// </summary>
        /// <remarks>
        /// Unicode. Please see the <see href="https://itftennis.atlassian.net/wiki/spaces/TODS/pages/1272938619/Transliteration+of+Names+to+Latin+Script">Transliteration of Names to Latin Script</see> document
        /// </remarks>
        public string NativeTeamName { get; set; }
        /// <summary>
        /// Gender
        /// </summary>
        /// <remarks>
        /// Please see <see href="~Gender">Gender</see>
        /// </remarks>
        public string Gender { get; set; }
        /// <summary>
        /// Organisation
        /// </summary>
        /// <remarks>
        /// The organisation that the team represents i.e. club, school, company, national association 
        /// </remarks>
        public Organisation Organisation { get; set; }
        /// <summary>
        /// OtherNames
        /// </summary>
        /// <remarks>
        /// Names not captured by the above e.g. nicknames
        /// </remarks>
        public string OtherNames { get; set; }
        /// <summary>
        /// PreviousNames
        /// </summary>
        /// <remarks>
        /// Previous name the team has been known by.
        /// </remarks>
        public string PreviousNames { get; set; }
        /// <summary>
        /// OnlineProfiles
        /// </summary>
        /// <remarks>
        /// Please see the <see cref="OnlineProfile">OnlineProfile</see>
        /// </remarks>

        //XML minOccurs=0 to 1
        [NoUnboundCustom]
        [XmlElement("OnlineProfiles", typeof(OnlineProfiles))]
        public Collection<OnlineProfile> OnlineProfiles { get; set; }


        // ?? TODS discussion
        //public Collection<MatchUp> MatchUps { get; set; }
        // ?? TODS discussion
        //public Collection<Tournament> Tournaments { get; set; }
    }
}
