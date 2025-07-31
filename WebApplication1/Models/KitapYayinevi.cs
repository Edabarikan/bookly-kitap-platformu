namespace WebApplication1.Models
{
    public class KitapYayinevi
    {
        public int KitapYayineviID { get; set; }    
        public int KitapID { get; set; }    
        public int YayineviID { get; set; } 

        public Kitap? Kitap { get; set; }

        public Yayinevi? Yayinevi { get; set; } 
    }
}
