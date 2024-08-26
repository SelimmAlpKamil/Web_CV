using EntityLayer.Concreate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validation
{
    public class StudentValidation : AbstractValidator<Student>
    {
        public StudentValidation()
        {
            RuleFor(x => x.StudentName).NotEmpty().WithMessage("Boş Geçilemez");
            RuleFor(x => x.StudentDate).NotEmpty().WithMessage("Boş Geçilemez");
            RuleFor(x => x.StudentDescription).NotEmpty().WithMessage("Boş Geçilemez");
            RuleFor(x => x.StudentImageURL).NotEmpty().WithMessage("Boş Geçilemez");

            RuleFor(x => x.StudentName ).MaximumLength(200).WithMessage("Maksimum karakter sınırı 200");
            RuleFor(x => x.StudentDate).MaximumLength(200).WithMessage("Maksimum karakter sınırı 200");
            RuleFor(x => x.StudentDescription).MaximumLength(5000).WithMessage("Maksimum karakter sınırı 5000");
            RuleFor(x => x.StudentImageURL).MaximumLength(1000).WithMessage("Maksimum karakter sınırı 1000");

            RuleFor(x => x.StudentName).MinimumLength(5).WithMessage("Minimum karakter sınırı 5");
            RuleFor(x => x.StudentDate).MinimumLength(5).WithMessage("Minimum karakter sınırı 5");
            RuleFor(x => x.StudentDescription).MinimumLength(10).WithMessage("Minimum karakter sınırı 10");
            RuleFor(x => x.StudentImageURL).MinimumLength(5).WithMessage("Minimum karakter sınırı 5");

        }
    }
}
