using EntityLayer.Concreate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validation
{
    public class ServiceValidation : AbstractValidator<Service>
    {
        public ServiceValidation()
        {
            RuleFor(x => x.ServiceTitle).NotEmpty().WithMessage("Boş geçilemez");
            RuleFor(x => x.ServiceImageURL).NotEmpty().WithMessage("Boş geçilemez");

            RuleFor(x => x.ServiceTitle).MaximumLength(100).WithMessage("Maksimum karakter sınırı 100");
            RuleFor(x => x.ServiceImageURL).MaximumLength(2000).WithMessage("Maksimum karakter sınırı 2000");

            RuleFor(x => x.ServiceTitle).MinimumLength(2).WithMessage("Minimum karakter sınırı 2");
            RuleFor(x => x.ServiceImageURL).MinimumLength(10).WithMessage("Minimum karakter sınırı 10");
        }
    }
}
