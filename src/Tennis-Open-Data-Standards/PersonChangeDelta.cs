using System;
using System.Collections.ObjectModel;
using System.Xml.Serialization;
using Tennis_Open_Data_Standards.Attributes;

namespace Tennis_Open_Data_Standards
{
    [NoUnboundCustom]
    [XmlRoot("Upsert"), XmlType(TypeName = "Upsert")]
    public class Upserted
    {
        [XmlElement(IsNullable = false)]
        public Collection<Upsert> Upsert { get; set; }
    }
    public class Upsert
    {
        public string UpsertedOrganisationID { get; set; }
        public string UpsertedClientID { get; set; }
        public DateTime UpsertDateTime { get; set; }
        public Collection<Person> Person { get; set; }
    }

    [NoUnboundCustom]
    [XmlRoot("Deleted"), XmlType(TypeName = "Deleted")]
    public class Deleted
    {
        [XmlElement(IsNullable = false)]
        public Collection<Delete> Delete { get; set; }
    }
    public class Delete
    {
        public string DeletedOrganisationID { get; set; }
        public string DeletedClientID { get; set; }
        public DateTime DeletedDateTime { get; set; }
        public string TennisId { get; set; }
    }


    [NoUnboundCustom]
    [XmlRoot("Merged"), XmlType(TypeName = "Merged")]
    public class Merged
    {
        [XmlElement(IsNullable = false)]
        public Collection<Merge> Merge { get; set; }
    }
    public class Merge
    {
        public string MergedOrganisationID { get; set; }
        public string MergedClientID { get; set; }
        public DateTime MergedDateTime { get; set; }
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
