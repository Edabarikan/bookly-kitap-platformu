using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Repositories;

namespace WebApplication1.Areas.AdminPanel.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class YazarController : Controller
    {
  
        private readonly YazarRepository _yazarRepository;
        public YazarController(
            YazarRepository yazarRepository)
        {
            _yazarRepository = yazarRepository;

        }

        public async Task<IActionResult> YazarListesi()
        {
            var yazarlar = await _yazarRepository.Listele();
            return View(yazarlar);
        }

        public IActionResult YazarEkle()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> YazarEkle(Yazar yazar)
        {
            if (ModelState.IsValid)
            {
                await _yazarRepository.Ekle(yazar);
                return RedirectToAction(nameof(YazarListesi));
            }
            return View(yazar);
        }

        public async Task<IActionResult> YazarDuzenle(int id)
        {
            var yazar = await _yazarRepository.Ara(id);
            if (yazar == null) return NotFound();
            return View(yazar);
        }

        [HttpPost]
        public async Task<IActionResult> YazarDuzenle(Yazar yazar)
        {
            if (ModelState.IsValid)
            {
                await _yazarRepository.Guncelle(yazar);
                return RedirectToAction(nameof(YazarListesi));
            }
            return View(yazar);
        }

        public async Task<IActionResult> YazarSil(int id)
        {
            await _yazarRepository.Sil(id);
            return RedirectToAction(nameof(YazarListesi));
        }

    }
}
