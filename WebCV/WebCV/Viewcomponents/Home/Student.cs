using BusinessLayer.Concreate;
using DataAccessLayer.Entity;
using Microsoft.AspNetCore.Mvc;

namespace WebCV.Viewcomponents.Home
{
    public class Student : ViewComponent
    {
        StudentManager studentManager = new StudentManager(new EFStudentDAL());

        public IViewComponentResult Invoke()
        {
            var list = studentManager.TGetAll();

            return View(list);
        }
    }
}
