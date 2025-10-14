using Blogy.DataAccess.Context;
using Blogy.Entity.Entities;
using Blogy.DataAccess.Repositories.GenericRepositories;
using Microsoft.EntityFrameworkCore;

namespace Blogy.DataAccess.Repositories.CategoryRepositories
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<List<Category>> GetCategoriesWithBlogsAsync()
        {
            return await _context.Categories.AsNoTracking().Include(x => x.Blogs).ToListAsync();
        }
    }

}