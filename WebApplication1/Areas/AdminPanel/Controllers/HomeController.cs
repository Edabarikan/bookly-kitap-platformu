using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Areas.AdminPanel.Models.ViewModels;
using WebApplication1.Data;
using WebApplication1.Repositories;

namespace WebApplication1.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    [Authorize(Roles="Admin")]
    public class HomeController : Controller
    {
        private readonly KitapDBContext _kitapDBContext;

        public HomeController(KitapDBContext kitapDBContext)
        {
            _kitapDBContext = kitapDBContext;
        }

        public async Task<IActionResult> Index()
        {
            var model = new AdminDashboard_VM
            {
                ToplamKitap = await _kitapDBContext.Kitaplar.CountAsync(),
                ToplamYazar = await _kitapDBContext.Yazarlar.CountAsync(),
                ToplamKategori = await _kitapDBContext.Kategoriler.CountAsync(),
                ToplamYayinevi = await _kitapDBContext.Yayinevleri.CountAsync(),
                ToplamYorum = await _kitapDBContext.Yorumlar.CountAsync(),
                ToplamKitaplarYayinevleri = await _kitapDBContext.KitaplarYayinevleri.CountAsync(),

                EnCokBasilanKitap = await _kitapDBContext.KitaplarYayinevleri
                    .GroupBy(k => k.KitapID)
                    .OrderByDescending(g => g.Count())
                    .Take(5)
                    .Select(g => _kitapDBContext.Kitaplar
                        .Where(b => b.KitapID == g.Key)
                        .Select(b => b.KitapAdi)
                        .FirstOrDefault())
                    .ToListAsync(),

                EnCokKitapBasanYayinevi = await _kitapDBContext.KitaplarYayinevleri
                    .GroupBy(k => k.YayineviID)
                    .OrderByDescending(g => g.Count())
                    .Take(5)
                    .Select(g => _kitapDBContext.Yayinevleri
                        .Where(p => p.YayineviID == g.Key)
                        .Select(p => p.YayineviAdi)
                        .FirstOrDefault())
                    .ToListAsync(),

                SonEklenenKitaplar = await _kitapDBContext.Kitaplar
                    .OrderByDescending(k => k.EklenmeTarihi)
                    .Take(5)
                    .Select(k => k.KitapAdi)
                    .ToListAsync(),

                SonYapilanYorumlar = await _kitapDBContext.Yorumlar
                    .OrderByDescending(y => y.YorumTarihi)
                    .Take(5)
                    .Select(y => y.YorumMetni)
                    .ToListAsync(),

                KategoriAdlari = await _kitapDBContext.Kategoriler
                    .Select(k => k.KategoriAdi)
                    .ToListAsync(),

                KategoriSayilari = await _kitapDBContext.Kategoriler
                    .Select(k => _kitapDBContext.Kitaplar
                        .Count(kitap => kitap.KategoriID == k.KategoriID))
                    .ToListAsync()
            };

            return View(model);
        }
        public async Task<IActionResult> KitapListele()
        {
            var kitaplar = await _kitapDBContext.Kitaplar
                .Include(k => k.Kategori)
                .Include(k => k.Yazar)
                .Include(k => k.KitaplarYayinevleri)
                    .ThenInclude(ky => ky.Yayinevi)
                .AsNoTracking()
                .ToListAsync();
            return View(kitaplar);
        }

        public async Task<IActionResult> KategoriListele()
        {
            var kategoriler = await _kitapDBContext.Kategoriler
                .Include(k => k.Kitaplar)
                .AsNoTracking()
                .ToListAsync();
            return View(kategoriler);
        }

        public async Task<IActionResult> YazarListele()
        {
            var yazarlar = await _kitapDBContext.Yazarlar
                .Include(y => y.Kitap)
                .AsNoTracking()
                .ToListAsync();
            return View(yazarlar);
        }

        public async Task<IActionResult> YayineviListele()
        {
            var yayinevleri = await _kitapDBContext.Yayinevleri
                .Include(y => y.KitaplarYayinevleri)
                    .ThenInclude(ky => ky.Kitap)
                .AsNoTracking()
                .ToListAsync();
            return View(yayinevleri);
        }

        public async Task<IActionResult> YorumListele()
        {
            var yorumlar = await _kitapDBContext.Yorumlar
                .Include(y => y.Kitap)
                .Include(y => y.Kullanici)
                .OrderByDescending(y => y.YorumTarihi)
                .AsNoTracking()
                .ToListAsync();
            return View(yorumlar);
        }

    }
}
