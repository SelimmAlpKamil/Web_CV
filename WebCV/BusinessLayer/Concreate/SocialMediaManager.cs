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
    public class SocialMediaManager:ISocialMediaService
    {
        EFSocialMediaDAL _socialMedia;

        public SocialMediaManager(EFSocialMediaDAL socialMedia)
        {
            _socialMedia = socialMedia;
        }

        public void TAdd(SocialMedia t)
        {
            _socialMedia.Add(t);
        }

        public List<SocialMedia> TGetAll()
        {
            return _socialMedia.GetAll();   
        }

        public List<SocialMedia> TGetAllCount(int listCount)
        {
            return _socialMedia.GetAllCount(listCount);
        }

        public SocialMedia TGetByID(int id)
        {
            return _socialMedia.GetByID(id);
        }

        public void TRemove(SocialMedia t)
        {
            _socialMedia.Remove(t);
        }

        public void TUppdate(SocialMedia t)
        {
            _socialMedia.Uppdate(t);
        }
    }
}
