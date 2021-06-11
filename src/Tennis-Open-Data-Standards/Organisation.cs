using System.Collections.ObjectModel;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Tennis_Open_Data_Standards
{
        [XmlRoot("Organisations"), XmlType(TypeName = "Organisations")]
        public class Organisations
        {
            [XmlElement(IsNullable = false)]
            public Collection<Organisation> Organisation { get; set; }
        }
        public class Organisation : CommonElements
    {
        //XML minOccurs=1 to 1
        [JsonProperty(Required = Required.Always)]
        public string OrganisationId { get; set; }
        public string OrganisationType { get; set; }
        public string Name { get; set; }

        //XML minOccurs=0 to 1
        [XmlElement("Addresses", typeof(Addresses))]
        public Collection<Address> Addresses { get; set; }
        public string Website { get; set; }
    }
}
