using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models.ViewModels
{
    public class Register_VM
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Adres { get; set; }
        public string Kullanici { get; set; }

        [EmailAddress(ErrorMessage = "E-posta adresi geçerli değil...")]
        public string EMail { get; set; }

        
        [StringLength(12, ErrorMessage = "Min 5,Max 12 karakter olmalı...", MinimumLength = 5)]


        [Compare("SifreTekrar", ErrorMessage = "Şifre ve Şifre Tekrar aynı değil...")]
        public string Sifre { get; set; }
        public string SifreTekrar { get; set; }

    }
}
