using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
    public class ToDoList
    {
        public int TodoListId { get; set; }
        public string TodoListTitle { get; set; }
        public bool TodoListCompleted { get; set; }
    }
}
