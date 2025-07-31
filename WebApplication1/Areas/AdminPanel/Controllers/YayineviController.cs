using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Repositories;

namespace WebApplication1.Areas.AdminPanel.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class YayineviController : Controller
    {
        private readonly YayineviRepository _yayineviRepository;
        public YayineviController(
            YayineviRepository yayineviRepository)
        {
            _yayineviRepository = yayineviRepository;

        }

        public async Task<IActionResult> YayineviListesi()
        {
            var yayinevleri = await _yayineviRepository.Listele();
            return View(yayinevleri);
        }

        public IActionResult YayineviEkle()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> YayineviEkle(Yayinevi yayinevi)
        {
            if (ModelState.IsValid)
            {
                await _yayineviRepository.Ekle(yayinevi);
                return RedirectToAction(nameof(YayineviListesi));
            }
            return View(yayinevi);
        }

        public async Task<IActionResult> YayineviDuzenle(int id)
        {
            var yayinevi = await _yayineviRepository.Ara(id);
            if (yayinevi == null) return NotFound();
            return View(yayinevi);
        }

        [HttpPost]
        public async Task<IActionResult> YayineviDuzenle(Yayinevi yayinevi)
        {
            if (ModelState.IsValid)
            {
                await _yayineviRepository.Guncelle(yayinevi);
                return RedirectToAction(nameof(YayineviListesi));
            }
            return View(yayinevi);
        }

        public async Task<IActionResult> YayineviSil(int id)
        {
            await _yayineviRepository.Sil(id);
            return RedirectToAction(nameof(YayineviListesi));
        }

    }
}
