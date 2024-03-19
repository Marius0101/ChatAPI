namespace ChatAPI.Models
{
    public class Message
    {
        public string Name {get;set;}
        public User Sender {get;set;}
        public DateTime CreateTime {get;set;}
        public DateTime LastUpdateTime {get;set;}
        public DateTime? DeleteTime {get;set;}
        public string Text {get;set;}
        public string FormattedText {get;set;}
        public Space Space {get;set;}
        public 
    }
}
