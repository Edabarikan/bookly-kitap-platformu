using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Kitap
    {
        public int KitapID { get; set; }
        public string KitapAdi { get; set; }
        public double Fiyat { get; set; }
        public int YazarID { get; set; }
        public int YayineviID { get; set; }
        public int KategoriID { get; set; }
        public string Aciklama { get; set; }
        public string KapakResmi { get; set; }
        public DateTime EklenmeTarihi { get; set; }
        public Yazar? Yazar { get; set; } //Bir kitabin bir yazari olabilir: nav prop'ta tekil nesne kullandik.
        public Kategori? Kategori { get; set; } //Bir kitabin bir yazari olabilir: nav prop'ta tekil nesne kullandik.
        public ICollection<KitapYayinevi>? KitaplarYayinevleri { get; set; } //Bir kitabin birden fazla yayinevi olabilir: koleksiyon kullandik.

        public ICollection<Yorum>? Yorumlar { get; set; } //Bir kitabin birden fazla yorumu olabilir: koleksiyon kullandik.



        //hangi kitabı kimin eklediğini belirtmek için ekledik.
        [ForeignKey("User")]
        public int? AppUserID { get; set; }

        public AppUser User { get; set; }
    }

}
