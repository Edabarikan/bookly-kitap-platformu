using Microsoft.AspNetCore.Identity;

namespace WebApplication1.Models
{
    public class AppUser:IdentityUser<int>
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }

        // FullName'i disaridan da guncellenebilir yapalim (readonly yapilirsa AccountController'da hata veriyor)
        public string FullName
        {
            get => Ad + " " + Soyad;
            set
            {
                var names = value.Split(' ');
                Ad = names[0];
                Soyad = names.Length > 1 ? names[1] : "";
            }
        }
        public string Adres { get; set; }


        public ICollection<Yorum>? Yorumlar { get; set; }
        public ICollection<Kitap>? Kitaplar { get; set; }   
        

    }
}
