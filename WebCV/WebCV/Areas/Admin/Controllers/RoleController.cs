using DataAccessLayer.Concreate;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebCV.Areas.Admin.Models;

namespace WebCV.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    [Route("/Admin/[Controller]/[Action]/{id?}")]
    public class RoleController : Controller
    {

        private readonly RoleManager<AppRoles> _roleManager;
        private readonly UserManager<AppUsers> _userManager;

        Context c = new Context();  

        public RoleController(UserManager<AppUsers> userManager, RoleManager<AppRoles> roleManager = null)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public IActionResult Index()
        {
            TempData["roleActive"] = "active";

            var roles = _roleManager.Roles.ToList();

  
            return View(roles);
        }


        [HttpGet]
        public IActionResult AddRole()
        {
            TempData["roleActive"] = "active";

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddRole(AppRoles p)
        {
            if (ModelState.IsValid)
            {

                if(p.Name != null)
                {
                    var result = await _roleManager.CreateAsync(p);


                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Role");
                    }
                    else
                    {
                        foreach (var error in result.Errors)
                        {
                            ModelState.AddModelError("", error.Description);
                        }
                    }
                }
                else
                {
                    ViewBag.eror = "Boş geçilemez";
                }
            }
            return View(p);
        }

        public async Task<IActionResult> DeleteRole(int id)
        {
            var find = c.Roles.Find(id);

            await _roleManager.DeleteAsync(find);

            return RedirectToAction("Index", "Role");
        }

        [HttpGet]
        public IActionResult UpdateRole(int Id)
        {
            TempData["roleActive"] = "active";

            var find = c.Roles.Find(Id);
            
            return View(find);
        }

        [HttpPost]
        public IActionResult UpdateRole(AppRoles p)
        {
            if(p.Name != null)
            {
                var find = c.Roles.Find(p.Id);

                find.Name = p.Name;  
                
                c.Roles.Update(find);

                c.SaveChanges();
            }
            else
            {
                ViewBag.eror = "Boş geçilemez";
            }

            return RedirectToAction("Index", "Role");
        }

        public IActionResult UserList()
        {
            TempData["roleActive"] = "active";

            var list = c.Users.ToList();

            return View(list);
        }

        [HttpGet]
        public async Task<IActionResult> ChangeRole(int id)
        {
            TempData["roleActive"] = "active";

            var findUser = c.Users.Find(id);

            var userRoles = await _userManager.GetRolesAsync(findUser);

            var currentRole = userRoles.FirstOrDefault();

            List<SelectListItem> list = (from x in c.Roles.ToList()
                                         select new SelectListItem
                                         {
                                             Text = x.Name,
                                             Value = x.Id.ToString(),

                                         }).ToList();

            ViewBag.roleList = list;

            ViewBag.currentRole = currentRole;  
            
            TempData["UserId"] = findUser.Id;

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ChangeRole(AppRoles p)
        { 
            var userId = TempData["UserId"].ToString();

     
            var findUser = await _userManager.FindByIdAsync(userId);


            var userRoles = await _userManager.GetRolesAsync(findUser);

            await _userManager.RemoveFromRolesAsync(findUser, userRoles);


    
            var findRole = await c.Roles.FindAsync(p.Id);


            if (findRole != null)
            {
                await _userManager.AddToRoleAsync(findUser, findRole.Name);
            }

            return RedirectToAction("UserList", "Role");
        }




    }
}
