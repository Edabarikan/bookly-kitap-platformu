using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Models.ViewModels;
using WebApplication1.Repositories;

namespace WebApplication1.Controllers
{
    public class KitapController : Controller
    {
        private readonly KitapRepository _kitapRepository; 
        private readonly UserManager<AppUser> _userManager;

        public KitapController(KitapRepository kitapRepository)
        {
            _kitapRepository = kitapRepository; //kitap repoyu newleyebiliriz!!! ama böyle kalsın.
        }

        // Kitapları Listeleme
        public async Task<IActionResult> Index()
        {
            var kitaplar = await _kitapRepository.TumKitaplar();
            var kitapVMList = kitaplar.Select(x => new Kitap_VM
            {
                KitapID = x.KitapID,
                KitapAdi = x.KitapAdi,
                Fiyat = x.Fiyat,
                KapakResmi = x.KapakResmi,
                Yazar = x.Yazar.YazarAdSoyad,
                Kategori = x.Kategori.KategoriAdi,
                Yayinevleri = x.KitaplarYayinevleri.Select(y => y.Yayinevi.YayineviAdi).ToList()
            }).ToList();

            return View(kitapVMList);
        }


        // Kitap Detayları + Yorumlar
        public async Task<IActionResult> Detay(int id)
        {
            var kitap = await _kitapRepository.IDyeGoreKitaplar(id);

            if (kitap == null)
            {
                return NotFound(); // Eğer kitap yoksa hata döndür
            }

            return View(kitap);
        }


    }
}
