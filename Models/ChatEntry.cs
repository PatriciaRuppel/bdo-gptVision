namespace bdo.gptVisionApi.Models
{
    public class ChatEntry
    {
        public int Id { get; set; }
        public DateTime TimeStamp { get; set; }
        public bool IsInput { get; set; }
        public string? Text { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string UserEmail { get; set; } = string.Empty ;
    }
}
