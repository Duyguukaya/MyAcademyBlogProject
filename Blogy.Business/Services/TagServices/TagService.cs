using AutoMapper;
using Blogy.Business.DTOs.CommentDtos;
using Blogy.Business.DTOs.TagDtos;
using Blogy.DataAccess.Repositories.TagRepositories;
using Blogy.Entity.Entities;
using FluentValidation;

namespace Blogy.Business.Services.TagServices
{
    internal class TagService(ITagRepository _tagRepository, IMapper _mapper) : ITagService
    {
        public async Task CreateAsync(CreateTagDto createDto)
        {
            var tag = _mapper.Map<Tag>(createDto);
         
            await _tagRepository.CreateAsync(tag);
        }

        public async Task DeleteAsync(int id)
        {
            await _tagRepository.DeleteAsync(id);
        }

        public async Task<List<ResultTagDto>> GetAllAsync()
        {
            var values = await _tagRepository.GetAllAsync();
            return _mapper.Map<List<ResultTagDto>>(values);
        }

        public async Task<UpdateTagDto> GetByIdAsync(int id)
        {
            var values = await _tagRepository.GetByIdAsync(id);
            return _mapper.Map<UpdateTagDto>(values);
        }

        public async Task<ResultTagDto> GetSingleByIdAsync(int id)
        {
            var values = await _tagRepository.GetByIdAsync(id);
            return _mapper.Map<ResultTagDto>(values);
        }

        public async Task UpdateAsync(UpdateTagDto updateDto)
        {
            var tag = _mapper.Map<Tag>(updateDto);
          

            await _tagRepository.UpdateAsync(tag);
        }
    }
}
