using BusinessLayer.Concreate;
using DataAccessLayer.Entity;
using Microsoft.AspNetCore.Mvc;

namespace WebCV.Viewcomponents.Admin
{
    public class AdminNavbarContactMessage:ViewComponent
    {
        ContactManager contactManager = new ContactManager(new EFContactDAL());

        public IViewComponentResult Invoke()
        {
            var countMessage = 0;

            foreach(var x in contactManager.TGetAll())
            {
                countMessage++;
            }

            ViewBag.countMessage= countMessage;

            var list = contactManager.TGetContactDESC(5);

            return View(list);
        }


    }
}
