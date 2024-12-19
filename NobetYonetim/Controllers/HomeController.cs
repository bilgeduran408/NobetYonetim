using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NobetYonetim.Models;

namespace NobetYonetim.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        //ana sayfa 
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Asistan()
        {
            return View();
        }

        public IActionResult OgretimUyeleri()
        {
            return View();
        }
        public IActionResult Bolum()
        {
            return View();
        }
        public IActionResult Takvim()
        {
            return View();
        }
        public IActionResult Randevu()
        {
            return View();
        }
        public IActionResult Acildurum()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
