using EntityLayer.Concreate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validation
{
    public class ContactSendValidation : AbstractValidator<Contact>
    {
        public ContactSendValidation()
        {
            RuleFor(x=>x.ContactMail).NotEmpty().WithMessage("Boş geçilemez");
            RuleFor(x=>x.ContactMessage).NotEmpty().WithMessage("Boş geçilemez");
            RuleFor(x=>x.ContactName).NotEmpty().WithMessage("Boş geçilemez");
            RuleFor(x=>x.ContactSubject).NotEmpty().WithMessage("Boş geçilemez");


            RuleFor(x => x.ContactMail).MinimumLength(5).WithMessage("Minimum karakter sınırı 5");
            RuleFor(x => x.ContactMessage).MinimumLength(10).WithMessage("Minimum karakter sınırı 10");
            RuleFor(x => x.ContactName).MinimumLength(1).WithMessage("Minimum karakter sınırı 1");
            RuleFor(x => x.ContactSubject).MinimumLength(5).WithMessage("Minimum karakter sınırı 5");


            RuleFor(x => x.ContactMail).MaximumLength(50).WithMessage("Maksimum karakter sınırı 50");
            RuleFor(x => x.ContactMessage).MaximumLength(5000).WithMessage("Maksimum karakter sınırı 5000");
            RuleFor(x => x.ContactName).MaximumLength(100).WithMessage("Maksimum karakter sınırı 100");
            RuleFor(x => x.ContactSubject).MaximumLength(200).WithMessage("Maksimum karakter sınırı 200");
        }

        
    }
}
