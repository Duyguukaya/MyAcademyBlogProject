using AutoMapper;
using Blogy.Business.DTOs.CommentDtos;
using Blogy.DataAccess.Repositories.CommentRepositories;
using Blogy.Entity.Entities;
using FluentValidation;
using Microsoft.AspNetCore.Http.HttpResults;

namespace Blogy.Business.Services.CommentServices
{
    public class CommentService(ICommentRepository _commentRepository, IMapper _mapper, IValidator<Comment> _validator) : ICommentService
    {
        public async Task CreateAsync(CreateCommentDto createDto)
        {
            var comment = _mapper.Map<Comment>(createDto);
            var result = await _validator.ValidateAsync(comment);
            if (!result.IsValid)
            {
                throw new ValidationException(result.Errors);
            }
           await _commentRepository.CreateAsync(comment);
        }

        public async Task DeleteAsync(int id)
        {
            await _commentRepository.DeleteAsync(id);
        }

        public async Task<List<ResultCommentDto>> GetAllAsync()
        {
            var values = await _commentRepository.GetAllAsync();
            return _mapper.Map<List<ResultCommentDto>>(values);
        }

        public async Task<UpdateCommentDto> GetByIdAsync(int id)
        {
           var values = await _commentRepository.GetByIdAsync(id);
            return _mapper.Map<UpdateCommentDto>(values);
        }

        public async Task<ResultCommentDto> GetSingleByIdAsync(int id)
        {
            var values = await _commentRepository.GetByIdAsync(id);
            return _mapper.Map<ResultCommentDto>(values);
        }

        public async Task UpdateAsync(UpdateCommentDto updateDto)
        {
            var comment = _mapper.Map<Comment>(updateDto);
            var result = await _validator.ValidateAsync(comment);
            if (!result.IsValid)
            {
                throw new ValidationException(result.Errors);
            }

            await _commentRepository.UpdateAsync(comment);
        }
    }
}
