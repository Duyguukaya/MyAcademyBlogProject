using Blogy.Business.DTOs.CommentDtos;

namespace Blogy.Business.Services.CommentServices
{
    public interface ICommentService:IGenericService<ResultCommentDto,UpdateCommentDto,CreateCommentDto>
    {
        Task<List<ResultCommentDto>> GetCommentsByWriterAsync(int writerId);
    }
}
