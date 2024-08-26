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
    public class ServiceManager:IServiceService
    {
        EFServiceDAL _service;

        public ServiceManager(EFServiceDAL service)
        {
            _service = service;
        }

        

        public void TAdd(Service t)
        {
            _service.Add(t);
        }

        public List<Service> TGetAll()
        {
           return  _service.GetAll();
        }

        public Service TGetByID(int id)
        {
            return _service.GetByID(id);
        }

        public void TRemove(Service t)
        {
            _service.Remove(t);
        }

        public void TUppdate(Service t)
        {
            _service.Uppdate(t);    
        }

        public List<Service> TGetAllCount(int listCount)
        {
            return _service.GetAllCount(listCount);
        }
    }
}
