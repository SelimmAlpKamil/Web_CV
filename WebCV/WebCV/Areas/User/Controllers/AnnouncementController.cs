using BusinessLayer.Concreate;
using DataAccessLayer.Entity;
using Microsoft.AspNetCore.Mvc;

namespace WebCV.Areas.User.Controllers
{
    [Area("User")]
    [Route("/User/[Controller]/[Action]/{id?}")]

    public class AnnouncementController : Controller
    {
    
        AnnouncementManager announcementManager = new AnnouncementManager(new EFAnnouncementDAL());

        public IActionResult Index()
        {

            TempData["announcemntActive"] = "active";

            var list = announcementManager.TGetAll();

            return View(list);

        }
    }
}
