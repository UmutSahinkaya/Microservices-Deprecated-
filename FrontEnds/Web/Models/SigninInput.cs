using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
    public class SigninInput
    {
        [Display(Name ="Email adresiniz")]
        [Required]
        public string Email { get; set; }
        [Display(Name = "Şifreniz")]
        [Required]
        public string Password { get; set; }
        [Display(Name = "Beni Hatırla")]
        public bool IsRemember { get; set; }
    }
}
