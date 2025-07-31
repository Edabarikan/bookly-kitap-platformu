using WebApplication1.Models;

namespace WebApplication1.Areas.AdminPanel.Models.ViewModels
{
    public class AdminDashboard_VM
    {
        public int ToplamKitap { get; set; }
        public int ToplamYazar { get; set; }
        public int ToplamKategori { get; set; }
        public int ToplamYayinevi { get; set; }
        public int ToplamYorum { get; set; }
        public int ToplamKullanici { get; set; }
        public int ToplamKitaplarYayinevleri { get; set; } //Kitap-yayinevi iliskisi. Bu veri kullanilmazsa admin sayfasinda hata veriyor (rapora eklendigi icin).
        public List<string> EnCokBasilanKitap{ get; set; } //En cok yayinevi tarafindan basilmis kitaplar
        public List<string> EnCokKitapBasanYayinevi{ get; set; } 
        public List<string> SonEklenenKitaplar { get; set; } 
        public List<string> SonYapilanYorumlar { get; set; } 
        public List<string> KategoriAdlari {  get; set; }
        public List<int> KategoriSayilari {  get; set; }
        public List<string> Son7GunYorum {  get; set; } 
        public List<string> BugunEklenenKitap {  get; set; }
        public List<string> Kullanicilar {  get; set; }
        public DateTime EklenmeTarihi {  get; set; }
    }
}
