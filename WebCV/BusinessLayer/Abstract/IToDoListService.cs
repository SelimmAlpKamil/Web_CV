﻿using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IToDoListService:IGenericService<ToDoList>
    {
        List<ToDoList> TGetListDesc();
    }
}
