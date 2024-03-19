using ChatAPI.Enums;

namespace ChatAPI.Models
{
    /// <summary>
    /// Represent the user relation with a space.
    /// The permisions that a user have in a space.
    /// </summary>
    public class Member
    {
        /// <summary>
        /// The unique identifier of a member.
        /// Format: spaces/{space}/members/{member}
        /// </summary>
        public string Name {get; set;}

        /// <summary>
        /// State of the membership.
        /// </summary>
        public MembershipState State {get; set;}

        /// <summary>
        /// User role within a space which determines their permitted actions in the space.
        /// </summary>
        public MembershipRole Role {get;set;}

        /// <summary>
        /// The time when a member joined or was invited to join in a space.
        /// </summary>
        public DateTime CreateTime {get;set;}

        /// <summary>
        /// The time when a member left or was removed from a space.
        /// </summary>
        public DateTime? DeleteTime {get;set;}

        /// <summary>
        /// The user the membership corresponds to.
        /// </summary>
        public User User {get;set;}

    }
}
