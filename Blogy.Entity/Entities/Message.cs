using Blogy.Entity.Entities.Common;

namespace Blogy.Entity.Entities
{
    public class Message:BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public bool IsRead { get; set; } = false;
        public string? AutoReply { get; set; }
    }
}
