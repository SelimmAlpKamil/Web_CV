using EntityLayer.Concreate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validation
{
    public class TestimonialValidation : AbstractValidator<Testimonial>
    {
        public TestimonialValidation()
        {
            RuleFor(x => x.TestimonialName).NotEmpty().WithMessage("Boş Geçilemez");
            RuleFor(x => x.TestimonialImageURL).NotEmpty().WithMessage("Boş Geçilemez");
            RuleFor(x => x.TestimonialCompany).NotEmpty().WithMessage("Boş Geçilemez");

            RuleFor(x => x.TestimonialName).MaximumLength(100).WithMessage("Maksimum karakter sınırı 100");
            RuleFor(x => x.TestimonialImageURL).MaximumLength(2000).WithMessage("Maksimum karakter sınırı 2000");
            RuleFor(x => x.TestimonialCompany).MaximumLength(200).WithMessage("Maksimum karakter sınırı 200");

            RuleFor(x => x.TestimonialName).MinimumLength(4).WithMessage("Minimum karakter sınırı 4");
            RuleFor(x => x.TestimonialImageURL).MinimumLength(5).WithMessage("Minimum karakter sınırı 5");
            RuleFor(x => x.TestimonialCompany).MinimumLength(5).WithMessage("Minimum karakter sınırı 5");
         
        }
    }
}
