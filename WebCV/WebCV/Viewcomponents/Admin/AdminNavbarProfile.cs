using BusinessLayer.Concreate;
using DataAccessLayer.Entity;
using Microsoft.AspNetCore.Mvc;

namespace WebCV.Viewcomponents.Admin
{
    public class AdminNavbarProfile : ViewComponent
    {
        AboutManager aboutManager = new AboutManager(new EFAboutDAL());
        FeatureManager featureManager = new FeatureManager(new EFFeatureDAL());


        public IViewComponentResult Invoke()
        {
            var findAbout = aboutManager.TGetByID(1);
            var findFeature = featureManager.TGetByID(1);

            ViewBag.aboutImage = findAbout.AboutImageURL;

            ViewBag.featureName = findFeature.FeatureName;  


            return View();
        }

    }
}
