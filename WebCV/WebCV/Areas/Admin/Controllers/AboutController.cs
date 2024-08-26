using BusinessLayer.Concreate;
using BusinessLayer.Validation;
using DataAccessLayer.Entity;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace WebCV.Areas.Admin.Controllers
{
    [Authorize(Roles ="Admin")]
    [Area("Admin")]
    [Route("/Admin/[Controller]/[Action]/{id?}")]

    public class AboutController : Controller
    {
        AboutManager aboutManager = new AboutManager(new EFAboutDAL());

        [HttpGet]
        public IActionResult Index()
        {
            TempData["aboutActive"] = "active";


            var findAbout = aboutManager.TGetByID(1);


            return View(findAbout);
        }
        [HttpPost]
        public IActionResult Index(About p)
        {
            AboutValidation validation = new AboutValidation();
            var rule = validation.Validate(p);

            if (rule.IsValid)
            {
                aboutManager.TUppdate(p);

                return RedirectToAction("Index", "Home");
            }
            else
            {
                foreach(var x in rule.Errors)
                {
                    ModelState.AddModelError(x.PropertyName, x.ErrorMessage);
                }
            }

            return View(p);

        }

    }
}
