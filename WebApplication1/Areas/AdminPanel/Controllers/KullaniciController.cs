using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Areas.AdminPanel.Controllers
{
    [Authorize(Roles = "Admin")]
    public class KullaniciController : Controller
    {

        private readonly KitapDBContext _kitapDbContext;
        private readonly UserManager<AppUser> _userManager;
        public KullaniciController(KitapDBContext kitapDbContext, UserManager<AppUser> userManager)
        {
            _kitapDbContext = kitapDbContext;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}
