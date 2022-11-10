namespace Practice.Models
{
    public class Conversation
    {
        public int Id { get; set; }
        public Nullable<int> ChatId { get; set; }
        public string Text { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<int> UserId2 { get; set; }
    }
}
