using EntityLayer.Concreate;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebCV.Areas.Admin.Models;
using WebCV.Areas.User.Models;

namespace WebCV.Areas.User.Controllers
{

    [Area("User")]
    [Route("/User/[Controller]/[Action]/{id?}")]

    public class ProfileController : Controller
    {
        

        private readonly UserManager<AppUsers> _userManager;

        public ProfileController(UserManager<AppUsers> userManager)
        {
            _userManager = userManager;
        }


        [HttpGet]
        public async Task<IActionResult> Index()
        {

            TempData["profileActive"] = "active";

            var findAdmin = await _userManager.FindByNameAsync(User.Identity.Name);

            UserUpdateViewModel model = new UserUpdateViewModel()
            {
                Name = findAdmin.Name,
                Surname = findAdmin.Surname,
                Mail = findAdmin.Email,
                Phone = findAdmin.PhoneNumber,

            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserUpdateViewModel p)
        {
            var findAdmin = await _userManager.FindByNameAsync(User.Identity.Name);

            findAdmin.Name = p.Name;
            findAdmin.Surname = p.Surname;
            findAdmin.Email = p.Mail;
            findAdmin.PhoneNumber = p.Phone;

            await _userManager.UpdateAsync(findAdmin);

            if (p.Password == p.PasswordConfing && p.Password != null && p.PasswordConfing != null)
            {
                findAdmin.PasswordHash = _userManager.PasswordHasher.HashPassword(findAdmin, p.Password);

                await _userManager.UpdateAsync(findAdmin);

            }
            else
            {

                return View();
            }

            return RedirectToAction("Index", "Login",new {@area="Admin"});
        }

    }
}
