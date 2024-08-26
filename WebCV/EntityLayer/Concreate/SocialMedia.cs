using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
    public class SocialMedia
    {
        [Key]
        public int SocialMediaId { get; set; }
        public string SocialMediaName { get; set; }
        public string SocialMediaURL { get; set; }
        public string SocialMediaIcon { get; set; }
    }
}
