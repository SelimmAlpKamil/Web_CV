using Microsoft.AspNetCore.Mvc;

namespace WebCV.Viewcomponents.Admin
{
    public class AdminAddToDoList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
