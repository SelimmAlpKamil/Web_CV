using Microsoft.AspNetCore.Mvc;

namespace WebCV.Areas.Admin.Controllers
{

    [Area("Admin")]
    [Route("/Admin/[Controller]/[Action]/{id?}")]

    public class ErrorPageController : Controller
    {
        public IActionResult Error401()
        {
            return View();
        }

        public IActionResult Error404()
        {
            return View();
        }
    }
}
