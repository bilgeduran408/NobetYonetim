/* using Microsoft.AspNetCore.Mvc;
using NobetYonetim.Models;
using NobetYonetim.Repositories;
using System.Threading.Tasks;

namespace NobetYonetim.Controllers
{
    public class ProfessorController : Controller
    {
        private readonly IProfessorRepository _professorRepository;

        // Constructor injection ile repository'yi alıyoruz
        public ProfessorController(IProfessorRepository professorRepository)
        {
            _professorRepository = professorRepository;
        }

        // Index action: Profesörlerin listesini görüntülemek için
        public async Task<IActionResult> Index()
        {
            var professors = await _professorRepository.GetAllAsync();
            return View(professors); // Professors listesini view'a gönderiyoruz
        }

        // Create action: Yeni profesör oluşturma formu
        public IActionResult Create()
        {
            return View(); // Create view'a yönlendiriyor
        }

        // Create POST action: Yeni profesörü veritabanına ekler
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Professor professor)
        {
            if (ModelState.IsValid)
            {
                await _professorRepository.AddAsync(professor);
                return RedirectToAction(nameof(Index)); // Başarıyla ekledikten sonra ana sayfaya yönlendiriyor
            }
            return View(professor); // Model geçerli değilse formu tekrar gösteriyor
        }

        // Edit action: Profesörün bilgilerini düzenlemek için
        public async Task<IActionResult> Edit(int id)
        {
            var professor = await _professorRepository.GetByIdAsync(id);
            if (professor == null)
            {
                return NotFound(); // Eğer profesör bulunamazsa, 404 döner
            }
            return View(professor); // Profesörü edit view'ına gönderiyor
        }

        // Edit POST action: Profesörün bilgilerini günceller
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Professor professor)
        {
            if (id != professor.ProfessorId)
            {
                return NotFound(); // Id uyuşmazsa, 404 döner
            }

            if (ModelState.IsValid)
            {
                await _professorRepository.UpdateAsync(professor);
                return RedirectToAction(nameof(Index)); // Başarıyla güncellendikten sonra ana sayfaya yönlendiriyor
            }
            return View(professor); // Model geçerli değilse formu tekrar gösteriyor
        }

        // Delete action: Profesörü silmek için
        public async Task<IActionResult> Delete(int id)
        {
            var professor = await _professorRepository.GetByIdAsync(id);
            if (professor == null)
            {
                return NotFound(); // Profesör bulunamazsa, 404 döner
            }
            return View(professor); // Profesörü delete view'ına gönderiyor
        }

        // Delete POST action: Profesörü siler
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var professor = await _professorRepository.GetByIdAsync(id);
            if (professor == null)
            {
                return NotFound(); // Profesör bulunamazsa, 404 döner
            }

            await _professorRepository.DeleteAsync(id);
            return RedirectToAction(nameof(Index)); // Başarıyla silindikten sonra ana sayfaya yönlendiriyor
        }
    }
}
*/