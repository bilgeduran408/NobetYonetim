/* using NobetYonetim.Models;

namespace NobetYonetim.Repositories
{
    public interface IProfessorRepository
    {
        Task<IEnumerable<Professor>> GetAllAsync(); // Tüm profesörleri getir
        Task<Professor?> GetByIdAsync(int id);      // ID'ye göre profesör getir
        Task AddAsync(Professor professor);        // Yeni bir profesör ekle
        Task UpdateAsync(Professor professor);     // Profesörü güncelle
        Task DeleteAsync(int id);                  // ID'ye göre profesör sil
    }
}
*/