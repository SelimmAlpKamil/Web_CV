using BusinessLayer.Concreate;
using BusinessLayer.Validation;
using DataAccessLayer.Entity;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Mvc;

namespace WebCV.Areas.User.Controllers
{
    [Area("User")]
    [Route("/User/[Controller]/[Action]/{id?}")]

    public class TestimonialController : Controller
    {
        TestimonialManager testimonialManager = new TestimonialManager(new EFTestimonialDAL());


        [HttpGet]
        public IActionResult AddTestimonial(int id)
        {
            TempData["testimonialActive"] = "active";

            return View();
        }

        [HttpPost]
        public IActionResult AddTestimonial(Testimonial p)
        {
            TestimonialValidation validations = new TestimonialValidation();

            var rule = validations.Validate(p);

            if (rule.IsValid)
            {
                p.TestimonialStatus = false;

                testimonialManager.TAdd(p);

                return RedirectToAction("Index", "Announcement");
            }
            else
            {
                foreach (var x in rule.Errors)
                {
                    ModelState.AddModelError(x.PropertyName, x.ErrorMessage);
                }
            }

            return View(p);
        }
    }
}
