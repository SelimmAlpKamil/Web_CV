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

    public class ServicesController : Controller
    {
        ServiceManager serviceManager = new ServiceManager(new EFServiceDAL());

        public IActionResult Index()
        {
            TempData["serviceActive"] = "active";

            var list = serviceManager.TGetAll();

            return View(list);
        }

        [HttpGet]
        public IActionResult UpdateService(int id)
        {
            TempData["serviceActive"] = "active";

            var findService = serviceManager.TGetByID(id);

            return View(findService);
        }

        [HttpPost]
        public IActionResult UpdateService(Service p)
        {
            ServiceValidation validations = new ServiceValidation();

            var rule = validations.Validate(p);

            if(rule.IsValid)
            {
                serviceManager.TUppdate(p);

                return RedirectToAction("Index", "Services");
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
        public IActionResult AddService()
        {
            TempData["serviceActive"] = "active";

            return View();
        }

        [HttpPost]
        public IActionResult AddService(Service p)
        {
            ServiceValidation validations = new ServiceValidation();

            var rule = validations.Validate(p);

            if (rule.IsValid)
            {
                serviceManager.TAdd(p);

                return RedirectToAction("Index", "Services");
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

        public IActionResult DeleteService(int id) 
        {
            var findService = serviceManager.TGetByID(id);

            serviceManager.TRemove(findService);

            return RedirectToAction("Index", "Services");

        }

    }
}
