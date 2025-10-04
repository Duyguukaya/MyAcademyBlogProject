using Blogy.DataAccess.Context;
using Blogy.Entity.Entities;
using Blogy.DataAccess.Repositories.GenericRepositories;


namespace Blogy.DataAccess.Repositories.CategoryRepositories
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(AppDbContext context) : base(context)
        {
        }
    }

}