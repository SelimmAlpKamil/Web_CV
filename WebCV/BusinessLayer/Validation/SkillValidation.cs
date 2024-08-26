using EntityLayer.Concreate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validation
{
    public class SkillValidation : AbstractValidator<Skill>
    {
        public SkillValidation()
        {
            RuleFor(x=>x.SkillName).NotEmpty().WithMessage("Boş Geçilemez");
            RuleFor(x=>x.SkillValue).NotEmpty().WithMessage("Boş Geçilemez");

            RuleFor(x=>x.SkillName).MaximumLength(50).WithMessage("Maksimum karakter sınırı 50");
            RuleFor(x => x.SkillValue).InclusiveBetween(0, 100).WithMessage("Değer 0-100 arasında olabilir");

            RuleFor(x=>x.SkillName).MinimumLength(2).WithMessage("Minimum karakter sınırı 2");


            

           

        }
    }
}
