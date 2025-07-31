using System.ComponentModel.DataAnnotations;

namespace WebApplication1.ViewModels
{
    public class EditProfile_VM
    {
        [Required]
        [EmailAddress]
        public string Eposta { get; set; }

        public string KullaniciAdi { get; set; }    
        public string Adres { get; set; }    

        public string FullName { get; set; } 
    }
}
