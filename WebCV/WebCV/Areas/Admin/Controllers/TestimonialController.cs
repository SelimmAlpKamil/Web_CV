
using BusinessLayer.Concreate;
using BusinessLayer.Validation;
using DataAccessLayer.Entity;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace WebCV.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    [Route("/Admin/[Controller]/[Action]/{id?}")]


    public class TestimonialController : Controller
    {
        TestimonialManager testimonialManager = new TestimonialManager(new EFTestimonialDAL());


        public IActionResult Index()
        {
            TempData["testimonialActive"] = "active";

            var list = testimonialManager.TGetAll();

            return View(list);
        }

        [HttpGet]
        public IActionResult UpdateTestimonial(int id)
        {
            TempData["testimonialActive"] = "active";

            var finTestimonial = testimonialManager.TGetByID(id);

            return View(finTestimonial);
        }

        [HttpPost]
        public IActionResult UpdateTestimonial(Testimonial p)
        {
            TestimonialValidation validations = new TestimonialValidation();

            var rule = validations.Validate(p);

            if (rule.IsValid)
            {
                testimonialManager.TUppdate(p);

                return RedirectToAction("Index", "Testimonial");
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
                p.TestimonialStatus = true;

                testimonialManager.TAdd(p);

                return RedirectToAction("Index", "Testimonial");
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

        public IActionResult DeleteTestimonial(int id)
        {
            var findPortfolio = testimonialManager.TGetByID(id);

            testimonialManager.TRemove(findPortfolio);

            return RedirectToAction("Index", "Testimonial");
        }

        public IActionResult ChangeStatusFalseTestimonial(int id)
        {
            var findPortfolio = testimonialManager.TGetByID(id);

            var find = testimonialManager.TGetByID(id);

            find.TestimonialStatus = false;

            testimonialManager.TUppdate(find);

            return RedirectToAction("Index", "Testimonial");


       
        }




        public IActionResult PasifTestimonial()
        {
            TempData["testimonialActive"] = "active";

            var list = testimonialManager.TGetAllPasif();    

            return View(list);
        }

        public IActionResult ChangeStatusTestimonial(int id)
        {
            var find = testimonialManager.TGetByID(id);

            find.TestimonialStatus = true;

            testimonialManager.TUppdate(find);

            return RedirectToAction("Index", "Testimonial");

        }




    }
}
