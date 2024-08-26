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
    public class FeatureManager:IFeatureService
    {
        EFFeatureDAL _feature;

        public FeatureManager(EFFeatureDAL feature)
        {
            _feature = feature;
        }

        public void TAdd(Feature t)
        {
            _feature.Add(t);
        }

        public List<Feature> TGetAll()
        {
            return _feature.GetAll();   
        }

        public List<Feature> TGetAllCount(int listCount)
        {
            return _feature.GetAllCount(listCount);
        }

        public Feature TGetByID(int id)
        {
            return _feature.GetByID(id);

        }
        public void TRemove(Feature t)
        {
            _feature.Remove(t);
        }

        public void TUppdate(Feature t)
        {
            _feature.Uppdate(t);
        }
    }
}
