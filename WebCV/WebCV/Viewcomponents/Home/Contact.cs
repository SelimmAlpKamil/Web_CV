using Microsoft.AspNetCore.Mvc;

namespace WebCV.Viewcomponents.Home
{
    public class Contact: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }

    }
}
