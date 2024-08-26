using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IContactDAL:IGenericDAL<Contact>
    {
        List<Contact> GetContactDESC(int listCount);

        List<Contact> GetActiveMessage();

        List<Contact> GetPasifMessage();


    }
}
