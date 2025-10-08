using Blogy.Business.DTOs.CategoryDtos;
using FluentValidation;

namespace Blogy.Business.Validators.CategoryValidators
{
    public class CreateCategoryValidator:AbstractValidator<CreateCategoryDto>
    {
        public CreateCategoryValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Kategori Adı Boş Bırakılamaz!")
                                .MinimumLength(3).WithMessage("Kategori Adı En Az 3 Karakter Olmalıdır!")
                                .MaximumLength(50).WithMessage("Kategori Adı En Fazla 50 Karakter Olmalıdır!");
        }
    }
}
