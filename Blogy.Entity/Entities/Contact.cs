using Blogy.Entity.Entities.Common;

namespace Blogy.Entity.Entities
{
    public class Contact : BaseEntity
    {
        public string Location { get; set; }
        public string OpenHours { get; set; }
        public string Email { get; set; }
        public string Call { get; set; }
    }
}
