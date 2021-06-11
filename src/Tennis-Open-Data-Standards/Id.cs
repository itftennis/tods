using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Tennis_Open_Data_Standards
{
    public class Ids
    {

        [XmlElement("Id")]
        [JsonProperty(Required = Required.Always)]
        public string[] Id { get; set; }
    }

}
