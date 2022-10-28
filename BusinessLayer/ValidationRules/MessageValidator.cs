using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class MessageValidator: AbstractValidator<Message>
    {
        public MessageValidator()
        {
            RuleFor(x => x.ReceiverMail).NotEmpty().WithMessage("Alıcı adı boş bırakılamaz.");
            RuleFor(x => x.MSubject).NotEmpty().WithMessage("Konu boş bırakılamaz.");
            RuleFor(x => x.MessageContent).NotEmpty().WithMessage("Mesaj içeriği boş bırakılamaz.");

            RuleFor(x => x.MSubject).MinimumLength(1).WithMessage("Konu ismi 1 karakterden kısa olamaz.");
            RuleFor(x => x.MSubject).MaximumLength(20).WithMessage("Konu ismi 20 karakterden uzun olamaz.");

            RuleFor(x => x.MessageContent).MinimumLength(1).WithMessage("Mesaj içeriği 1 karakterden kısa olamaz.");
            RuleFor(x => x.MessageContent).MaximumLength(100).WithMessage("Mesaj içeriği 100 karakterden uzun olamaz.");
        }
    }
}
