namespace NobetYonetim.Models
{
    public class Professor
    {
        public int ProfessorId { get; set; }
        public required string FullName { get; set; }
        public required string Email { get; set; }
        public required string Department { get; set; }
        public required string Specialization { get; set; }

        // Foreign Key ile Admin'e bağlı
        public int AdminId { get; set; }
        public required Admin Admin { get; set; }
        // Navigation Properties
        public ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
        public ICollection<Department> Departments { get; set; } = new List<Department>();
        public ICollection<Calendar> Calendars { get; set; } = new List<Calendar>(); // Eklendi

    }
}
