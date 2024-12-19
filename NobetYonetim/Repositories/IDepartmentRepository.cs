/* using NobetYonetim.Models;

namespace NobetYonetim.Repositories
{
    public interface IDepartmentRepository
    {
        Task<IEnumerable<Department>> GetAllDepartmentsAsync();
        Task<Department?> GetDepartmentByIdAsync(int id);
        Task AddDepartmentAsync(Department department);
        Task UpdateDepartmentAsync(Department department);
        Task DeleteDepartmentAsync(int id);

        // Ek özel metotlar
        Task<IEnumerable<Department>> GetDepartmentsByAdminIdAsync(int adminId);
        Task<int> GetAvailableBedsCountAsync(int departmentId);
    }
}
*/
