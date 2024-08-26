using BusinessLayer.Concreate;
using DataAccessLayer.Entity;
using Microsoft.AspNetCore.Mvc;

namespace WebCV.Viewcomponents.Home
{
    public class SocialMedia : ViewComponent
    {
        SocialMediaManager socialMediaManager = new SocialMediaManager(new EFSocialMediaDAL());

        public IViewComponentResult Invoke()
        {
            var list = socialMediaManager.TGetAllCount(5);

            return View(list);
        }
    }
}
