using EntityLayer.Concreate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validation
{
    public class AboutValidation : AbstractValidator<About>
    {
        public AboutValidation()
        {
            RuleFor(x=>x.AboutAddress).NotEmpty().WithMessage("Boş geçilemez");
            RuleFor(x=>x.AboutHeader).NotEmpty().WithMessage("Boş geçilemez");
            RuleFor(x=>x.AboutDescription).NotEmpty().WithMessage("Boş geçilemez");
            RuleFor(x=>x.AboutMail).NotEmpty().WithMessage("Boş geçilemez");
            RuleFor(x=>x.AboutAge).NotEmpty().WithMessage("Boş geçilemez");
            RuleFor(x=>x.AboutPhone).NotEmpty().WithMessage("Boş geçilemez");
            RuleFor(x=>x.AboutImageURL).NotEmpty().WithMessage("Boş geçilemez");

            RuleFor(x => x.AboutHeader).MaximumLength(500).WithMessage("Maksimum karakter sınırı 500");
            RuleFor(x => x.AboutAddress).MaximumLength(500).WithMessage("Maksimum karakter sınırı 500");
            RuleFor(x => x.AboutDescription).MaximumLength(5000).WithMessage("Maksimum karakter sınırı 5000");
            RuleFor(x => x.AboutMail).MaximumLength(100).WithMessage("Maksimum karakter sınırı 100");
            RuleFor(x => x.AboutAge).MaximumLength(3).WithMessage("Maksimum karakter sınırı 3");
            RuleFor(x => x.AboutPhone).MaximumLength(20).WithMessage("Maksimum karakter sınırı 20");
            RuleFor(x => x.AboutImageURL).MaximumLength(1000).WithMessage("Maksimum karakter sınırı 1000");

            RuleFor(x => x.AboutHeader).MinimumLength(5).WithMessage("Minimum karakter sınırı 5");
            RuleFor(x => x.AboutAddress).MinimumLength(10).WithMessage("Minimum karakter sınırı 10");
            RuleFor(x => x.AboutDescription).MinimumLength(10).WithMessage("Minimum karakter sınırı 10");
            RuleFor(x => x.AboutMail).MinimumLength(10).WithMessage("Minimum karakter sınırı 10");
            RuleFor(x => x.AboutAge).MinimumLength(1).WithMessage("Minimum karakter sınırı 1");
            RuleFor(x => x.AboutPhone).MinimumLength(10).WithMessage("Minimum karakter sınırı 10");
            RuleFor(x => x.AboutImageURL).MinimumLength(5).WithMessage("Minimum karakter sınırı 5");







        }
    }
}
