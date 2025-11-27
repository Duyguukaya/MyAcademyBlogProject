using AutoMapper;
using Blogy.Business.DTOs.MessageDtos;
using Blogy.Entity.Entities;

namespace Blogy.Business.Mappings
{
    public class MessageMappings:Profile
    {
        public MessageMappings()
        {
            CreateMap<Message, CreateMessageDto>().ReverseMap();   
            CreateMap<Message, ResultMessageDto>().ReverseMap();   
            CreateMap<Message, UpdateMessageDto>().ReverseMap();   
        }
    }
}
