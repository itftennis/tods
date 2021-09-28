using System;
using System.Collections.ObjectModel;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Tennis_Open_Data_Standards
{
    [XmlRoot("Courts", IsNullable = false), XmlType(TypeName = "Courts")]
    public class Courts
    {
        [XmlElement(IsNullable = false)]
        public Collection<Court> Court { get; set; }
    }
    public class Court : CommonElements
        {
        /// <summary>
        /// CourtId
        /// </summary>
        /// <remarks>
        /// An identifier for the court. 
        /// Please see the <see href="https://itftennis.atlassian.net/wiki/spaces/TODS/pages/1273102565/Including+Multiple+Identifiers">How to Include multiple Identifiers</see>
        /// </remarks>

        //XML minOccurs=1 to 1        
        [XmlElement(IsNullable = true)]
        [JsonProperty(Required = Required.Always)]
        public string CourtId { get; set; }
        /// <summary>
        /// SurfaceCategory
        /// </summary>
        /// <remarks>
        /// Please see <see href="~SurfaceCategory">SurfaceCategory</see>
        /// </remarks>
        public string SurfaceCategory { get; set; }
        /// <summary>
        /// SurfaceType
        /// </summary>
        /// <remarks>
        /// Please see the <see href="https://www.itftennis.com/technical/courts/surface-type.aspx">ITF Technical website ITF Surface Types</see> for more information.
        /// </remarks>
        public string SurfaceType { get; set; }
        /// <summary>
        /// Pace
        /// </summary>
        /// <remarks>
        /// Please see the <see href="https://www.itftennis.com/technical/courts/classified-surfaces/about-court-pace-classification.aspx">ITF Court Pace Classification </see> for more information.
        /// </remarks>
        public string Pace { get; set; }
        /// <summary>
        /// CourtDimensions
        /// </summary>
        /// <remarks>
        /// Majority of cases will be STANDARD. The field will accept any metric e.g.red, standard, or measured in feet / inches, meters or cm. 
        /// </remarks>
        public string CourtDimensions { get; set; }
        /// <summary>
        /// Latitude
        /// </summary>
        /// <remarks>
        /// Latitude as per Google Maps eg <strong>51°27'32.2"N</strong> 0°15'19.0"W OR <strong>51.458947</strong>, -0.255283
        /// </remarks>
        public string Latitude { get; set; }
        /// <summary>
        /// Longitude
        /// </summary>
        /// <remarks>
        /// Longitude as per Google Maps eg 51°27'32.2"N <strong>0°15'19.0"W</strong> OR 51.458947, <strong>-0.255283</strong>
        /// </remarks>
        public string Longitude { get; set; }
        /// <summary>
        /// Altitude
        /// </summary>
        /// <remarks>
        /// Height in feet above sea level
        /// </remarks>
        public string Altitude { get; set; }
        /// <summary>
        /// SurfacedDate
        /// </summary>
        /// <remarks>
        /// The date the surface was installed or resurfaced
        /// </remarks>

        //XML minOccurs=0 to 1
        public DateTime? SurfacedDate { get; set; }            
        
    }    
}
