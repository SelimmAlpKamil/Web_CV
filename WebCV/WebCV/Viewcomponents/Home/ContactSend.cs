using Microsoft.AspNetCore.Mvc;

namespace WebCV.Viewcomponents.Home
{
    public class ContactSend : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
