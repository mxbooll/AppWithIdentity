using System.ComponentModel.DataAnnotations;

namespace AppWithIdentity.ViewModels
{
    public class ResetPasswordViewModel
    {
        public string Id { get; set; }
        
        public string Email { get; set; }

        [Required]
        public string NewPassword { get; set; }

        [Compare("NewPassword", ErrorMessage = "Пароли не совпадают")]
        public string PasswordConfirm { get; set; }
    }
}
