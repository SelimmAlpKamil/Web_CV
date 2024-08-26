using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGenericService<T> where T : class
    {

        void TAdd(T t);
        void TRemove(T t);
        void TUppdate(T t);
        List<T> TGetAll();
        List<T> TGetAllCount(int listCount);
        T TGetByID(int id);


    }
}
