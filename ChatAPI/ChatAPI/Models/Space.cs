using ChatAPI.Enums;
using System.Xml.Linq;

namespace ChatAPI.Models
{
    public class Space
    {
        public string name { get; set; }
        public SpaceType spaceType { get; set; }
        public string displayName { get; set; }
        public bool privateSpace { get; set; }
        public SpaceDetails spaceDetails { get; set; }
        public HistoryState spaceHistoryState { get; set; }
        public DateTime createTime { get; set; }
        public List<Member> Members { get; set; }
        public List<Message> Messages { get; set; }
    }
}
