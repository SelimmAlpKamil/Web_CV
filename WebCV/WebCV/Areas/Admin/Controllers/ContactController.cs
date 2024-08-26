using BusinessLayer.Concreate;
using DataAccessLayer.Entity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebCV.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    [Route("/Admin/[Controller]/[Action]/{id?}")]

    public class ContactController : Controller
    {
        ContactManager contactManager = new ContactManager(new EFContactDAL());

        public IActionResult Index()
        {
            TempData["contactActive"] = "active";

            var list = contactManager.TGetActiveMessage();


            return View(list);
        }

        public IActionResult DeleteContact(int id) 
        {
            var findContact = contactManager.TGetByID(id);

            contactManager.TRemove(findContact);

            return RedirectToAction("Index","Contact");
        }

        public IActionResult DetailContact(int id)
        {
            TempData["contactActive"] = "active";

            var findContact = contactManager.TGetByID(id);

            return View(findContact);
        }

        public IActionResult ChangeStatusPasif(int id)
        {
            var findMessage = contactManager.TGetByID(id);

            findMessage.ContactStatus = false;

            contactManager.TUppdate(findMessage);

            return RedirectToAction("Index", "Contact");

        }

        public IActionResult ChangeStatusActive(int id)
        {
            var findMessage = contactManager.TGetByID(id);

            findMessage.ContactStatus = true;

            contactManager.TUppdate(findMessage);

            return RedirectToAction("PasifMessage", "Contact");

        }

        public IActionResult PasifMessage()
        {
            TempData["contactActive"] = "active";

            var list = contactManager.TGetPasifMessage();

            return View(list);
        }



    }
}
