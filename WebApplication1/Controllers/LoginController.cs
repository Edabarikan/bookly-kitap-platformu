using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages;
using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.Models.ViewModels;

namespace WebApplication1.Controllers
{
    public class LoginController : Controller
    {
        private readonly UserManager<AppUser> _userManager; 
        private readonly SignInManager<AppUser> _signInManager; //Kullanici adi ve sifre zorunlu alan: bu bilgileri girerek sisteme giris yapilabiliyor. Kullanici adi ve sifrenin dogrulugunu kontrol etmek icin veritabanina ulasilmali, bunun icin de AppUser tablosuna erisebilmeliyiz.
        public LoginController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(Login_VM login)
        {
            if (ModelState.IsValid) // Kullanici adi ve sifreyi kontrol et
            {
                // Kullaniciyi bul
                var uye = await _userManager.FindByNameAsync(login.Kullanici);

                if (uye == null)
                {
                    ModelState.AddModelError("Hata", "Kullanıcı bulunamadı.");
                    return View();
                }

                // Sifre kontrolu
                var uyeVarMi = await _userManager.CheckPasswordAsync(uye, login.Sifre);

                if (!uyeVarMi)
                {
                    ModelState.AddModelError("Hata", "Şifre yanlış.");
                    return View();
                }

                // Kullanici girisi
                await _signInManager.SignInAsync(uye, isPersistent: false);

                // Kullanicinin rolunu belirle
                var roles = await _userManager.GetRolesAsync(uye);

                if (roles.Contains("Admin"))
                {
                    return RedirectToAction("Index", "AdminPanel"); // Admin giris yaparsa AdminPanel'e yonlendir.
                }

                return RedirectToAction("Index", "UyePanel"); // Uye giris yaparsa UyePanel'in index aksiyonuna yonlendir.
            }

            return View();
        }

        public IActionResult Register()
        {
            return View();
        }
     

        [HttpPost]
        public async Task<IActionResult> Register(Register_VM uye)
        {
            if (ModelState.IsValid)
            {
                AppUser yeniUye = new AppUser()
                {
        

                    Ad = uye.Ad,
                    Soyad = uye.Soyad,
                    Adres = uye.Adres,
                    UserName = uye.Kullanici,
                    Email = uye.EMail
                };

                var result = await _userManager.CreateAsync(yeniUye, uye.Sifre);

                if (result.Succeeded)
                    await _userManager.AddToRoleAsync(yeniUye, "Uye");
            }
            return RedirectToAction("Login", "Login");
        }

        public async Task<IActionResult> Logout() 
{
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Kitap"); //Kullanici cikis yapinca KitapController'in Index aksiyonuna gider(tum kitaplari listeler).
        }


    }
}
