using System.ComponentModel.DataAnnotations;
using System.Security.AccessControl;
namespace Company.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "UsernameRequired")]
        [Display(Name = "Username")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "PasswordRequired")]
        [UIHint("password")]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember")]
        public bool RememberMe { get; set; }
    }
}
