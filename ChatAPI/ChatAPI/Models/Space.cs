using ChatAPI.Enums;
using System.Xml.Linq;

namespace ChatAPI.Models
{
    /// <summary>
    /// A place where users can comunicate between them or with bots.
    /// </summary>
    public class Space
    {
        /// <summary>
        /// The unique identifier of a space.
        /// Format: spaces/{space}
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The type of space.
        /// Require when you create a space.
        /// </summary>
        public SpaceType Type { get; set; }

        /// <summary>
        /// The space's display name.
        /// Required when creating a group space.
        /// Can be empty on direct chat. 
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// Wheter this space permits any user as a member to join.
        /// False: any user can join the space.
        /// True: You need a inivitation to join the space.
        /// </summary>
        public bool PrivateSpace { get; set; }

        /// <summary>
        /// Details about the space including description and rules.
        /// </summary>
        public SpaceDetails SpaceDetails { get; set; }

        /// <summary>
        /// The message history state for messages in this space.
        /// </summary>
        public HistoryState SpaceHistoryState { get; set; }

        /// <summary>
        /// The date and time when the space was created.
        /// </summary>
        public DateTime CreateTime { get; set; }
        
        /// <summary>
        /// The list of members that can participate in a space.
        /// </summary>
        public List<Member> Members { get; set; }
    }
}
