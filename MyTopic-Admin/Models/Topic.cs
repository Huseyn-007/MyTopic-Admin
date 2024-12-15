namespace MyTopic_Admin.Models
{
    public class Topic
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Topic> SubTopics { get; set; } = new List<Topic>();
    }
}
