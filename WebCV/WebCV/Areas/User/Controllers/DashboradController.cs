using DataAccessLayer.Concreate;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WebCV.Areas.User.Controllers
{
    [Area("User")]
    [Route("/User/[Controller]/[Action]/{id?}")]

    public class DashboradController : Controller
    {
        private readonly UserManager<AppUsers> _userManager;

        Context c = new Context();

        public DashboradController(UserManager<AppUsers> userManager)
        {
            _userManager = userManager;
        }


        

        

        public async Task<IActionResult> Index()
        {
            TempData["dashboardActive"] = "active";


            ViewBag.AnnouncementCount = c.Announcements.Count();

            var findUser = await _userManager.FindByNameAsync(User.Identity.Name);

            ViewBag.userName = findUser.Name + " " + findUser.Surname;

            

            string api = "22737b1fc60a6ebd205f5cfb95c6a20c";
            string connection = "https://api.openweathermap.org/data/2.5/weather?q=Istanbul&mode=xml&units=metric&appid=" + api;

            XDocument document = XDocument.Load(connection);

            ViewBag.wether = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;

            return View();
        }
    }
}


