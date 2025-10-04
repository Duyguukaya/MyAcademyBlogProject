using Blogy.Entity.Entities.Common;

namespace Blogy.Entity.Entities
{
    public class Category:BaseEntity
    {
        public string Name { get; set; }
        public IList<Blog> Blogs { get; set; }
    }
}
