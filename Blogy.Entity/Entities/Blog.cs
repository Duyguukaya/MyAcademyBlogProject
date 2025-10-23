using Blogy.Entity.Entities.Common;

namespace Blogy.Entity.Entities
{
    public class Blog:BaseEntity
    {
        public string Tittle { get; set; }
        public string Description { get; set; }
        public string CoverImage { get; set; }
        public string BlogImage1 { get; set; }
        public string BlogImage2 { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public IList<BlogTag> BlogTags { get; set; }
        public int WriterId { get; set; }
        public AppUser? Writer { get; set; }
        public IList<Comment> Comments { get; set; }

    }
}
