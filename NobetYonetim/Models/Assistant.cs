namespace NobetYonetim.Models
{
    public class Assistant
    {
        public int AssistantId { get; set; }
        public required string FullName { get; set; }
        public required string Email { get; set; }
        public decimal Salary { get; set; }
        public decimal Bonus { get; set; }
        public required string Password { get; set; }
        // Foreign Key, tek bir Admin ile ilişki
        public int AdminId { get; set; }

        // Admin'e ait ilişki
        public required Admin Admin { get; set; }

        // Navigation Properties
        // Bir asistanın birden fazla vardiya tutabilmesi için Shifts koleksiyonu
        public required ICollection<Shift> Shifts { get; set; }
        public ICollection<Patient> Patients { get; set; } = new List<Patient>();
        public ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
    }

}
