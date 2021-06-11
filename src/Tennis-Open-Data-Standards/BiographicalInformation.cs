namespace Tennis_Open_Data_Standards
{
    /// <summary>
    /// BiographicalInformation
    /// </summary>
    /// <remarks>
    /// Further information about the person, usually a player
    /// </remarks>
    public class BiographicalInformation
    {
        /// <summary>
        /// BirthCountryCode
        /// </summary>
        /// <remarks>
        /// The Country a Person was born (ISO3166-3 standards). Please see Wikipedia <see href="https://en.wikipedia.org/wiki/ISO_3166-1_alpha-3"> ISO_3166-1_alpha-3</see>
        /// </remarks>
        public string BirthCountryCode { get; set; }
        /// <summary>
        /// ResidenceCountryCode
        /// </summary>
        /// <remarks>
        /// The Country the Person currently resides (ISO3166-3 standards). Please see Wikipedia <see href="https://en.wikipedia.org/wiki/ISO_3166-1_alpha-3"> ISO_3166-1_alpha-3</see>
        /// </remarks>
        public string ResidenceCountryCode { get; set; }
        /// <summary>
        /// PlaceOfResidence
        /// </summary>
        /// <remarks>
        /// To be presented as city / province / state / region
        /// </remarks>
        public string PlaceOfResidence { get; set; }
        /// <summary>
        /// Height
        /// </summary>
        /// <remarks>
        /// Height in Centimeters
        /// </remarks>

        //XML minOccurs=0 to 1
        public decimal? Height { get; set; }
        /// <summary>
        /// Weight
        /// </summary>
        /// <remarks>
        /// Weight in Kilograms
        /// </remarks>

        //XML minOccurs=0 to 1
        public decimal? Weight { get; set; }
        /// <summary>
        /// PlayingHandCode
        /// </summary>
        /// <remarks>
        /// Please see <see href="~PlayingHandCode">PlayingHandCode</see>
        /// </remarks>
        public string PlayingHand { get; set; }
        /// <summary>
        /// DoublePlayingHandCode
        /// </summary>
        /// <remarks>
        /// Please see <see href="~PlayingDoubleHandCode">PlayingDoubleHandCode</see>
        /// </remarks>
        public string DoublePlayingHand { get; set; }
        /// <summary>
        /// AgeBeganTennis
        /// </summary>
        /// <remarks>
        /// The age a person started playing tennis
        /// </remarks>
        public string AgeBeganTennis { get; set; }
        /// <summary>
        /// AgeTurnedPro
        /// </summary>
        /// <remarks>
        /// The age a person became a professional tennis player.
        /// </remarks>
        public string AgeTurnedPro { get; set; }
        /// <summary>
        /// Coach
        /// </summary>
        /// <remarks>
        /// The player's coach / head coach (if they have more than one). This links to their person record.
        /// Please see <see cref="Person">Coach (Person)</see>
        /// </remarks>
        public Person Coach { get; set; }
        /// <summary>
        /// Club
        /// </summary>
        /// <remarks>
        /// The player's coach / head coach (if they have more than one). This links to their person record.
        /// Please see <see cref="Organisation">Club (Organisation)</see>
        /// </remarks>
        public Organisation Club { get; set; }
    }
}
