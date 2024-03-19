using ChatAPI.Enums;

namespace ChatAPI.Models 
{
    /// <summary>
    /// A humman or a bot that can participate in a space.
    /// </summary>
    public class User{

         /// <summary>
        /// The unique identifier of a user.
        /// Format: users/{user}
        /// </summary>
        public string Name {get;set;}

        /// <summary>
        /// The user display name.
        /// </summary>
        public string DisplayName {get;set;}

        /// <summary>
        /// The type of user.
        /// </summary>
        public UserType Type {get;set;}

        /// <summary>
        /// When set on true the usere is deleted or the profile is not visibile.
        /// </summary>
        public Boolean isAnomnymus {get;set;}
    }
}