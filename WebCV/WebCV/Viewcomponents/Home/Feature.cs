using BusinessLayer.Concreate;
using DataAccessLayer.Entity;
using Microsoft.AspNetCore.Mvc;

namespace WebCV.Viewcomponents.Home
{
    public class Feature:ViewComponent
    {
        FeatureManager featureManager = new FeatureManager(new EFFeatureDAL());

        public IViewComponentResult Invoke()
        {
            var list = featureManager.TGetAll();

            return View(list);
        }
    }
}
