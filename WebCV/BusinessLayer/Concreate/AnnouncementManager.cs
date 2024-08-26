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
    public class AnnouncementManager : IAnnouncementService
    {
        EFAnnouncementDAL _Announcemnt;

        public AnnouncementManager(EFAnnouncementDAL announcemnt)
        {
            _Announcemnt = announcemnt;
        }

        public void TAdd(Announcement t)
        {
            _Announcemnt.Add(t);
        }

        public List<Announcement> TGetAll()
        {
            return _Announcemnt.GetAll();
        }

        public List<Announcement> TGetAllCount(int listCount)
        {
            return _Announcemnt.GetAllCount(listCount);

        }
        public Announcement TGetByID(int id)
        {
            return _Announcemnt.GetByID(id);
        }

        public void TRemove(Announcement t)
        {
            _Announcemnt.Remove(t);
        }

        public void TUppdate(Announcement t)
        {
            _Announcemnt.Uppdate(t);
        }
    }
}
