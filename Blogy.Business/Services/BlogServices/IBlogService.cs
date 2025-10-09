using Blogy.Business.DTOs.BlogDtos;

namespace Blogy.Business.Services.BlogServices
{
    public interface IBlogService:IGenericService<ResultBlogDto,UpdateBlogDto,CreateBlogDto>
    {
        Task<List<ResultBlogDto>> GetBlogWithCategoriesAsync();
    }
}
