using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Yorum
    {
        public int YorumID { get; set; }
        public string YorumMetni { get; set; }

        public int? KitapID { get; set; }
        [ForeignKey("KitapID")]
        public Kitap? Kitap { get; set; }

        [ForeignKey("KullaniciID")]
        public int? KullaniciID { get; set; }
        public AppUser? Kullanici { get; set; }

        public DateTime YorumTarihi { get; set; } = DateTime.Now;
    }
}
