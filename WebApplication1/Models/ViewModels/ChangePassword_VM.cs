using System.ComponentModel.DataAnnotations;

namespace WebApplication1.ViewModels
{
    public class ChangePassword_VM
    {
        [Required]
        [DataType(DataType.Password)]
        public string OldPassword { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string NewPassword { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("NewPassword", ErrorMessage = "Şifreler eşleşmiyor.")]
        public string ConfirmNewPassword { get; set; }
    }
}
