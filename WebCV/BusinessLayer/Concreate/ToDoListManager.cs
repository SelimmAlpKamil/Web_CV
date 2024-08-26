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
    public class ToDoListManager : IToDoListService
    {
        EFToDoListDAL _toDoList;

        public ToDoListManager(EFToDoListDAL toDoList)
        {
            _toDoList = toDoList;
        }

        public void TAdd(ToDoList t)
        {
            _toDoList.Add(t);
        }

        public List<ToDoList> TGetAll()
        {
            return _toDoList.GetAll();
        }

        public List<ToDoList> TGetAllCount(int listCount)
        {
            return _toDoList.GetAllCount(listCount);
        }

        public ToDoList TGetByID(int id)
        {
            return _toDoList.GetByID(id);
        }

        public List<ToDoList> TGetListDesc()
        {
            return _toDoList.GetListDesc();
        }

        public void TRemove(ToDoList t)
        {
            _toDoList.Remove(t);
        }

        public void TUppdate(ToDoList t)
        {
            _toDoList.Uppdate(t);   
        }
    }
}
