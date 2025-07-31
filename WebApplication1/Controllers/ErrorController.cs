using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult NotFoundPage() { return View("404"); }
        public IActionResult ServerError() { return View("500"); }

    }
}
