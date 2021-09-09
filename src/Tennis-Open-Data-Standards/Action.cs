using System;
using System.Collections.ObjectModel;
using System.Xml.Serialization;

namespace Tennis_Open_Data_Standards
{
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
