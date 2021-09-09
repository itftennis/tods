using System;
using System.Collections.ObjectModel;
using System.Xml.Serialization;
using Tennis_Open_Data_Standards.Attributes;

namespace Tennis_Open_Data_Standards
{
    [NoUnboundCustom]
    [XmlRoot("Upserted"), XmlType(TypeName = "Upserted")]
    public class Upserted
    {
        [XmlElement(IsNullable = false)]
        public Collection<UpsertedItem> UpsertedItems { get; set; }
    }
    public class UpsertedItem
    {
        public string OrganisationID { get; set; }
        public string ClientID { get; set; }
        public DateTime DateTime { get; set; }
        public Collection<Person> Person { get; set; }
    }

    [NoUnboundCustom]
    [XmlRoot("Deleted"), XmlType(TypeName = "Deleted")]
    public class Deleted
    {
        [XmlElement(IsNullable = false)]
        public Collection<DeletedItem> DeletedItems { get; set; }
    }
    public class DeletedItem
    {
        public string OrganisationID { get; set; }
        public string ClientID { get; set; }
        public DateTime DateTime { get; set; }
        public string TennisId { get; set; }
    }


    [NoUnboundCustom]
    [XmlRoot("Merged"), XmlType(TypeName = "Merged")]
    public class Merged
    {
        [XmlElement(IsNullable = false)]
        public Collection<MergedItem> MergedItems { get; set; }
    }
    public class MergedItem
    {
        public string OrganisationID { get; set; }
        public string ClientID { get; set; }
        public DateTime DateTime { get; set; }
        public string KeeperTennisId { get; set; }
        public string RemoverTennisId { get; set; }
    }



    public class PersonChangeDelta
    {
        /// <summary>
        /// Upserted
        /// </summary>
        /// <remarks>
        /// Please see <see cref="Upserted">Upserted</see>
        /// </remarks>
        [NoUnboundCustom]
        [XmlElement("Upserted", typeof(Upserted))]
        public Collection<Upserted> Upserted { get; set; }
        /// <summary>
        /// Deleted
        /// </summary>
        /// <remarks>
        /// Please see <see cref="Deleted">Deleted</see>
        /// </remarks>
        [NoUnboundCustom]
        [XmlElement("Deleted", typeof(Deleted))] 
            public Collection<Deleted> Deleted { get; set; }
        /// <summary>
        /// Merged
        /// </summary>
        /// <remarks>
        /// Please see <see cref="Merged">Merged</see>
        /// </remarks>
        [NoUnboundCustom]
        [XmlElement("Merged", typeof(Merged))]
        public Collection<Merged> Merged { get; set; }
    }
}
