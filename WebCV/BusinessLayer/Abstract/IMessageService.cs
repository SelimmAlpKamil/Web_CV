﻿using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IMessageService:IGenericService<Message>
    {
        List<Message> ReceverMessageList(string userMail);
        List<Message> SenderMessageList(string userMail);





    }
}
