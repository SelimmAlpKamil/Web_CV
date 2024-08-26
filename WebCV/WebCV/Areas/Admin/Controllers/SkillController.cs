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
    
    public class SkillController : Controller
    {
        SkillManager skillManager = new SkillManager(new EFSkillDAL());

        public IActionResult Index()
        {
            TempData["skillActive"] = "active";

            var list = skillManager.TGetAll();

            return View(list);
        }

        [HttpGet]
        public IActionResult UppdateSkill(int id)
        {
            TempData["skillActive"] = "active";

            var findSkill = skillManager.TGetByID(id);

            return View(findSkill);
        }

        [HttpPost]
        public IActionResult UppdateSkill(Skill p)
        {
            SkillValidation validationRules = new SkillValidation();

            var rule = validationRules.Validate(p);

            if (rule.IsValid)
            {
                skillManager.TUppdate(p);
                return RedirectToAction("Index","Skill");
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

        public IActionResult DeleteSkill(int id)
        {
            TempData["skillActive"] = "active";


            var findSkill = skillManager.TGetByID(id);

            skillManager.TRemove(findSkill);

            return RedirectToAction("Index", "Skill");
        }

        [HttpGet]
        public IActionResult AddSkill()
        {
            TempData["skillActive"] = "active";

            return View();
        }

        [HttpPost]
        public IActionResult AddSkill(Skill p)
        {
            SkillValidation validationRules = new SkillValidation();

            var rule = validationRules.Validate(p);

            if (rule.IsValid)
            {
                skillManager.TAdd(p);
                return RedirectToAction("Index", "Skill");
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
