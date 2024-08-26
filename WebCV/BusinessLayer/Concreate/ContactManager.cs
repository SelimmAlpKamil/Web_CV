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
    public class ContactManager:IContactService
    {
        EFContactDAL _contact;

        public ContactManager(EFContactDAL contact)
        {
            _contact = contact;
        }

        public void TAdd(Contact t)
        {
            _contact.Add(t);
        }

        public List<Contact> TGetActiveMessage()
        {
           return _contact.GetActiveMessage();
        }

        public List<Contact> TGetAll()
        {
            return _contact.GetAll();   
        }

        public List<Contact> TGetAllCount(int listCount)
        {
            return _contact.GetAllCount(listCount);
        }

        public Contact TGetByID(int id)
        {
            return _contact.GetByID(id);
        }

        public List<Contact> TGetContactDESC(int listCount)
        {
            return _contact.GetContactDESC(listCount);
        }

        public List<Contact> TGetPasifMessage()
        {
            return _contact.GetPasifMessage();
        }

        public void TRemove(Contact t)
        {
            _contact.Remove(t);
        }

        public void TUppdate(Contact t)
        {
            _contact.Uppdate(t);
        }
    }
}
