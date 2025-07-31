using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Repositories;

namespace WebApplication1.Areas.AdminPanel.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class KategoriController : Controller
    {

        private readonly KategoriRepository _kategoriRepository;
        public KategoriController(
            KategoriRepository kategoriRepository)
        {
            _kategoriRepository = kategoriRepository;

        }

        public async Task<IActionResult> KategoriListesi()
        {
            var kategoriler = await _kategoriRepository.Listele();
            return View(kategoriler);
        }

        public IActionResult KategoriEkle()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> KategoriEkle(Kategori kategori)
        {
            if (ModelState.IsValid)
            {
                await _kategoriRepository.Ekle(kategori);
                return RedirectToAction(nameof(KategoriListesi));
            }
            return View(kategori);
        }

        public async Task<IActionResult> KategoriDuzenle(int id)
        {
            var kategori = await _kategoriRepository.Ara(id);
            if (kategori == null) return NotFound();
            return View(kategori);
        }

        [HttpPost]
        public async Task<IActionResult> KategoriDuzenle(Kategori kategori)
        {
            if (ModelState.IsValid)
            {
                await _kategoriRepository.Guncelle(kategori);
                return RedirectToAction(nameof(KategoriListesi));
            }
            return View(kategori);
        }

        public async Task<IActionResult> KategoriSil(int id)
        {
            await _kategoriRepository.Sil(id);
            return RedirectToAction(nameof(KategoriListesi));
        }
    }

  
}
