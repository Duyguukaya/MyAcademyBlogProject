using AutoMapper;
using Blogy.Business.DTOs.CommentDtos;
using Blogy.Business.DTOs.ContactDtos;
using Blogy.Business.Services.CommentServices;
using Blogy.DataAccess.Repositories.ContactRepositories;
using Blogy.Entity.Entities;

namespace Blogy.Business.Services.ContactServices
{
    public class ContactService(IContactRepository _contactRepository, IMapper _mapper) : IContactService
    {
        public async Task CreateAsync(CreateContactDto createDto)
        {
            var entity = _mapper.Map<Contact>(createDto);
            await _contactRepository.CreateAsync(entity);
        }

        public async Task DeleteAsync(int id)
        {
            await _contactRepository.DeleteAsync(id);
        }

        public async Task<List<ResultContactDto>> GetAllAsync()
        {
            var values = await _contactRepository.GetAllAsync();
            return _mapper.Map<List<ResultContactDto>>(values);
        }

        public async Task<UpdateContactDto> GetByIdAsync(int id)
        {
            var value = await _contactRepository.GetByIdAsync(id);
            return _mapper.Map<UpdateContactDto>(value);
        }

        public async Task<ResultContactDto> GetSingleByIdAsync(int id)
        {
            var value = await _contactRepository.GetByIdAsync(id);
            return _mapper.Map<ResultContactDto>(value);
        }

        public async Task UpdateAsync(UpdateContactDto updateDto)
        {
            var entity = _mapper.Map<Contact>(updateDto);
            await _contactRepository.UpdateAsync(entity);
        }
    }
}
