using EntityLayer.Concreate;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebCV.Areas.Admin.Models;



namespace WebCV.Areas.Admin.Controllers
{
    [AllowAnonymous]

    [Area("Admin")]
    [Route("/Admin/[Controller]/[Action]/{id?}")]
   

    public class LoginController : Controller
    {
        private readonly SignInManager<AppUsers> _signInManager;
        private readonly RoleManager<AppRoles> _roleManager;
        private readonly UserManager<AppUsers> _userManager;

        public LoginController(SignInManager<AppUsers> signInManager, RoleManager<AppRoles> roleManager, UserManager<AppUsers> userManager)
        {
            _signInManager = signInManager;
            _roleManager = roleManager;
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(LoginAppViewModel p)
        {




            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(p.UserName, p.Password, true, true);

                var user = await _userManager.FindByNameAsync(p.UserName);

                var role = await _userManager.GetRolesAsync(user);


                if (result.Succeeded)
                {

                    if (role.Contains("Admin"))
                    {
                        return RedirectToAction("Index", "Dashborad", new { area = "Admin" });
                    }
                    else
                    {
                        return RedirectToAction("Index", "Dashborad", new { area = "User" });
                    }


                }
                else
                {
                    ViewBag.errorSingIn = "Kullanıcı adı veya şifre hatalı";
                }

            }

            return View();
        }

        public async Task<IActionResult> SingOut()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction("Index", "Login");

        }
    }
}
