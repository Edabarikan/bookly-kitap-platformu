using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApplication1.Areas.UyePanel.Models;
using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.Repositories;

namespace WebApplication1.Areas.UyePanel.Controllers
{
    [Authorize(Roles = "Uye")]
    [Area("UyePanel")]
    public class HomeController : Controller
    {

        BaseRepository<Yorum> _yorumRepository;
        BaseRepository<Kitap> _kitapRepository;
        UserManager<AppUser> _userManager;

        public HomeController(BaseRepository<Yorum> yorumRepository, BaseRepository<Kitap> kitapRepository, UserManager<AppUser> userManager)
        {
            _yorumRepository = yorumRepository;
            _kitapRepository = kitapRepository;
            _userManager = userManager;
        }


        //sadece kitaplara yorum yazabilir.
        public async Task<IActionResult> Index()
        {
            return View();
        }

        public async Task<IActionResult> YorumEkle(int? id=1)
        {
            var kitaplar = await _kitapRepository.Listele();

            YorumEkle_VM yorumForm = new YorumEkle_VM
            {
                Kitaplar = new SelectList(kitaplar, "KitapID", "KitapAdi")
            };

            return View(yorumForm);

        }

        [HttpPost]
        public async Task<IActionResult> YorumEkle(YorumEkle_VM yorum)
        {
            
            if (!ModelState.IsValid)
            {
                var kitaplar = await _kitapRepository.Listele();
                yorum.Kitaplar = new SelectList(kitaplar, "KitapID", "KitapAdi");
                return View(yorum);
            }

            Yorum yeniYorum = new Yorum
            {
                YorumMetni = yorum.YorumMetni,
                YorumTarihi = DateTime.Now,
                KullaniciID = await GetUserIDAsync(),
                KitapID = yorum.KitapID 
            };

            await _yorumRepository.Ekle(yeniYorum);
            return RedirectToAction("Index", "Home"); // Yorum eklendikten sonra yönlendirme yaptık.
        }

        private async Task<int> GetUserIDAsync()
        {
            var userId = await _userManager.GetUserIdAsync(await _userManager.GetUserAsync(User));
            return int.Parse(userId);
        }
    }

}

