using EntityLayer.Concreate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validation
{
    public class MessageValidation : AbstractValidator<Message>
    {
        public MessageValidation()
        {
            RuleFor(x=>x.MessageSubject).NotEmpty().WithMessage("Boş geçilemez");
            RuleFor(x=>x.MessageContact).NotEmpty().WithMessage("Boş geçilemez");

            RuleFor(x => x.MessageSubject).MaximumLength(200).WithMessage("Maksimum uzunluk 200");
            RuleFor(x => x.MessageContact).MaximumLength(2000).WithMessage("Maksimum uzunluk 2000");

            RuleFor(x => x.MessageSubject).MinimumLength(5).WithMessage("Minimum uzunluk 5");
            RuleFor(x => x.MessageContact).MinimumLength(10).WithMessage("Minimum uzunluk 10");
        }
    }
}
