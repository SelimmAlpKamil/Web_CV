using BusinessLayer.Concreate;
using BusinessLayer.Validation;
using DataAccessLayer.Concreate;
using DataAccessLayer.Entity;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;

namespace WebCV.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    [Route("/Admin/[Controller]/[Action]/{id?}")]


    public class MessageController : Controller
    {
        MessageManager messageManager = new MessageManager(new EFMessageDAL());

        Context c = new Context();

        private readonly UserManager<AppUsers> _userManager;

        public MessageController(UserManager<AppUsers> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> RecevirMessage()
        {
            TempData["RecevirActive"] = "active";

            var findUser = await _userManager.FindByNameAsync(User.Identity.Name);

            var list = messageManager.ReceverMessageList(findUser.Email);

            return View(list);
        }

        public async Task<IActionResult> SenderMessage()
        {
            TempData["SenderActive"] = "active";

            var findUser = await _userManager.FindByNameAsync(User.Identity.Name);

            var list = messageManager.SenderMessageList(findUser.Email);

            return View(list);
        }

        public IActionResult MessageDetail(int id)
        {
            var findMessage = messageManager.TGetByID(id);

            return View(findMessage);
        }

        public IActionResult DeleteMessageSender(int id)
        {
            var findMessage = messageManager.TGetByID(id);

            messageManager.TRemove(findMessage);

            return RedirectToAction("SenderMessage", "Message");
        }

        public IActionResult DeleteMessageRecevir(int id)
        {
            var findMessage = messageManager.TGetByID(id);

            messageManager.TRemove(findMessage);

            return RedirectToAction("RecevirMessage", "Message");
        }

        [HttpGet]
        public async Task<IActionResult> AddMessage()
        {
            var findUser = await _userManager.FindByNameAsync(User.Identity.Name);

            ViewBag.user = findUser.Email;

            var userList = _userManager.Users.Select(u => new SelectListItem
            {
                Text = u.Email,
                Value = u.Email

            }).ToList();

            ViewBag.userList = userList;

            return View();

        }

        [HttpPost]
        public async Task<IActionResult> AddMessage(Message p)
        {
            var findUser = await _userManager.FindByNameAsync(User.Identity.Name);

            ViewBag.user = findUser.Email;

            var userList = _userManager.Users.Select(u => new SelectListItem
            {
                Text = u.Email,
                Value = u.Email

            }).ToList();

            ViewBag.userList = userList;



            MessageValidation validations = new MessageValidation();

            var rule = validations.Validate(p);

            if (rule.IsValid)
            {
                p.MessageDateTime = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                messageManager.TAdd(p);

                return RedirectToAction("SenderMessage", "Message");
            }
            else
            {
                foreach (var x in rule.Errors)
                {
                    ModelState.AddModelError(x.PropertyName, x.ErrorMessage);
                }
            }



            return View(p);
        }



    }
}
