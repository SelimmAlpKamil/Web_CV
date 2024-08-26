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

    public class FeatureController : Controller
    {
        FeatureManager featureManager = new FeatureManager(new EFFeatureDAL());

        [HttpGet]
        public IActionResult Index()
        {
            TempData["featureActive"] = "active";


            var findFeature = featureManager.TGetByID(1);


            return View(findFeature);
        }

        [HttpPost]
        public IActionResult Index(Feature p)
        {
            FeatureValidation validations = new FeatureValidation();
            var rule = validations.Validate(p);

            if (rule.IsValid)
            {
                featureManager.TUppdate(p);

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
