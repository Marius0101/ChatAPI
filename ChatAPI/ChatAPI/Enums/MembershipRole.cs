namespace ChatAPI.Enums 
{
    /// <summary>
    /// User permited action in a space.
    /// </summary>
    public enum MembershipRole
    {
        /// <summary>
        /// Default Value.
        /// Used for people that aren't member of a space, but can be invited.
        /// </summary>
        Unspecified,

        /// <summary>
        /// The user hase the basic permissions, like sending messages to the space.
        /// </summary>
        Role_Member,

        /// <summary>
        /// The user has all basic permissions plus administrative permissions to the space.
        /// Administrative permissions like adding or removing members
        /// Only work in a Group_chat space type.
        /// </summary>
        Role_Manger,
    }
}