namespace ChatAPI.Enums
{
    /// <summary>
    /// Represents the type of space in a chat system.
    /// </summary>
    public enum SpaceType
    {
        /// <summary>
        /// Default value.
        /// </summary>
        Unspecified,

        /// <summary>
        /// Group conversations between 3 or more people. 
        /// A Group_chat can include Chat apps.
        /// </summary>
        Group_chat,

        /// <summary>
        /// 1:1 messages between two humans or a human and a Chat app.
        /// </summary>
        Direct_chat,
    }
}
