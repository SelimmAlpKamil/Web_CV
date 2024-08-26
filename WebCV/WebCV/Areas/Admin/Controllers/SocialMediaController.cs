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

    public class SocialMediaController : Controller
    {
        SocialMediaManager socialMedia = new SocialMediaManager(new EFSocialMediaDAL());
        
        public IActionResult Index()
        {
            TempData["socialMediaActive"] = "active";


            var list = socialMedia.TGetAll();

            return View(list);
        }

        public IActionResult DeleteSocialMedia(int id)
        {
            var find = socialMedia.TGetByID(id);

            socialMedia.TRemove(find);

            return RedirectToAction("Index", "SocialMedia");
        }

        [HttpGet]
        public IActionResult UpdateSocialMedia(int id) 
        {
            TempData["socialMediaActive"] = "active";

            var find = socialMedia.TGetByID(id);

            return View(find);
        }

        [HttpPost]
        public IActionResult UpdateSocialMedia(SocialMedia p)
        {
            SocialMediaValidation validation = new SocialMediaValidation(); 

            var rule = validation.Validate(p);

            if(rule.IsValid) 
            {
                socialMedia.TUppdate(p);
                return RedirectToAction("Index", "SocialMedia");

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
        public IActionResult AddSocialMedia()
        {
            TempData["socialMediaActive"] = "active";

            return View();
        }

        [HttpPost]
        public IActionResult AddSocialMedia(SocialMedia p)
        {
            SocialMediaValidation validation = new SocialMediaValidation();

            var rule = validation.Validate(p);

            if (rule.IsValid)
            {
                socialMedia.TAdd(p);
                return RedirectToAction("Index", "SocialMedia");

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
