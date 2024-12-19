/* using Microsoft.EntityFrameworkCore;
using NobetYonetim.Data;
using NobetYonetim.Models;

namespace NobetYonetim.Repositories
{
   public class AdminRepository : IAdminRepository
   {
       private readonly AppDbContext _context;

       // Constructor'da DbContext'i alıyoruz
       public AdminRepository(AppDbContext context)
       {
           _context = context;
       }

       public async Task<List<Admin>> GetAllAdminsAsync()
       {
           return await _context.Admins.ToListAsync();
       }

       public async Task<Admin> GetAdminByIdAsync(int id)
       {
           Admin? admin = await _context.Admins.FindAsync(id);

           if (admin == null)
           {
               // Burada null olma durumu için uygun bir işlem yapılabilir.
               // Örneğin bir istisna fırlatılabilir:
               throw new Exception($"Admin with ID {id} not found.");
           }

           return admin;
       }


       public async Task AddAdminAsync(Admin admin)
       {
           await _context.Admins.AddAsync(admin);
           await _context.SaveChangesAsync();
       }

       public async Task UpdateAdminAsync(Admin admin)
       {
           _context.Admins.Update(admin);
           await _context.SaveChangesAsync();
       }

       public async Task DeleteAdminAsync(int id)
       {
           var admin = await _context.Admins.FindAsync(id);
           if (admin != null)
           {
               _context.Admins.Remove(admin);
               await _context.SaveChangesAsync();
           }
       }
   }
} 
*/
