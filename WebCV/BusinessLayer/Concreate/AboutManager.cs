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
    public class AboutManager : IAboutService
    {

        EFAboutDAL _about;

        public AboutManager(EFAboutDAL about)
        {
            _about = about;
        }

        public void TAdd(About t)
        {
            _about.Add(t);
        }

        public List<About> TGetAll()
        {
            return _about.GetAll();
        }

        public List<About> TGetAllCount(int listCount)
        {
            return _about.GetAllCount(listCount);
        }

        public About TGetByID(int id)
        {
            return _about.GetByID(id);
        }

        public void TRemove(About t)
        {
            _about.Remove(t);
        }

        public void TUppdate(About t)
        {
            _about.Uppdate(t);
        }
    }
}
