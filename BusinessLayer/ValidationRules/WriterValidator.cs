using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar adı boş bırakılamaz.");
            RuleFor(x => x.WriterSurname).NotEmpty().WithMessage("Yazar soyadı boş bırakılamaz.");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Mail boş bırakılamaz.");
            RuleFor(x => x.WriterTitle).NotEmpty().WithMessage("Unvan boş bırakılamaz.");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Şifre boş bırakılamaz.");
            RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Yazar hakkında kısmı boş bırakılamaz.");
            RuleFor(x => x.WriterName).MinimumLength(3).WithMessage("Yazar ismi 3 karakterden kısa olamaz.");
            RuleFor(x => x.WriterSurname).MaximumLength(50).WithMessage("50 karakterden uzun olamaz.");
            RuleFor(x => x.WriterSurname).MinimumLength(2).WithMessage("Yazar soyadı 2 karakterden kısa olamaz.");
            RuleFor(x => x.WriterAbout).MinimumLength(5).WithMessage("Hakkında kısmı 5 karakterden kısa olamaz.");
        }
    }
}
