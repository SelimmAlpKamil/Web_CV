using EntityLayer.Concreate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validation
{
    public class FeatureValidation : AbstractValidator<Feature>
    {
        public FeatureValidation() 
        {
            RuleFor(x=>x.FeatureHeader).NotEmpty().WithMessage("Boş geçilemez");
            RuleFor(x=>x.FeatureName).NotEmpty().WithMessage("Boş geçilemez");
            RuleFor(x=>x.FeatureTitle).NotEmpty().WithMessage("Boş geçilemez");

            RuleFor(x => x.FeatureHeader).MaximumLength(100).WithMessage("Maksimum karakter sınırı 100");
            RuleFor(x => x.FeatureName).MaximumLength(100).WithMessage("Maksimum karakter sınırı 100");
            RuleFor(x => x.FeatureTitle).MaximumLength(500).WithMessage("Maksimum karakter sınırı 500");

            RuleFor(x => x.FeatureHeader).MinimumLength(3).WithMessage("Minimum karakter sınırı 3");
            RuleFor(x => x.FeatureName).MinimumLength(4).WithMessage("Minimum karakter sınırı 4");
            RuleFor(x => x.FeatureTitle).MinimumLength(5).WithMessage("Minimum karakter sınırı 5");
            
        }
    }
}
