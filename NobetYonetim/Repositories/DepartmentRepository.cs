/*using Microsoft.EntityFrameworkCore;
using NobetYonetim.Data;
using NobetYonetim.Models;


namespace NobetYonetim.Repositories
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly AppDbContext _context;

        public DepartmentRepository(AppDbContext context)
        {
            _context = context;
        }


        public async Task<IEnumerable<Department>> GetAllDepartmentsAsync()
        {
            return await _context.Departments
                .Include(d => d.Professor)
                .Include(d => d.Admin)
                .ToListAsync();
        }

        public async Task<Department?> GetDepartmentByIdAsync(int id)
        {
            return await _context.Departments
                .Include(d => d.Professor)
                .Include(d => d.Admin)
                .FirstOrDefaultAsync(d => d.DepartmentId == id);
        }

        public async Task AddDepartmentAsync(Department department)
        {
            await _context.Departments.AddAsync(department);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateDepartmentAsync(Department department)
        {
            _context.Departments.Update(department);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteDepartmentAsync(int id)
        {
            var department = await GetDepartmentByIdAsync(id);
            if (department != null)
            {
                _context.Departments.Remove(department);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Department>> GetDepartmentsByAdminIdAsync(int adminId)
        {
            return await _context.Departments
                .Where(d => d.AdminId == adminId)
                .ToListAsync();
        }

        public async Task<int> GetAvailableBedsCountAsync(int departmentId)
        {
            var department = await GetDepartmentByIdAsync(departmentId);
            return department?.AvailableBeds ?? 0;
        }
    }
}
*/
