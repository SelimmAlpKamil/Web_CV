using BusinessLayer.Concreate;
using BusinessLayer.Validation;
using DataAccessLayer.Entity;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebCV.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    [Route("/Admin/[Controller]/[Action]/{id?}")]

    public class StudentController : Controller
    {
        StudentManager studentManager = new StudentManager(new EFStudentDAL());


        public IActionResult Index()
        {
            TempData["studentActive"] = "active";

            var list = studentManager.TGetAll();

            return View(list);
        }

        [HttpGet]
        public IActionResult UpdateStudent(int id)
        {
            TempData["studentActive"] = "active";

            var findExperience = studentManager.TGetByID(id);

            return View(findExperience);
        }

        [HttpPost]
        public IActionResult UpdateStudent(Student p)
        {
            StudentValidation validations = new StudentValidation();

            var rule = validations.Validate(p);

            if (rule.IsValid)
            {
                studentManager.TUppdate(p);
                return RedirectToAction("Index", "Student");
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

        [HttpGet]
        public IActionResult AddStudent()
        {
            TempData["studentActive"] = "active";

            return View();
        }

        [HttpPost]
        public IActionResult AddStudent(Student p)
        {
            StudentValidation validations = new StudentValidation();

            var rule = validations.Validate(p);

            if (rule.IsValid)
            {
                studentManager.TAdd(p);
                return RedirectToAction("Index", "Student");
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

        public IActionResult DeleteStudent(int id)
        {
            TempData["studentActive"] = "active"; ;

            var findStudent = studentManager.TGetByID(id);

            studentManager.TRemove(findStudent);

            return RedirectToAction("Index", "Student");
        }




    }
}
