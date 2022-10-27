using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ContactValidator : AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(x => x.UserMail).NotEmpty().WithMessage("Mail adı boş bırakılamaz.");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konu adı boş bırakılamaz.");
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Kullanıcı adı boş bırakılamaz.");
            RuleFor(x => x.Subject).MinimumLength(3).WithMessage("Konu 3 karakterden kısa olamaz.");
            RuleFor(x => x.UserName).MaximumLength(3).WithMessage("İsim 3 karakterden uzun olamaz.");
            RuleFor(x => x.Subject).MaximumLength(50).WithMessage("Konu içeriği 50 karakterden uzun olamaz.");
        }
    }
}
