using EntityLayer.Concreate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validation
{
    public class PortfolioValidation : AbstractValidator<Portfolio>
    {
        public PortfolioValidation()
        {
            RuleFor(x=>x.PortfolioTitle).NotEmpty().WithMessage("Boş Geçilemez");
            RuleFor(x=>x.PortfolioImageURL).NotEmpty().WithMessage("Boş Geçilemez");
            RuleFor(x=>x.PortfolioURL).NotEmpty().WithMessage("Boş Geçilemez");

            RuleFor(x => x.PortfolioTitle).MaximumLength(200).WithMessage("Maksimum karakter sınırı 200");
            RuleFor(x => x.PortfolioImageURL).MaximumLength(2000).WithMessage("Maksimum karakter sınırı 2000");
            RuleFor(x => x.PortfolioURL).MaximumLength(2000).WithMessage("Maksimum karakter sınırı 2000");

            RuleFor(x => x.PortfolioTitle).MinimumLength(2).WithMessage("Minimum karakter sınırı 2");
            RuleFor(x => x.PortfolioImageURL).MinimumLength(5).WithMessage("Minimum karakter sınırı 5");
            RuleFor(x => x.PortfolioURL).MinimumLength(5).WithMessage("Minimum karakter sınırı 5");

        }
    }
}
