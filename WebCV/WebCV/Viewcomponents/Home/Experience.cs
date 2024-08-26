using BusinessLayer.Concreate;
using DataAccessLayer.Entity;
using Microsoft.AspNetCore.Mvc;

namespace WebCV.Viewcomponents.Home
{
    public class Experience: ViewComponent
    {
        ExperienceManager experienceManager = new ExperienceManager(new EFExperienceDAL());

        public IViewComponentResult Invoke()
        {
            var list = experienceManager.TGetAll();

            return View(list);
        }
    }
}
