using Blogy.Business.DTOs.BlogDtos;
using Blogy.Business.DTOs.Common;
using Blogy.Business.DTOs.UserDtos;
using Blogy.Entity.Entities;

namespace Blogy.Business.DTOs.CommentDtos
{
    public class ResultCommentDto:BaseDto
    {
        public string Content { get; set; }
        public int BlogId { get; set; }
        public DateTime CreatedDate { get; set; }
        public ResultBlogDto Blog { get; set; }
        public int UserId { get; set; }
        public ResultUserDto User { get; set; }
        public bool IsApproved { get; set; }
    }
}
