using BusinessLayer.Concreate;
using DataAccessLayer.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace WebCV.Viewcomponents.Admin
{
    

    public class AdminToDoList : ViewComponent
    {
        ToDoListManager toDoListManager = new ToDoListManager(new EFToDoListDAL());

        public IViewComponentResult Invoke()
        {
            var list = toDoListManager.TGetListDesc();

            return View(list);
        }
    }
}
