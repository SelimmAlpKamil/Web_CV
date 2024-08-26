using System.ComponentModel.DataAnnotations;

namespace WebCV.Areas.Admin.Models
{
    public class RegisterAppViewModel
    {
        [Key]
        [Required(ErrorMessage ="Boş geçilemez")]
        [MaxLength(100,ErrorMessage ="Maksimum karakter sınırı 100")]
        [MinLength(1,ErrorMessage ="Minimum karakter sınırı 1")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Boş geçilemez")]
        [MaxLength(100, ErrorMessage = "Maksimum karakter sınırı 100")]
        [MinLength(1, ErrorMessage = "Minimum karakter sınırı 1")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Boş geçilemez")]
        [MaxLength(100, ErrorMessage = "Maksimum karakter sınırı 100")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Boş geçilemez")]
        [MaxLength(100, ErrorMessage = "Maksimum karakter sınırı 100")]
        [MinLength(8, ErrorMessage = "Minimum karakter sınırı 8")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Boş geçilemez")]
        [MaxLength(100, ErrorMessage = "Maksimum karakter sınırı 100")]
        [MinLength(5, ErrorMessage = "Minimum karakter sınırı 5")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Boş geçilemez")]
        [MaxLength(100, ErrorMessage = "Maksimum karakter sınırı 100")]
        [MinLength(5, ErrorMessage = "Minimum karakter sınırı 5")]
        [Compare("Password",ErrorMessage ="Şifreler uyuşmuyor")]
        public string ConfigPassword { get; set; }
    }
}
