using Microsoft.EntityFrameworkCore;
using NobetYonetim.Models;

namespace NobetYonetim.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        // DbSet Tanımları
        public DbSet<Assistant> Assistants { get; set; }
        public DbSet<Shift> Shifts { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Professor> Professors { get; set; }
        public DbSet<Emergency> Emergencies { get; set; }
        public DbSet<Calendar> Calendars { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Log> Logs { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Admin ile Assistant arasındaki ilişki
            modelBuilder.Entity<Assistant>()
                .HasOne(a => a.Admin)
                .WithMany(admin => admin.Assistants)
                .HasForeignKey(a => a.AdminId)
                .OnDelete(DeleteBehavior.Restrict); // Admin silindiğinde Assistant'ı silme, sadece kısıtlama

            // Admin ile Professor arasındaki ilişki
            modelBuilder.Entity<Professor>()
                .HasOne(p => p.Admin)
                .WithMany(a => a.Professors)
                .HasForeignKey(p => p.AdminId)
                .OnDelete(DeleteBehavior.Restrict);  // Admin silindiğinde Professor'ı silme, sadece kısıtlama

            // Admin ile Calendar arasındaki 1:1 ilişkiyi tanımlıyoruz
            modelBuilder.Entity<Admin>()
                .HasOne(a => a.Calendar)    // Her Admin'in sadece bir Calendar'ı olacak
                .WithOne(c => c.Admin)      // Her Calendar'ın sadece bir Admin'i olacak
                .HasForeignKey<Calendar>(c => c.AdminId)
                .OnDelete(DeleteBehavior.Restrict); // Admin silindiğinde Calendar'ı silme, sadece kısıtlama

            // Admin ile Patient arasındaki ilişki
            modelBuilder.Entity<Patient>()
                .HasOne(p => p.Admin)
                .WithMany(a => a.Patients)
                .HasForeignKey(p => p.AdminId)
                .OnDelete(DeleteBehavior.Restrict);  // Admin silindiğinde Patient'ı silme, sadece kısıtlama

            // Admin ile Appointment arasındaki ilişki
            modelBuilder.Entity<Appointment>()
                .HasOne(a => a.Admin)
                .WithMany(a => a.Appointments)
                .HasForeignKey(a => a.AdminId)
                .OnDelete(DeleteBehavior.Restrict);  // Admin silindiğinde Appointment'ı silme, sadece kısıtlama

            // Assistant ile Appointment arasındaki ilişki (Bir Assistant birden fazla randevu alabilir)
            modelBuilder.Entity<Appointment>()
                .HasOne(a => a.Assistant)
                .WithMany(a => a.Appointments)
                .HasForeignKey(a => a.AssistantId)
                .OnDelete(DeleteBehavior.Restrict); // Assistant silindiğinde Appointment silinmez

            // Appointment ile Professor arasındaki ilişki (Bir Appointment bir Professor'a ait olabilir)
            modelBuilder.Entity<Appointment>()
                .HasOne(a => a.Professor)
                .WithMany(p => p.Appointments)
                .HasForeignKey(a => a.ProfessorId)
                .OnDelete(DeleteBehavior.Restrict);  // Professor silindiğinde Appointment silinmez

            // Log - Admin Relationship (Admin her zaman bir log'a sahip olabilir)
            modelBuilder.Entity<Log>()
                .HasOne(l => l.Admin)
                .WithMany(a => a.Logs)
                .HasForeignKey(l => l.AdminId)
                .OnDelete(DeleteBehavior.Restrict);  // Admin silindiğinde log'u silme

            // Shift ve Department arasındaki ilişki (Bir Shift bir Department'a ait olabilir)
            modelBuilder.Entity<Shift>()
                .HasOne(s => s.Department)
                .WithMany(d => d.Shifts)
                .HasForeignKey(s => s.DepartmentId)
                .OnDelete(DeleteBehavior.Cascade);  // Department silindiğinde Shift'i de sil

            // Shift ve Assistant arasındaki ilişki
            modelBuilder.Entity<Shift>()
                .HasOne(s => s.Assistant)  // Shift bir Assistanta ait
                .WithMany(a => a.Shifts)   // Bir Assistant birden fazla Shift'e sahip olabilir
                .HasForeignKey(s => s.AssistantId)  // Foreign key'i belirtiyoruz
                .OnDelete(DeleteBehavior.Restrict);  // Assistant silindiğinde Shift silinmez

            // Department ve Professor arasındaki ilişki (Department her zaman bir Professor'a ait olabilir)
            modelBuilder.Entity<Department>()
                .HasOne(d => d.Professor)
                .WithMany(p => p.Departments)
                .HasForeignKey(d => d.ProfessorId)
                .OnDelete(DeleteBehavior.Restrict);  // Professor silindiğinde Department silinmez

            // Department ve Patient arasındaki ilişki (Bir Department birden fazla Patient'e sahip olabilir)
            modelBuilder.Entity<Patient>()
                .HasOne(p => p.Department)
                .WithMany(d => d.Patients)
                .HasForeignKey(p => p.DepartmentId)
                .OnDelete(DeleteBehavior.Cascade);  // Department silindiğinde Patient'ı sil

            // Calendar ve Professor arasındaki ilişki
            modelBuilder.Entity<Calendar>()
                .HasOne(c => c.Professor)
                .WithMany(p => p.Calendars)
                .HasForeignKey(c => c.ProfessorId)
                .OnDelete(DeleteBehavior.Restrict);  // Professor silindiğinde Calendar silinmez




        }
    }
}

