namespace WebApplication1.Models.ViewModels
{
    public class Yorum_VM
    {
        public int KitapID{ get; set; }
        public string KitapAdi{ get; set; }
        public string YazarAdSoyad{ get; set; }
        public string KapakResmi{ get; set; }
        public List<Yorum> Yorumlar { get; set; }
        public string YorumMetni {  get; set; } 
    }
}
