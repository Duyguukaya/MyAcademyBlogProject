using Blogy.Business.DTOs.BlogDtos;
using Blogy.Entity.Entities;

namespace Blogy.Business.Services.BlogServices
{
    public interface IBlogService:IGenericService<ResultBlogDto,UpdateBlogDto,CreateBlogDto>
    {
        Task<List<ResultBlogDto>> GetBlogWithCategoriesAsync();
        Task<List<ResultBlogDto>> GetBlogsByCategoryIdAsync(int categoryId);
        Task<List<ResultBlogDto>> GetLast3BlogsAsync();
        Task<List<ResultBlogDto>> GetLast6BlogsAsync();
        Task<List<ResultBlogDto>> GetListByWriter(int id);
    }
}
