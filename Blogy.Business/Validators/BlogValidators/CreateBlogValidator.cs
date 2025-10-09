using Blogy.Business.DTOs.BlogDtos;
using FluentValidation;

namespace Blogy.Business.Validators.BlogValidators
{
    public class CreateBlogValidator:AbstractValidator<CreateBlogDto>
    {
        public CreateBlogValidator()
        {
            RuleFor(x => x.Tittle).NotEmpty().WithMessage("Başlık Boş Bırakılmaz");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama Boş Bırakılmaz");
            RuleFor(x => x.CoverImage).NotEmpty().WithMessage("Kapak Resmi Boş Bırakılmaz");
            RuleFor(x => x.BlogImage1).NotEmpty().WithMessage("Blog Resmi 1 Boş Bırakılmaz");
            RuleFor(x => x.BlogImage2).NotEmpty().WithMessage("Blog Resmi 2 Boş Bırakılmaz");
            RuleFor(x => x.CategoryId).NotEmpty().WithMessage("Kategori Boş Bırakılmaz");
        }
    }
}
