using EntityLayer.Concreate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validation
{
    public class ExperienceValidation : AbstractValidator<Experience>
    {
        public ExperienceValidation()
        {
            RuleFor(x=>x.ExperienceTitle).NotEmpty().WithMessage("Boş Geçilemez");
            RuleFor(x=>x.ExperienceDate).NotEmpty().WithMessage("Boş Geçilemez");
            RuleFor(x=>x.ExperienceDescription).NotEmpty().WithMessage("Boş Geçilemez");
            RuleFor(x=>x.ExperienceImageURL).NotEmpty().WithMessage("Boş Geçilemez");

            RuleFor(x => x.ExperienceTitle).MaximumLength(200).WithMessage("Maksimum karakter sınırı 200");
            RuleFor(x => x.ExperienceDate).MaximumLength(200).WithMessage("Maksimum karakter sınırı 200");
            RuleFor(x => x.ExperienceDescription).MaximumLength(5000).WithMessage("Maksimum karakter sınırı 5000");
            RuleFor(x => x.ExperienceImageURL).MaximumLength(1000).WithMessage("Maksimum karakter sınırı 1000");

            RuleFor(x => x.ExperienceTitle).MinimumLength(5).WithMessage("Minimum karakter sınırı 5");
            RuleFor(x => x.ExperienceDate).MinimumLength(5).WithMessage("Minimum karakter sınırı 5");
            RuleFor(x => x.ExperienceDescription).MinimumLength(10).WithMessage("Minimum karakter sınırı 10");
            RuleFor(x => x.ExperienceImageURL).MinimumLength(5).WithMessage("Minimum karakter sınırı 5");

        }
    }
}
