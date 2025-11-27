using Blogy.Business.DTOs.MessageDtos;

namespace Blogy.Business.Services.MessageServices
{
    public interface IMessageService:IGenericService<ResultMessageDto,UpdateMessageDto,CreateMessageDto>
    {
    }
}
