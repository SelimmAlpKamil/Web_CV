using EntityLayer.Concreate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validation
{
    public class SocialMediaValidation : AbstractValidator<SocialMedia>
    {
        public SocialMediaValidation()
        {
            RuleFor(x=>x.SocialMediaName).NotEmpty().WithMessage("Boş geçilemez");
            RuleFor(x=>x.SocialMediaURL).NotEmpty().WithMessage("Boş geçilemez");
            RuleFor(x=>x.SocialMediaIcon).NotEmpty().WithMessage("Boş geçilemez");

            RuleFor(x => x.SocialMediaName).MaximumLength(50).WithMessage("Maksimum karakter sınırı 50");
            RuleFor(x => x.SocialMediaURL).MaximumLength(1000).WithMessage("Maksimum karakter sınırı 1000");
            RuleFor(x => x.SocialMediaIcon).MaximumLength(200).WithMessage("Maksimum karakter sınırı 200");

            RuleFor(x => x.SocialMediaName).MinimumLength(1).WithMessage("Minimum karakter sınır 1");
            RuleFor(x => x.SocialMediaURL).MinimumLength(5).WithMessage("Minimum karakter sınırı 5");
            RuleFor(x => x.SocialMediaIcon).MinimumLength(5).WithMessage("Minimum karakter sınırı 5");

        }
    }
}
