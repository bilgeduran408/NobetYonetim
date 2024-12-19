namespace NobetYonetim.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public required string Name { get; set; }
        public int AvailableBeds { get; set; }
        public int OccupiedBeds { get; set; }

        // Foreign Keys
        public int ProfessorId { get; set; }
        public required Professor Professor { get; set; }
        // Foreign Key ile Admin'e bağlı
        public int AdminId { get; set; }
        public required Admin Admin { get; set; }

        // Navigation Properties
        public ICollection<Shift> Shifts { get; set; } = new List<Shift>();
        public ICollection<Patient> Patients { get; set; } = new List<Patient>();
        public int Id { get; internal set; }
        public string? BolumAdi { get; internal set; }
    }
}
