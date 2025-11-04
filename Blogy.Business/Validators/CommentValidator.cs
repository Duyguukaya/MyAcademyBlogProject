using Blogy.Entity.Entities;
using FluentValidation;

namespace Blogy.Business.Validators
{
    public class CommentValidator:AbstractValidator<Comment>
    {
        public CommentValidator()
        {
            RuleFor(x => x.UserId).NotEmpty().WithMessage("Kullanıcı Boş Olamaz!");
            RuleFor(x => x.BlogId).NotEmpty().WithMessage("Blog Boş Olamaz!");
            RuleFor(x => x.Content).NotEmpty().WithMessage("Yorum İçeriği Boş Olamaz!");
            RuleFor(x => x.Content).MaximumLength(250).WithMessage("Yorum İçeriği Max 250 Karakter Olmalı!");
        }
    }
}
