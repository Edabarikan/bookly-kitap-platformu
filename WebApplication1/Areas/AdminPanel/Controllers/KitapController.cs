using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApplication1.Models;
using WebApplication1.Models.ViewModels;
using WebApplication1.Repositories;
using WebApplication1.Utilities;

namespace WebApplication1.Areas.AdminPanel.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class KitapController : Controller
    {
        private readonly KitapRepository _kitapRepository;
        private readonly YazarRepository _yazarRepository;
        private readonly KategoriRepository _kategoriRepository;
        private readonly YayineviRepository _yayineviRepository;

        public KitapController(KitapRepository kitapRepository, YazarRepository yazarRepository, KategoriRepository kategoriRepository, YayineviRepository yayineviRepository)
        {
            _kitapRepository = kitapRepository;
            _yazarRepository = yazarRepository;
            _kategoriRepository = kategoriRepository;
            _yayineviRepository = yayineviRepository;
        }

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

        // Kitap Ekleme Sayfası
        public async Task<IActionResult> Ekle()
        {
            var kitapEkle_VM = new KitapEkle_VM
            {
                Yazarlar = new SelectList(await _yazarRepository.Listele(), "YazarID", "YazarAdSoyad"),
                Yayinevleri = new SelectList(await _yayineviRepository.Listele(), "YayineviID", "YayineviAdi"),
                Kategoriler = new SelectList(await _kategoriRepository.Listele(), "KategoriID", "KategoriAdi")
            };

            return View(kitapEkle_VM);
        }

        // Kitap Ekleme İşlemi
        [HttpPost]
        public async Task<IActionResult> Ekle(KitapEkle_VM kitap, int[] yayinevi)
        {
            string dosyaAdi = FileOperations.UploadFile(kitap.KapakResmi);

            Kitap yeniKitap = new Kitap
            {
                KitapAdi = kitap.KitapAdi,
                Fiyat = kitap.Fiyat,
                YazarID = kitap.YazarID,
                KategoriID = kitap.KategoriID,
                Aciklama = kitap.Aciklama,
                KapakResmi = dosyaAdi
            };

            await _kitapRepository.Ekle(yeniKitap);

            // Çoka çok ilişkiyi (Kitap-Yayınevi) kaydet
            foreach (var yayineviID in yayinevi)
            {
                await _kitapRepository.KitapYayineviEkleme(yeniKitap.KitapID, yayineviID);
            }

            return RedirectToAction("Index");
        }

        // Kitap Silme
        public async Task<IActionResult> Sil(int id)
        {
            await _kitapRepository.Sil(id);
            return RedirectToAction("Index");
        }

    }
}
