using System.Collections.ObjectModel;
using System.Xml.Serialization;
using Newtonsoft.Json;
using Tennis_Open_Data_Standards.Attributes;

namespace Tennis_Open_Data_Standards
{
    [NoUnboundCustom]
    [XmlRoot("Organisations"), XmlType(TypeName = "Organisations")]
    public class Organisations
    {
        [XmlElement(IsNullable = false)]
        public Collection<Organisation> Organisation { get; set; }
    }
    public class Organisation : CommonElements
    {
        //XML minOccurs=1 to 1
        [XmlElement(IsNullable = true)]
        [JsonProperty(Required = Required.Always)]
        public string OrganisationId { get; set; }
        public string OrganisationType { get; set; }
        public string Name { get; set; }

        //XML minOccurs=0 to 1
        [NoUnboundCustom]
        [XmlElement("Addresses", typeof(Addresses))]
        public Collection<Address> Addresses { get; set; }
        public string Website { get; set; }
    }
}
