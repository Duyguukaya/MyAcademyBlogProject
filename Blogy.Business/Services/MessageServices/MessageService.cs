using AutoMapper;
using Blogy.Business.DTOs.MessageDtos;
using Blogy.DataAccess.Repositories.MessageRepositories;
using Blogy.Entity.Entities;

namespace Blogy.Business.Services.MessageServices
{
    public class MessageService(IMessageRepository _messageRepository, IMapper _mapper) : IMessageService
    {
        public async Task CreateAsync(CreateMessageDto createDto)
        {
            var entity = _mapper.Map<Message>(createDto);
            await _messageRepository.CreateAsync(entity);
        }

        public async Task DeleteAsync(int id)
        {
            await _messageRepository.DeleteAsync(id);
        }

        public async Task<List<ResultMessageDto>> GetAllAsync()
        {
            var values = await _messageRepository.GetAllAsync();
            return _mapper.Map<List<ResultMessageDto>>(values);
        }

        public async Task<UpdateMessageDto> GetByIdAsync(int id)
        {
            var value = await _messageRepository.GetByIdAsync(id);
            return _mapper.Map<UpdateMessageDto>(value);
        }

        public async Task<ResultMessageDto> GetSingleByIdAsync(int id)
        {
            var value = await _messageRepository.GetByIdAsync(id);
            return _mapper.Map<ResultMessageDto>(value);
        }

        public async Task UpdateAsync(UpdateMessageDto updateDto)
        {
            var entity = _mapper.Map<Message>(updateDto);
            await _messageRepository.UpdateAsync(entity);
        }
    }
}
