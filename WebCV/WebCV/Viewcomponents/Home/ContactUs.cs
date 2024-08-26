using BusinessLayer.Concreate;
using DataAccessLayer.Entity;
using Microsoft.AspNetCore.Mvc;

namespace WebCV.Viewcomponents.Home
{
    public class ContactUs : ViewComponent
    {
        AboutManager aboutManager = new AboutManager(new EFAboutDAL());
        public IViewComponentResult Invoke()
        {
            var list = aboutManager.TGetAll();

            return View(list);
        }
    }
}
