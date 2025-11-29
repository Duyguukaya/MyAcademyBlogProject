namespace Blogy.Business.DTOs.MessageDtos
{
    public class CreateMessageDto
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public bool IsRead { get; set; } = false;
        public string? AutoReply { get; set; }
    }
}
