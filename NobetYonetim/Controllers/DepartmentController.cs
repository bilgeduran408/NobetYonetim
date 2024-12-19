/* using Microsoft.AspNetCore.Mvc;
using NobetYonetim.Models;
using NobetYonetim.Repositories;
using System.Threading.Tasks;

namespace NobetYonetim.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentRepository _departmentRepository;

        public DepartmentController(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }

        // Index: Tüm departmanları listeleme
        public async Task<IActionResult> Index()
        {
            var departments = await _departmentRepository.GetAllDepartmentsAsync();
            return View(departments);
        }

        // Create: Yeni departman oluşturma
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Department department)
        {
            if (ModelState.IsValid)
            {
                await _departmentRepository.AddDepartmentAsync(department);
                return RedirectToAction(nameof(Index));
            }
            return View(department);
        }

        // Edit: Departmanı düzenleme
        public async Task<IActionResult> Edit(int id)
        {
            var department = await _departmentRepository.GetDepartmentByIdAsync(id);
            if (department == null)
            {
                return NotFound();
            }
            return View(department);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Department department)
        {
            if (id != department.DepartmentId)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                await _departmentRepository.UpdateDepartmentAsync(department);
                return RedirectToAction(nameof(Index));
            }
            return View(department);
        }

        // Delete: Departman silme
        public async Task<IActionResult> Delete(int id)
        {
            var department = await _departmentRepository.GetDepartmentByIdAsync(id);
            if (department == null)
            {
                return NotFound();
            }
            return View(department);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _departmentRepository.DeleteDepartmentAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
*/
