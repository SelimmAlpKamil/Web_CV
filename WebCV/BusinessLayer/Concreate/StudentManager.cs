using BusinessLayer.Abstract;
using DataAccessLayer.Entity;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concreate
{
    public class StudentManager : IStudentService
    {
        EFStudentDAL _student;

        public StudentManager(EFStudentDAL student)
        {
            _student = student;
        }

        public void TAdd(Student t)
        {
            _student.Add(t);
        }

        public List<Student> TGetAll()
        {
            return _student.GetAll();   
        }

        public List<Student> TGetAllCount(int listCount)
        {
            return _student.GetAllCount(listCount);
        }

        public Student TGetByID(int id)
        {
            return _student.GetByID(id);
        }

        public void TRemove(Student t)
        {
            _student.Remove(t);
        }

        public void TUppdate(Student t)
        {
            _student.Uppdate(t);
        }
    }
}
