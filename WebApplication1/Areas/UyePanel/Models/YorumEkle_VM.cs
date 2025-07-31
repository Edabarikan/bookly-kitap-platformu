using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplication1.Models;

namespace WebApplication1.Areas.UyePanel.Models
{
    public class YorumEkle_VM
    {
        [Required] //Zorunlu alan. 
        public string YorumMetni { get; set; }

        [Required] //Zorunlu alan (Yorum, spesifik bir KitapID'ye ait olmali).
        public int? KitapID { get; set; }

        public IEnumerable<SelectListItem> Kitaplar { get; set; } 
        

    }
}
