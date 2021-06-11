﻿using System.Collections.ObjectModel;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Tennis_Open_Data_Standards
{
    [XmlRoot("Venues"), XmlType(TypeName = "Venues")]
    public class Venues
    {
        [XmlElement(IsNullable = false)]
        public Collection<Venue> Venue { get; set; }
    }
    public class Venue : CommonElements
    {
        //XML minOccurs=1 to 1
        [JsonProperty(Required = Required.Always)]
        public string VenueId { get; set; }
        public string VenueType { get; set; }
        public string Name { get; set; }

        //XML minOccurs=0 to 1
        [XmlElement("Addresses", typeof(Addresses))]
        public Collection<Address> Addresses { get; set; }
        public string Website { get; set; }

        //XML minOccurs=0 to 1
        [XmlElement("Courts", typeof(Courts))]
        public Collection<Court> Courts { get; set; }

        //XML minOccurs=0 to 1
        [XmlElement("SubVenue", typeof(Venue))]
        public Collection<Venue> SubVenue { get; set; }
    }
}
