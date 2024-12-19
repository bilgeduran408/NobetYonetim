using Microsoft.AspNetCore.Mvc;
using NobetYonetim.Data;
using NobetYonetim.Models;

namespace NobetYonetim.Controllers
{
    public class AdminController : Controller
    {
        private readonly AppDbContext _context;
        public AdminController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult AdminPaneli()
        {
            return View();
        }

        public IActionResult Asistan()
        {
            // Asistanları veritabanından çekiyoruz
            var assistants = _context.Assistants.ToList();
            return View(assistants);
        }

        // Asistan Ekleme (GET)
        public IActionResult CreateAsistan()
        {
            return View();
        }

        // Asistan Ekleme (POST)
        [HttpPost]
        public IActionResult CreateAsistan(Assistant assistant)
        {
            if (ModelState.IsValid)
            {
                // Yeni asistanı veritabanına ekliyoruz
                _context.Assistants.Add(assistant);
                _context.SaveChanges();
                return RedirectToAction("Asistanlar");
            }
            return View(assistant); // Hata varsa formu yeniden göster
        }

        // Asistan Düzenleme (GET)
        public IActionResult EditAsistan(int id)
        {
            // Asistanı veritabanından getiriyoruz
            var assistant = _context.Assistants.FirstOrDefault(a => a.AssistantId == id);
            if (assistant == null)
            {
                return NotFound();
            }
            return View(assistant);
        }

        // Asistan Düzenleme (POST)
        [HttpPost]
        public IActionResult EditAsistan(int id, Assistant assistant)
        {
            if (id != assistant.AssistantId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                // Veritabanındaki asistanı güncelliyoruz
                _context.Update(assistant);
                _context.SaveChanges();
                return RedirectToAction("Asistanlar");
            }
            return View(assistant); // Hata varsa formu yeniden göster
        }

        // Asistan Silme (GET)
        public IActionResult DeleteAsistan(int id)
        {
            // Asistanı veritabanından getiriyoruz
            var assistant = _context.Assistants.FirstOrDefault(a => a.AssistantId == id);
            if (assistant == null)
            {
                return NotFound();
            }
            return View(assistant);
        }

        // Asistan Silme (POST)
        [HttpPost, ActionName("DeleteAsistan")]
        public IActionResult DeleteConfirmed(int id)
        {
            var assistant = _context.Assistants.FirstOrDefault(a => a.AssistantId == id);
            if (assistant != null)
            {
                // Asistanı veritabanından siliyoruz
                _context.Assistants.Remove(assistant);
                _context.SaveChanges();
            }
            return RedirectToAction("Asistanlar");
        }
    }
}

