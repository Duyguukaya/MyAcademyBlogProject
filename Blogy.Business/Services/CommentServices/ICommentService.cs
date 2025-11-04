using Blogy.Business.DTOs.CommentDtos;

namespace Blogy.Business.Services.CommentServices
{
    public interface ICommentService:IGenericService<ResultCommentDto,UpdateCommentDto,CreateCommentDto>
    {
    }
}
