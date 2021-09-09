namespace Tennis_Open_Data_Standards
{
    /// <summary>
    /// GoesTo
    /// </summary>
    /// <remarks>
    /// Where the winning or losing participant 'goes' in a draw.
    /// </remarks>
    public class GoesTo
    {
        /// <summary>
        /// StageId
        /// </summary>
        /// <remarks>
        /// The stage the winning or losing participant goes to.
        /// </remarks>
        public string StageId { get; set; }
        /// <summary>
        /// EventId
        /// </summary>
        /// <remarks>
        /// The event the winning or losing participant goes to.
        /// </remarks>
        public string EventId { get; set; }
        /// <summary>
        /// DrawId
        /// </summary>
        /// <remarks>
        /// The draw the winning or losing participant goes to.
        /// </remarks>
        public string DrawId { get; set; }
        /// <summary>
        /// MatchUpId
        /// </summary>
        /// <remarks>
        /// The MatchUp the winning or losing participant goes to.
        /// </remarks>
        public string MatchUpId { get; set; }
        /// <summary>
        /// RoundNumber
        /// </summary>
        /// <remarks>
        /// The round within the draw the winning or losing participant goes to.
        /// </remarks>
        public int RoundNumber { get; set; }
        /// <summary>
        /// Position
        /// </summary>
        /// <remarks>
        /// The position within the round the winning or losing participant goes to.
        /// </remarks>
        public int Position { get; set; }
    }
}
