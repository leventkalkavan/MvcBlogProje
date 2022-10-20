using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori adı boş bırakılamaz.");
            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Açıklama boş bırakılamaz.");
            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("Kategori ismi 3 karakterden kısa olamaz.");
            RuleFor(x => x.CategoryName).MaximumLength(20).WithMessage("Kategori ismi 20 karakterden uzun olamaz.");
        }
    }
}
