using System.Collections.ObjectModel;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Tennis_Open_Data_Standards
{
    [XmlRoot("Participants"), XmlType(TypeName = "Participants")]
    public class Participants
    {
        [XmlElement(IsNullable = false)]
        public Collection<Participant> Participant { get; set; }
    }


    [XmlRoot("Members"), XmlType(TypeName = "Members")]
    public class Members
    {
        [XmlElement(IsNullable = false)]
        public Collection<Participant> Member { get; set; }
    }

    //[XmlRoot("TennisOfficials"), XmlType(TypeName = "TennisOfficials")]
    //public class TennisOfficials
    //{
    //    [XmlElement(IsNullable = false)]
    //    public Collection<Participant> TennisOfficial { get; set; }
    //}

    public class Participant : CommonElements
    {
        /// <summary>
        /// Participant Id
        /// </summary>
        /// <remarks>
        /// A unique Participant identifier. 
        /// Please see the <see href="https://itftennis.atlassian.net/wiki/spaces/TODS/pages/1273102565/Including+Multiple+Identifiers">How to Include multiple Identifiers</see>
        /// </remarks>

        //XML minOccurs=1 to 1
        [JsonProperty(Required = Required.Always)]
        public string ParticipantId { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        /// <remarks>
        /// For pair or team this is the full name. For individuals this is preferred family name.
        /// </remarks>
        public string Name { get; set; }
        /// <summary>
        /// PreferredGivenName
        /// </summary>
        /// <remarks>
        /// For individuals this is preferred given name
        /// </remarks>
        public string PreferredGivenName { get; set; }
        /// <summary>
        /// ParticipantType
        /// </summary>
        /// <remarks>
        /// Please see <see href="~ParticipantType">ParticipantType</see>
        /// </remarks>
        public string ParticipantType { get; set; }
        /// <summary>
        /// Representing
        /// </summary>
        /// <remarks>
        /// The nationality the participant is representing (ISO3166-3 standards). Please see Wikipedia <see href="https://en.wikipedia.org/wiki/ISO_3166-1_alpha-3"> ISO_3166-1_alpha-3</see>
        /// </remarks>
        public string Representing { get; set; }
        /// <summary>
        /// Person
        /// </summary>
        /// <remarks>
        /// Please see <see cref="Person">Person</see>
        /// </remarks>
        public Person Person { get; set; }
        /// <summary>
        /// Team
        /// </summary>
        /// <remarks>
        /// Please see <see cref="Team">Team</see>
        /// </remarks>
        public Team Team { get; set; }
        /// <summary>
        /// ParticipantStatus
        /// </summary>
        /// <remarks>
        /// Please see <see href="~ParticipantStatus">ParticipantStatus</see>
        /// </remarks>
        public string ParticipantStatus { get; set; }
        /// <summary>
        /// ParticipantRole
        /// </summary>
        /// <remarks>
        /// Please see <see href="~ParticipantRole">ParticipantRole</see>
        /// </remarks>
        public string ParticipantRole { get; set; }
        /// <summary>
        /// Members
        /// </summary>
        /// <remarks>
        /// For SQUAD, TEAM or PAIR. An array of all participants that form part of this record.
        /// Please see <see cref="Members">Members</see>
        /// </remarks>

        //XML minOccurs=0 to 1
        [XmlElement("Members", typeof(Members))]
        public Collection<Participant> Members { get; set; }
    }
}
