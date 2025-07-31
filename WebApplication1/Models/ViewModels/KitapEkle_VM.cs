using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebApplication1.Models.ViewModels
{
    public class KitapEkle_VM
    {
        public string KitapAdi { get; set; }    
        public double Fiyat { get; set; }    
        public int YazarID { get; set; }    
        public int YayineviID { get; set; }    
        public int KategoriID { get; set; }    
        public string Aciklama { get; set; }    
        public IFormFile KapakResmi { get; set; }    
        public SelectList Yazarlar { get; set; }   
        public SelectList Yayinevleri { get; set; }   
        public SelectList Kategoriler { get; set; }      
    }
}
