using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Yazar
    {
        public int YazarID{ get; set; }
        public string YazarAd { get; set; }
        public string YazarSoyad { get; set; }
        public ICollection<Kitap>? Kitap { get; set; }

        [NotMapped]//SQL Server'da bu property için sütun oluşturma dedik.
        public string YazarAdSoyad => YazarAd + " " + YazarSoyad;
    }
}
