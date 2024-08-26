using DataAccessLayer.Abstract;
using DataAccessLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericDAL<T> where T : class
    {
        

        public void Add(T t)
        {
            using var c = new Context();

            c.Add(t);

            c.SaveChanges();

        }

        public List<T> GetAll()
        {
            using var c = new Context();

            return c.Set<T>().ToList();
        }

        public List<T> GetAll(Func<T, bool> Filter)
        {
            using var c = new Context();

            return c.Set<T>().Where(Filter).ToList();
        }

        public List<T> GetAllCount(int itemCount)
        {
            using var c = new Context();

            return c.Set<T>().Take(itemCount).ToList();
        }

        public T GetByID(int id)
        {
            using var c = new Context();

            return c.Set<T>().Find(id);
        }

        public void Remove(T t)
        {
            using var c = new Context();

            c.Remove(t);

            c.SaveChanges();
        }

        public void Uppdate(T t)
        {
            using var c = new Context();

            c.Update(t);

            c.SaveChanges();
        }
    }

    
    
    
}
