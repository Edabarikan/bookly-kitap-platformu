namespace WebApplication1.Models.ViewModels
{
    public class Kitap_VM
    {
        public int KitapID { get; set; }
        public string KitapAdi { get; set; }
        public double Fiyat { get; set; }
        public string KapakResmi { get; set; }
        public string Yazar { get; set; }
        public string Kategori { get; set; }
        public List<string> Yayinevleri { get; set; } // Coka cok iliskili yayinevleri listesi
        

    }
}
