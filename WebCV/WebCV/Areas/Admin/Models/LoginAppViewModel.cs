using System.ComponentModel.DataAnnotations;

namespace WebCV.Areas.Admin.Models
{
    public class LoginAppViewModel
    {
        [Required(ErrorMessage ="Boş Geçilemez")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Boş Geçilemez")]
        public string Password { get; set; }


    }
}
