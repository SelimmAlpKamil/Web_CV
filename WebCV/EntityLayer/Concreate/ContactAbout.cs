using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
    public class ContactAbout
    {
        [Key]
        public int ContactAboutId { get; set; }
        public string ContactAboutDescripton { get; set; }
        public string ContactAboutMail { get; set; }
        public string ContactAboutPhone { get; set; }
        public string ContactAboutGithub { get; set; }
    }
}
