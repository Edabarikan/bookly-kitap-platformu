using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebApplication1.Models.ViewModels
{
    public class KitapEkleForm_VM
    {
        public KitapEkle_VM Kitap { get; set;}
        public SelectList Yazarlar { get; set;} 
        public SelectList Yayinevleri { get; set;}  
        public SelectList Kategoriler {  get; set;} 
    }
}
