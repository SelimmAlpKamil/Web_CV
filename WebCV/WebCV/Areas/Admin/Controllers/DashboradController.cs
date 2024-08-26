using DataAccessLayer.Concreate;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace WebCV.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    [Route("/Admin/[Controller]/[Action]/{id?}")]

    public class DashboradController : Controller
    {
       
        Context c = new Context();

        public IActionResult Index()
        {
            TempData["dashboardActive"] = "active";

            ViewBag.activeMessageCount = c.Contacts.Where(x=>x.ContactStatus==true).Count();
            ViewBag.pasifMessageCount = c.Contacts.Where(x => x.ContactStatus == false).Count();
            ViewBag.projeCount = c.Portfolios.Count();
            ViewBag.testimoniolCount = c.Testimonials.Count();
            ViewBag.skilCount = c.Skills.Count();
            ViewBag.experienceCount = c.Experiences.Count();
            ViewBag.studentCount = c.Students.Count();
            ViewBag.serviceCount = c.Services.Count();


            return View();
        }
    }
}
