using Blogy.Entity.Entities;
using Microsoft.EntityFrameworkCore;

namespace Blogy.DataAccess.Context
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options):base(options)
        {
        }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogTag> BlogTags { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Social> Socials { get; set; }
        public DbSet<Tag> Tags { get; set; }
    }


}
