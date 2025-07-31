namespace WebApplication1.Models
{
    public class Yayinevi
    {
        public int YayineviID { get; set; }
        public string YayineviAdi { get; set; }
        public ICollection<KitapYayinevi>? KitaplarYayinevleri { get; set; }   
    }
}
