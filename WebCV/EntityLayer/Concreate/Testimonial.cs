using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
    public class Testimonial
    {
        [Key]
        public int TestimonialId { get; set; }
        public string TestimonialName { get; set; }
        public string TestimonialCompany { get; set; }
        public string TestimonialComment { get; set; }
        public string TestimonialImageURL { get; set; }

        public bool TestimonialStatus { get; set; }
    }
}
