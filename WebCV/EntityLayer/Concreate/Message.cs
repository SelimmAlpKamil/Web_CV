using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
    public class Message
    {
        public int MessageId { get; set; }
        public string Sender  { get; set; }
        public string Recever  { get; set; }
        public string MessageSubject  { get; set; }
        public string MessageContact  { get; set; }
        public DateTime MessageDateTime  { get; set; }
    }
}
