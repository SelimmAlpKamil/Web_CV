
using BusinessLayer.Concreate;
using DataAccessLayer.Entity;
using Microsoft.AspNetCore.Mvc;

namespace WebCV.Viewcomponents.Home
{
    public class Testimonials:ViewComponent
    {

        TestimonialManager testimonialManager = new TestimonialManager(new EFTestimonialDAL());

        public IViewComponentResult Invoke()
        {
            var list = testimonialManager.TGetAll();


            return View(list);
        }
    }
}
