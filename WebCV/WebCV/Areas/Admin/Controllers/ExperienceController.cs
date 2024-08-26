using BusinessLayer.Concreate;
using BusinessLayer.Validation;
using DataAccessLayer.Entity;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebCV.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    [Route("/Admin/[Controller]/[Action]/{id?}")]

    public class ExperienceController : Controller
    {
        ExperienceManager experiencesManager = new ExperienceManager(new EFExperienceDAL());

        public IActionResult Index()
        {
            TempData["experienceActive"] = "active";

            var list = experiencesManager.TGetAll();


            return View(list);
        }

        [HttpGet]
        public IActionResult UppdateExperience(int id)
        {
            TempData["experienceActive"] = "active";

            var findExperience = experiencesManager.TGetByID(id);

            return View(findExperience);
        }

        [HttpPost]
        public IActionResult UppdateExperience(Experience p)
        {
            ExperienceValidation validations = new ExperienceValidation();

            var rule = validations.Validate(p);

            if (rule.IsValid)
            {
                experiencesManager.TUppdate(p);
                return RedirectToAction("Index", "Experience");
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

        [HttpGet]
        public IActionResult AddExperience()
        {
            TempData["experienceActive"] = "active";

            return View();
        }

        [HttpPost]
        public IActionResult AddExperience(Experience p)
        {
            ExperienceValidation validations = new ExperienceValidation();

            var rule = validations.Validate(p);

            if (rule.IsValid)
            {
                experiencesManager.TAdd(p);
                return RedirectToAction("Index", "Experience");
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

        public IActionResult DeleteExperience(int id)
        {
            TempData["experienceActive"] = "active";

            var findExperience = experiencesManager.TGetByID(id);

            experiencesManager.TRemove(findExperience);

            return RedirectToAction("Index", "Experience");
        }





    }
}
