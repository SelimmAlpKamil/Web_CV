using BusinessLayer.Concreate;
using DataAccessLayer.Entity;
using Microsoft.AspNetCore.Mvc;

namespace WebCV.Viewcomponents.Home
{
    public class Skills: ViewComponent
    {
        SkillManager skillManager = new SkillManager( new EFSkillDAL());


        public IViewComponentResult Invoke()
        {
            var list = skillManager.TGetAll();


            return View(list);
        }

    }
}
