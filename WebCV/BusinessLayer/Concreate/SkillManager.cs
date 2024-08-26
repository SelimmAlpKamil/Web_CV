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
    public class SkillManager:ISkillService
    {
        EFSkillDAL _skill;

        public SkillManager(EFSkillDAL skill)
        {
            _skill = skill;
        }

        public void TAdd(Skill t)
        {
            _skill.Add(t);
        }

        public List<Skill> TGetAll()
        {
            return _skill.GetAll(); 
        }

        public List<Skill> TGetAllCount(int listCount)
        {
            return _skill.GetAllCount(listCount);
        }

        public Skill TGetByID(int id)
        {
           return  _skill.GetByID(id);
        }

        public void TRemove(Skill t)
        {
            _skill.Remove(t);
        }

        public void TUppdate(Skill t)
        {
            _skill.Uppdate(t);
        }
    }
}
