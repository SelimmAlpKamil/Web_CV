using BusinessLayer.Concreate;
using DataAccessLayer.Entity;
using Microsoft.AspNetCore.Mvc;

namespace WebCV.Viewcomponents.User
{
    public class UserNavbarAnnouncemnt : ViewComponent
    {
        AnnouncementManager announcementManager = new AnnouncementManager(new EFAnnouncementDAL());


        public IViewComponentResult Invoke()
        {
            var list = announcementManager.TGetAll();

            return View(list);
        }
    }
}
