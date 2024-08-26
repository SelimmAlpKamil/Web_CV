using EntityLayer.Concreate;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebCV.Areas.Admin.Models;

namespace WebCV.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("/Admin/[Controller]/[Action]/{id?}")]
    [AllowAnonymous]
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUsers> _usersManager;
        private readonly RoleManager<AppRoles> _roleManager;

        public RegisterController(UserManager<AppUsers> usersManager, RoleManager<AppRoles> roleManager)
        {
            _usersManager = usersManager;
            _roleManager = roleManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(RegisterAppViewModel p)
        {
            

            AppUsers appUsers = new AppUsers()
            {
                Name = p.Name,
                Surname = p.Surname,
                UserName = p.UserName,
                Email = p.Mail,   
            };

            if(ModelState.IsValid && p.ConfigPassword == p.Password && p.Password!=null && p.ConfigPassword!=null) 
            { 
                var result = await _usersManager.CreateAsync(appUsers,p.Password);

                if(result.Succeeded)
                {
                    return RedirectToAction("Index", "Login");
                }
                else
                {
                    foreach(var x in result.Errors)
                    {
                        ModelState.AddModelError("", x.Description);
                    }
                }
            }


            return View(p);
        }
    }
}
