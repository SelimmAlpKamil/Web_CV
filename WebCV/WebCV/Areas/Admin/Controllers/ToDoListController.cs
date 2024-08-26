using BusinessLayer.Concreate;
using BusinessLayer.Validation;
using DataAccessLayer.Entity;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace WebCV.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    [Route("/Admin/[Controller]/[Action]/{id?}")]


    public class ToDoListController : Controller
    {

        ToDoListManager toDoListManager = new ToDoListManager(new EFToDoListDAL());

        [HttpPost]
        public IActionResult AddToDo(ToDoList p) 
        {
            ToDoListValidation validations = new ToDoListValidation();
            var rule = validations.Validate(p);

            if (rule.IsValid)
            {
                p.TodoListCompleted = false;
                toDoListManager.TAdd(p);

                return RedirectToAction("Index", "Dashborad");
            }
            else
            {
                var errors= rule.Errors.Select(x=>x.ErrorMessage).FirstOrDefault();

                TempData["errorMessage"] = errors;
            }

            return RedirectToAction("Index", "Dashborad");


        }

        public IActionResult CompleteToDoList(int id)
        {
            var find = toDoListManager.TGetByID(id);

            find.TodoListCompleted = true;

            toDoListManager.TUppdate(find);

            return RedirectToAction("Index","Dashborad");
        }

        public IActionResult NotCompleteToDoList(int id)
        {
            var find = toDoListManager.TGetByID(id);

            find.TodoListCompleted = false;

            toDoListManager.TUppdate(find);

            return RedirectToAction("Index", "Dashborad");
        }

        public IActionResult DeleteToDoList(int id)
        {
            var find = toDoListManager.TGetByID(id);

            find.TodoListCompleted = false;

            toDoListManager.TRemove(find);

            return RedirectToAction("Index", "Dashborad");
        }
    }
}
