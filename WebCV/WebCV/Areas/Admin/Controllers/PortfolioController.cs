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

    public class PortfolioController : Controller
    {

        PortfolioManager portfolioManager = new PortfolioManager(new EFPortfolioDAL());

        public IActionResult Index()
        {
            TempData["portfolioActive"] = "active";

            var list = portfolioManager.TGetAll();

            return View(list);
        }

        [HttpGet]
        public IActionResult UpdatePortfolio(int id) 
        {
            TempData["portfolioActive"] = "active";

            var findPortfolio = portfolioManager.TGetByID(id);

            return View(findPortfolio);
        }

        [HttpPost]
        public IActionResult UpdatePortfolio(Portfolio p)
        {
            PortfolioValidation validations = new PortfolioValidation();

            var rule = validations.Validate(p);

            if (rule.IsValid)
            {
                portfolioManager.TUppdate(p);

                return RedirectToAction("Index", "Portfolio");  
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
        public IActionResult AddPortfolio(int id)
        {
            TempData["portfolioActive"] = "active";

            return View();
        }

        [HttpPost]
        public IActionResult AddPortfolio(Portfolio p)
        {
            PortfolioValidation validations = new PortfolioValidation();

            var rule = validations.Validate(p);

            if (rule.IsValid)
            {
                portfolioManager.TAdd(p);

                return RedirectToAction("Index", "Portfolio");
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

        public IActionResult DeletePortfolio(int id)
        {
            var findPortfolio = portfolioManager.TGetByID(id);

            portfolioManager.TRemove(findPortfolio);

            return RedirectToAction("Index", "Portfolio");
        }



    }
}
