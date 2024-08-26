using System.ComponentModel.DataAnnotations;

namespace WebCV.Areas.User.Models
{
    public class UserUpdateViewModel
    {
        [Required(ErrorMessage = "Boş geçilemez")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Boş geçilemez")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Boş geçilemez")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Boş geçilemez")]
        public string Phone { get; set; }


        [Required(ErrorMessage = "Boş geçilemez")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Boş geçilemez")]
        [Compare("Password", ErrorMessage = "Şifre eşleşmiyor")]
        public string PasswordConfing { get; set; }
    }
}
