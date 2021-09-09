using System;
using System.Collections.ObjectModel;
using System.Xml.Serialization;
using Newtonsoft.Json;
using Tennis_Open_Data_Standards.Attributes;

namespace Tennis_Open_Data_Standards
{
    [Serializable()]
    [XmlRoot("Tournaments"), XmlType(TypeName = "Tournaments")]
    public class Tournaments
    {
        [XmlElement(IsNullable = false)]
        public Collection<Tournament> Tournament { get; set; }
    }

    /// <summary>    
    /// Please see the <see href="https://itftennis.atlassian.net/wiki/spaces/TODS/pages/1272873003/Introduction+to+the+Tournament">Introduction to the Tournament</see> document for more information> 
    /// </summary>
    public class Tournament : CommonElements
    {
        /// <summary>
        /// ProviderTournamentID
        /// </summary>
        /// <remarks>
        /// A unique tournament Identifier. 
        /// Please see the <see href="https://itftennis.atlassian.net/wiki/spaces/TODS/pages/1273102565/Including+Multiple+Identifiers">How to Include multiple Identifiers</see>
        /// </remarks>

        //XML minOccurs=1 to 1
        [XmlElement(IsNullable = false)]
        [JsonProperty(Required = Required.Always)]
        public string ProviderTournamentID { get; set; }
        /// <summary>
        /// UnifiedTournamentID
        /// </summary>
        /// <remarks>
        /// A unique tournament Identifier. 
        /// Please see the <see href="https://itftennis.atlassian.net/wiki/spaces/TODS/pages/1273102565/Including+Multiple+Identifiers">How to Include multiple Identifiers</see>
        /// </remarks>

        //XML minOccurs=1 to 1
        [XmlElement(IsNullable = false)]
        [JsonProperty(Required = Required.Always)]
        public string UnifiedTournamentID { get; set; }

        /// <summary>
        /// Tournament Groups
        /// </summary>
        /// <remarks>
        /// Which other tournaments is this related to. 
        /// For example it’s part of ATP Challenger Tour, WTA International, Grand Slam
        /// </remarks>

        //XML minOccurs=0 to 1
        [NoUnboundCustom]
        [XmlElement("TournamentGroups", typeof(TournamentGroups))]
        public Collection<TournamentGroup> TournamentGroups { get; set; }
        /// <summary>
        /// Tournament Level
        /// </summary>
        /// <remarks>
        /// Please see the 
        /// <see href="https://itftennis.atlassian.net/wiki/spaces/TODS/pages/1272873121/Tournament+Level">Tournament Level</see> document for more information
        /// </remarks>
        public string TournamentLevel { get; set; }
        /// <summary>
        /// Tournament Name
        /// </summary>
        /// <remarks>
        /// The name of the tournament.
        /// </remarks>
        public string TournamentName { get; set; }
        /// <summary>
        /// Formal Name
        /// </summary>
        /// <remarks>
        /// This is for the official name for the tournament agreed with the sanctioning body - for example ‘The Championships, Wimbledon 2019’
        /// </remarks>
        public string FormalName { get; set; }

        /// <summary>
        /// Promotional Name
        /// </summary>
        /// <remarks>
        /// This is for a media-friendly name that is used to promote the tournament, for example ‘Wimbledon 2019’
        /// </remarks>
        public string PromotionalName { get; set; }
        /// <summary>
        /// Venue
        /// </summary>
        /// <remarks>
        /// Please see <see cref="Venue">Venue</see> below
        /// </remarks>
        public Venue Venue { get; set; }
        /// <summary>
        /// The Address of the tournament
        /// </summary>
        /// <remarks>
        /// Please see <see cref="Address">TournamentAddresses</see>
        /// </remarks>

        //XML minOccurs=0 to 1
        [NoUnboundCustom]
        [XmlElement("TournamentAddresses", typeof(Addresses))]
        public Collection<Address> TournamentAddresses { get; set; }
        /// <summary>
        /// Contacts required for the tournament.
        /// </summary>
        /// <remarks>
        /// Please see <see cref="Contacts">TournamentContacts</see>
        /// </remarks>

        //XML minOccurs=0 to 1
        [NoUnboundCustom]
        [XmlElement("TournamentContacts", typeof(Contacts))] 
        public Collection<Contact> TournamentContacts { get; set; }
        /// <summary>
        /// List of person ID's for officials
        /// </summary>
        /// <remarks>
        /// Please see <see cref="TennisOfficials">TennisOfficials</see>
        /// </remarks>        
        [XmlElement("TennisOfficials", typeof(TennisOfficials))]
        public TennisOfficials TennisOfficials { get; set; }
        /// <summary>
        /// ScheduleItem 
        /// </summary>
        /// <remarks>
        /// Please see <see cref="ScheduleItem">ScheduleItem</see>
        /// </remarks>
        public ScheduleItem ScheduleItem { get; set; }
        /// <summary>
        /// Host Country Code
        /// </summary>
        /// <remarks>
        /// The Country Hosting the Tournament (ISO3166-3 standards). 
        /// Please see Wikipedia <see href="https://en.wikipedia.org/wiki/ISO_3166-1_alpha-3">ISO_3166-1_alpha-3</see>
        /// </remarks>
        public string HostCountryCode { get; set; }
        /// <summary>
        /// Start Date
        /// </summary>
        /// <remarks>
        /// The start date of the tournament
        /// </remarks>

        //XML minOccurs=0 to 1
        public DateTime? StartDate { get; set; }
        /// <summary>
        /// End Date
        /// </summary>
        /// <remarks>
        /// The end date of the tournament
        /// </remarks>

        //XML minOccurs=0 to 1
        public DateTime? EndDate { get; set; }
        /// <summary>
        /// Season
        /// </summary>
        /// <remarks>
        /// The Season in which the Tournament is run eg Summer 2019
        /// </remarks>
        public string Season { get; set; }
        /// <summary>
        /// Local Time Zone
        /// </summary>
        /// <remarks>
        /// The local time zone. This is useful as the start date doesn't carry time zone information.
        /// </remarks>
        public string LocalTimeZone { get; set; }
        /// <summary>
        /// Surface Category
        /// </summary>
        /// <remarks>
        /// Please see <see href="~SurfaceCategory">SurfaceCategory</see>
        /// </remarks>
        public string SurfaceCategory { get; set; }
        /// <summary>
        /// Surface Category
        /// </summary>
        /// <remarks>
        /// An indoor or outdoor tournament
        /// Please see <see href="~IndoorOutdoor">IndoorOutdoor</see>
        /// </remarks>
        public string IndoorOutdoor { get; set; }
        /// <summary>
        /// Entries Open
        /// </summary>
        /// <remarks>
        /// The date when entries open
        /// </remarks>

        //XML minOccurs=0 to 1
        public DateTime? EntriesOpen { get; set; }
        /// <summary>
        /// Entries Close
        /// </summary>
        /// <remarks>
        /// The date when entries close
        /// </remarks>

        //XML minOccurs=0 to 1
        public DateTime? EntriesClose { get; set; }
        /// <summary>
        /// Withdrawal Deadline
        /// </summary>
        /// <remarks>
        /// The data players can withdraw (usually before penalty)
        /// </remarks>

        //XML minOccurs=0 to 1
        public DateTime? WithdrawalDeadline { get; set; }
        /// <summary>
        /// Total Prize Money
        /// </summary>
        /// <remarks>
        /// The total amount of prize money given.
        /// </remarks>
        public TotalPrizeMoney TotalPrizeMoney { get; set; }
        /// <summary>
        /// Events
        /// </summary>
        /// <remarks>
        /// Please see <see cref="Events">Events</see>
        /// </remarks>

        //XML minOccurs=0 to 1
        [NoUnboundCustom]
        [XmlElement("Events", typeof(Events))]
        public Collection<Event> Events { get; set; }
        /// <summary>
        /// MatchUps
        /// </summary>
        /// <remarks>
        /// Please see <see cref="MatchUps">MatchUps</see>
        /// </remarks>

        //XML minOccurs=0 to 1
        [NoUnboundCustom]
        [XmlElement("MatchUps", typeof(MatchUps))]
        public Collection<MatchUp> MatchUps { get; set; }

        /// <summary>
        /// Any Coach, Official, Umpire or Player etc associated with the Tournament
        /// </summary>
        /// <remarks>
        /// Please see <see cref="Participants">Participants</see>
        /// </remarks>

        //XML minOccurs=0 to 1
        [NoUnboundCustom]
        [XmlElement("Participants", typeof(Participants))]
        public Collection<Participant> Participants { get; set; }
    }
}
