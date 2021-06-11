using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;
using Tennis_Open_Data_Standards.Attributes;

namespace Tennis_Open_Data_Standards
{
    [NoUnboundCustom]
    [XmlRoot("Actions"), XmlType(TypeName = "Actions")]
    public class Actions
    {
        [XmlElement(IsNullable = false)]
        public Collection<Action> Action { get; set; }
    }
    /// <summary>
    /// Action
    /// </summary>
    /// <remarks>
    /// 
    /// Please see the <see href=""></see>
    /// </remarks>
    public class Action
    {
        [Key]
        public string ActionId { get; set; }
        public string SortOrder { get; set; }
        public DateTime? Timestamp { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string Outcome { get; set; }
        public string ServingSide { get; set; }
        public string ServingPlayer { get; set; }
        public Set Set { get; set; }
        public Game Game { get; set; }
        public Point Point { get; set; }

    }
}
