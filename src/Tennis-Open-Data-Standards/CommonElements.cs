using System;
using System.Collections.ObjectModel;
using System.Xml.Serialization;
using Tennis_Open_Data_Standards.Attributes;

namespace Tennis_Open_Data_Standards
{    
    public class CommonElements
    {        
        public DateTime? Updated { get; set; }
        //public bool UpdatedSpecified { get { return Updated != null; } }
        [XmlElement("Ids", typeof(Ids))]
        public Ids Ids { get; set; }
        public string Notes { get; set; }
        [NoUnboundCustom]
        [XmlElement("Extensions", typeof(Extensions))]
        public Collection<Extension> Extensions { get; set; }
    }
}
