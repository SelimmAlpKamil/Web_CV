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
    public class ExperienceManager:IExperienceService
    {
        EFExperienceDAL _experience;

        public ExperienceManager(EFExperienceDAL experience)
        {
            _experience = experience;
        }

        public void TAdd(Experience t)
        {
            _experience.Add(t);
        }

        public List<Experience> TGetAll()
        {
            return _experience.GetAll();    
        }

        public List<Experience> TGetAllCount(int listCount)
        {
            return _experience.GetAllCount(listCount);
        }

        public Experience TGetByID(int id)
        {
            return _experience.GetByID(id);
        }

        public void TRemove(Experience t)
        {
            _experience.Remove(t);
        }

        public void TUppdate(Experience t)
        {
            _experience.Uppdate(t);
        }
    }
}
