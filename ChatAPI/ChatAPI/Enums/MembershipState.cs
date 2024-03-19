
namespace ChatAPI.Enums
{
    /// <summary>
    /// Specifies the member's relationship with a space
    /// </summary>
    public enum MembershipState
    {
        /// <summary>
        /// Default value.
        /// </summary>
        Unspecified,

        /// <summary>
        /// The user is added to space and can participate to conversation.
        /// </summary>
        Joined,

        /// <summary>
        /// The user is invited to join the space, but hasn't joined it.
        /// </summary>
        Invited,

        /// <summary>
        /// The user doesn't belong to the space and doesn't have a pending invitation to join.
        /// </summary>
        Not_A_Member
    }
}