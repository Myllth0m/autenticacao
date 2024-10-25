using System.ComponentModel.DataAnnotations;

namespace CustomAuth.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Username or email is required")]
        [MaxLength(20, ErrorMessage = "Max 20 characters allowed")]
        public string UserNameOrEmail { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Min 5 or max 20 characters allowed")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
