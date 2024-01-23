namespace ChatAPI.Enums
{
    /// <summary>
    /// The history state for messages.
    /// Specifies how long messages are kept after creation.
    /// </summary>
    public enum HistoryState
    {
        /// <summary>
        /// Default value.
        /// </summary>
        Unspecified,

        /// <summary>
        /// History off.
        /// Messagesare kept for 24 hours.
        /// </summary>
        History_Off,

        /// <summary>
        /// History on.
        /// The admin specify for how long messages are kept.
        /// </summary>
        History_On

    }
}
