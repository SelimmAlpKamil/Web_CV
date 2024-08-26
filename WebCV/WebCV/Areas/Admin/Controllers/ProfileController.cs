using EntityLayer.Concreate;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Threading.Tasks;
using WebCV.Areas.Admin.Models;

namespace WebCV.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    [Route("/Admin/[Controller]/[Action]/{id?}")]


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

            AdminUpdateViewModel model = new AdminUpdateViewModel()
            {
                Name = findAdmin.Name,
                Surname = findAdmin.Surname,
                Mail = findAdmin.Email,
                Phone = findAdmin.PhoneNumber,

            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Index(AdminUpdateViewModel p)
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

            return RedirectToAction("Index", "Login");
        }
    }
}
