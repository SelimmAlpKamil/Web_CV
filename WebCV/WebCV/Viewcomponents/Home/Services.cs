using BusinessLayer.Concreate;
using DataAccessLayer.Entity;
using Microsoft.AspNetCore.Mvc;

namespace WebCV.Viewcomponents.Home
{
    public class Services: ViewComponent
    {
        ServiceManager serviceManager = new ServiceManager(new EFServiceDAL());

        public IViewComponentResult Invoke()
        {
            var list = serviceManager.TGetAllCount(5);

            return View(list);
        }
    }
}
