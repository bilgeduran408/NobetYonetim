using System.ComponentModel.DataAnnotations;

namespace NobetYonetim.Models
{
    public class Admin
    {
        public int AdminId { get; set; } // Primary Key

        [Required]
        [MaxLength(100)]
        public required string FullName { get; set; } // Admin'in Tam Adı

        [Required]
        [EmailAddress]
        public required string Email { get; set; } // Admin'in E-posta Adresi

        [Required]
        [MinLength(6)]
        public required string Password { get; set; } // Admin'in Şifresi

        // Log'larla ilişki (Navigation Property)
        public ICollection<Log> Logs { get; set; } = new List<Log>();

        // Asistanlarla ilişki (Navigation Property)
        public required ICollection<Assistant> Assistants { get; set; } = new List<Assistant>();

        // İlişkili olduğu tüm modeller
        public required ICollection<Patient> Patients { get; set; } = new List<Patient>();
        public required ICollection<Calendar> Calendars { get; set; } = new List<Calendar>();
        public required ICollection<Professor> Professors { get; set; } = new List<Professor>();
        public required ICollection<Emergency> Emergencies { get; set; } = new List<Emergency>();
        public required ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
        public required ICollection<Department> Departments { get; set; } = new List<Department>();
        public required ICollection<Shift> Shifts { get; set; } = new List<Shift>();

        // Calendar (Takvim) ile bire bir ilişki
        public Calendar? Calendar { get; set; } // Her Admin'in sadece bir takvimi olacak
    }
}

