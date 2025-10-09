using Blogy.DataAccess.Repositories.GenericRepositories;
using Blogy.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogy.DataAccess.Repositories.BlogRepositories
{
    public interface IBlogRepository:IGenericRepository<Blog>
    {
        Task<List<Blog>> GetBlogsWithCategoriesAsync();
    }
}
