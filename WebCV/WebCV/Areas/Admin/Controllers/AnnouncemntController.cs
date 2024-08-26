using BusinessLayer.Concreate;
using BusinessLayer.Validation;
using DataAccessLayer.Entity;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace WebCV.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    [Route("/Admin/[Controller]/[Action]/{id?}")]

    public class AnnouncemntController : Controller
    {
        AnnouncementManager announcementManager = new AnnouncementManager(new EFAnnouncementDAL());

        public IActionResult Index()
        {
            TempData["announcemntActive"] = "active";

            var list = announcementManager.TGetAll();

            return View(list);
        }

        [HttpGet]
        public IActionResult AddAnnouncement()
        {
            TempData["announcemntActive"] = "active";

            return View();
        }

        [HttpPost]
        public IActionResult AddAnnouncement(Announcement p)
        {
            AnnouncemntValidation validations = new AnnouncemntValidation();
            var rule = validations.Validate(p);

            if(rule.IsValid)
            {
                p.AnnouncementStatus = true;
                p.AnnouncementDate = Convert.ToDateTime(DateTime.Now.ToString());

                announcementManager.TAdd(p);

                return RedirectToAction("Index", "Announcemnt");
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
        public IActionResult UpdateAnnouncemnt(int id)
        {
            TempData["announcemntActive"] = "active";

            var find = announcementManager.TGetByID(id);

            return View(find);
        }

        [HttpPost]
        public IActionResult UpdateAnnouncemnt(Announcement p)
        {
            AnnouncemntValidation validations = new AnnouncemntValidation();
            var rule = validations.Validate(p);

            if (rule.IsValid)
            {
                p.AnnouncementStatus = true;
                p.AnnouncementDate = Convert.ToDateTime(DateTime.Now.ToString());

                announcementManager.TUppdate(p);

                return RedirectToAction("Index", "Announcemnt");
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

        public IActionResult DeleteAnnouncement(int id)
        {
            var find = announcementManager.TGetByID(id);

            announcementManager.TRemove(find);

            return RedirectToAction("Index", "Announcemnt");
        }



    }
}
