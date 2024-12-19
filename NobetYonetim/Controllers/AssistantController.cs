/* using Microsoft.AspNetCore.Mvc;
using NobetYonetim.Models;
using NobetYonetim.Repositories;

public class AssistantController : Controller
{
    private readonly IAssistantRepository _assistantRepository;

    public AssistantController(IAssistantRepository assistantRepository)
    {
        _assistantRepository = assistantRepository;
    }

    public async Task<IActionResult> Index()
    {
        var assistants = await _assistantRepository.GetAllAssistantsAsync();
        return View(assistants);
    }

    public async Task<IActionResult> Details(int id)
    {
        var assistant = await _assistantRepository.GetAssistantWithDetailsAsync(id);
        if (assistant == null) return NotFound();

        return View(assistant);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(Assistant assistant)
    {
        if (ModelState.IsValid)
        {
            await _assistantRepository.AddAssistantAsync(assistant);
            return RedirectToAction(nameof(Index));
        }
        return View(assistant);
    }

    public async Task<IActionResult> Edit(int id)
    {
        var assistant = await _assistantRepository.GetAssistantByIdAsync(id);
        if (assistant == null) return NotFound();

        return View(assistant);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, Assistant assistant)
    {
        if (id != assistant.AssistantId) return NotFound();

        if (ModelState.IsValid)
        {
            await _assistantRepository.UpdateAssistantAsync(assistant);
            return RedirectToAction(nameof(Index));
        }
        return View(assistant);
    }

    public async Task<IActionResult> Delete(int id)
    {
        var assistant = await _assistantRepository.GetAssistantByIdAsync(id);
        if (assistant == null) return NotFound();

        return View(assistant);
    }

    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _assistantRepository.DeleteAssistantAsync(id);
        return RedirectToAction(nameof(Index));
    }
}
*/