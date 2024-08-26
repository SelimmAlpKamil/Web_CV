using DataAccessLayer.Abstract;
using DataAccessLayer.Concreate;
using DataAccessLayer.Repository;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entity
{
    public class EFToDoListDAL : GenericRepository<ToDoList>, IToDoListDAL
    {
        public List<ToDoList> GetListDesc()
        {
            using var c = new Context();

            return c.ToDoLists.OrderByDescending(x => x.TodoListId).ToList();
        }
    }
}
