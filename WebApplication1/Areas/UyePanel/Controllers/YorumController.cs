using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Repositories;

namespace WebApplication1.Areas.UyePanel.Controllers
{
    [Area("Uye")]
    [Authorize(Roles = "Uye")]
    public class YorumController : Controller
    {
        private readonly BaseRepository<Yorum> _yorumRepository;
        public YorumController(
            BaseRepository<Yorum> yorumRepository)
        {
            _yorumRepository = yorumRepository;
        }

        public async Task<IActionResult> YorumListesi()
        {
            var yorumlar = await _yorumRepository.Listele();
            return View(yorumlar);
        }

        public IActionResult YorumEkle()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> YorumEkle(Yorum yorum)
        {
            if (ModelState.IsValid)
            {
                await _yorumRepository.Ekle(yorum);
                return RedirectToAction(nameof(YorumListesi));
            }
            return View(yorum);
        }

        public async Task<IActionResult> YorumDuzenle(int id)
        {
            var yorum = await _yorumRepository.Ara(id);
            if (yorum == null) return NotFound();
            return View(yorum);
        }

        [HttpPost]
        public async Task<IActionResult> YorumDuzenle(Yorum yorum)
        {
            if (ModelState.IsValid)
            {
                await _yorumRepository.Guncelle(yorum);
                return RedirectToAction(nameof(YorumListesi));
            }
            return View(yorum);
        }

        public async Task<IActionResult> YorumSil(int id)
        {
            await _yorumRepository.Sil(id);
            return RedirectToAction(nameof(YorumListesi));
        }

    }
}
