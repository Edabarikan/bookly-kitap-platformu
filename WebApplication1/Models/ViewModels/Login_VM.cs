using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models.ViewModels
{
    public class Login_VM
    {
        // Kullanici adi icin dogrulama kurali (bos gecilemez)
        [Required(ErrorMessage = "Kullanıcı adı gereklidir.")]
        [StringLength(50, ErrorMessage = "Kullanıcı adı maksimum 50 karakter olmalıdır.")]
        public string Kullanici { get; set; }

        // Sifre icin dogrulama kurali (bos gecilemez, minimum 6 karakter)
        [Required(ErrorMessage = "Şifre gereklidir.")]
        [DataType(DataType.Password)] // sifreyi gizlemek icin
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Şifre en az 6 karakter olmalıdır.")]
        public string Sifre { get; set; }

    }
}
