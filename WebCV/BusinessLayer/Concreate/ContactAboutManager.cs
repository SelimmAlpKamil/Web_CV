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
    public class ContactAboutManager : IContactAboutService
    {
        EFContactAboutDAL _contactAboutDAL;

        public ContactAboutManager(EFContactAboutDAL contactAboutDAL)
        {
            _contactAboutDAL = contactAboutDAL;
        }

        public void TAdd(ContactAbout t)
        {
            _contactAboutDAL.Add(t);
        }

        public List<ContactAbout> TGetAll()
        {
            return _contactAboutDAL.GetAll();
        }

        public List<ContactAbout> TGetAllCount(int listCount)
        {
            return _contactAboutDAL.GetAllCount(listCount);
        }

        public ContactAbout TGetByID(int id)
        {
            return _contactAboutDAL.GetByID(id);
        }

        public void TRemove(ContactAbout t)
        {
            _contactAboutDAL.Remove(t);
        }

        public void TUppdate(ContactAbout t)
        {
            _contactAboutDAL.Uppdate(t);
        }
    }
}
