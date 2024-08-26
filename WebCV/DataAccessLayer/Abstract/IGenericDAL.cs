using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDAL<T> where T : class
    {
        void Add(T t);
        void Remove(T t);
        void Uppdate(T t);

        List<T> GetAll();
        List<T> GetAll(Func<T,bool>Filter);
        List<T> GetAllCount(int itemCount);


        T GetByID(int id);





    }
}
