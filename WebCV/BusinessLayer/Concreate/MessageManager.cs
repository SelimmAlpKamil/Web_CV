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
    public class MessageManager:IMessageService
    {
        EFMessageDAL _messege;

        public MessageManager(EFMessageDAL messege)
        {
            _messege = messege;
        }

        public List<Message> ReceverMessageList(string userMail)
        {
            return _messege.GetAll(x=>x.Recever == userMail);
        }

        public List<Message> SenderMessageList(string userMail)
        {
            return _messege.GetAll(x => x.Sender == userMail);
        }

        public void TAdd(Message t)
        {
            _messege.Add(t);
        }

        public List<Message> TGetAll()
        {
            return _messege.GetAll();
        }

        public List<Message> TGetAllCount(int listCount)
        {
            return _messege.GetAllCount(listCount);
        }

        public Message TGetByID(int id)
        {
            return _messege.GetByID(id);
        }

        public void TRemove(Message t)
        {
            _messege.Remove(t);
        }

        public void TUppdate(Message t)
        {
            _messege.Uppdate(t);
        }
    }
}
