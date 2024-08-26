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
    public class EFContactDAL : GenericRepository<Contact>, IContactDAL
    {
        public List<Contact> GetActiveMessage()
        {
            using var c = new Context();

            return c.Contacts.OrderByDescending(x => x.ContactId).Where(x=>x.ContactStatus==true).ToList();
        }

        public List<Contact> GetContactDESC(int listCount)
        {
            using var c = new Context();

            return c.Contacts.OrderByDescending(x=>x.ContactId).Take(listCount).Where(x=>x.ContactStatus==true).ToList();
        }

        public List<Contact> GetPasifMessage()
        {
            using var c = new Context();

            return c.Contacts.OrderByDescending(x => x.ContactId).Where(x => x.ContactStatus == false).ToList();
        }
    }
}
