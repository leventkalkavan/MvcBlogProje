using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
  public  class HeadingValidator : AbstractValidator<Heading>
    {
        public HeadingValidator()
        {
            RuleFor(x => x.HeadingName).NotEmpty().WithMessage("Başlık adı boş bırakılamaz.");
            RuleFor(x => x.Category).NotEmpty().WithMessage("Kategori adı boş bırakılamaz.");
            RuleFor(x => x.Writer).NotEmpty().WithMessage("Yazar boş bırakılamaz.");
            RuleFor(x => x.Contents).NotEmpty().WithMessage("İçerik boş bırakılamaz.");
            RuleFor(x => x.HeadingName).NotEmpty().WithMessage("Şifre boş bırakılamaz.");
        }
    }
}
