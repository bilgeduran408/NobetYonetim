/*using Microsoft.EntityFrameworkCore;
using NobetYonetim.Data;
using NobetYonetim.Models;

public class AssistantRepository : IAssistantRepository
{
    private readonly AppDbContext _context;

    public AssistantRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Assistant>> GetAllAssistantsAsync()
    {
        return await _context.Assistants
            .Include(a => a.Admin)
            .Include(a => a.Shifts)
            .Include(a => a.Patients)
            .Include(a => a.Appointments)
            .ToListAsync();
    }

    public async Task<Assistant> GetAssistantByIdAsync(int id)
    {
        var assistant = await _context.Assistants.FindAsync(id);

        if (assistant == null)
        {
            throw new ArgumentNullException($"Assistant with ID {id} not found.");
        }

        return assistant;
    }

    public async Task<Assistant> GetAssistantWithDetailsAsync(int id)
    {
        var assistant = await _context.Assistants
            .Include(a => a.Admin)
            .Include(a => a.Shifts)
            .Include(a => a.Patients)
            .Include(a => a.Appointments)
            .FirstOrDefaultAsync(a => a.AssistantId == id);

        if (assistant == null)
        {
            throw new ArgumentNullException($"Assistant with ID {id} and details not found.");
        }

        return assistant;
    }

    public async Task AddAssistantAsync(Assistant assistant)
    {
        _context.Assistants.Add(assistant);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAssistantAsync(Assistant assistant)
    {
        _context.Assistants.Update(assistant);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAssistantAsync(int id)
    {
        var assistant = await _context.Assistants.FindAsync(id);
        if (assistant != null)
        {
            _context.Assistants.Remove(assistant);
            await _context.SaveChangesAsync();
        }
    }
}
*/
