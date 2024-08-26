using EntityLayer.Concreate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validation
{
    public class AnnouncemntValidation : AbstractValidator<Announcement>
    {
        public AnnouncemntValidation()
        {
            RuleFor(x=>x.AnnouncementTitle).NotEmpty().WithMessage("Boş Geçilemez");
            RuleFor(x=>x.AnnouncementSubject).NotEmpty().WithMessage("Boş Geçilemez");

            RuleFor(x => x.AnnouncementTitle).MaximumLength(200).WithMessage("Maksimum karakter sınırı 200");
            RuleFor(x => x.AnnouncementSubject).MaximumLength(2000).WithMessage("Maksimum karakter sınırı 2000");

            RuleFor(x => x.AnnouncementTitle).MinimumLength(3).WithMessage("Minimum karakter sınırı 3");
            RuleFor(x => x.AnnouncementSubject).MinimumLength(5).WithMessage("Minimum karakter sınırı 5");


        }
    }
}
