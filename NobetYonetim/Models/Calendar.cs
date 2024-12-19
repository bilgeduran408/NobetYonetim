namespace NobetYonetim.Models
{
    public class Calendar
    {
        public int Id { get; set; } // Primary Key
        public DateTime AvailableStartTime { get; set; } // Takvim başlangıç zamanı
        public DateTime AvailableEndTime { get; set; } // Takvim bitiş zamanı

        // Admin ile bire bir ilişki
        public int AdminId { get; set; } // Foreign Key
        public required Admin Admin { get; set; } // Navigation Property

        // Professor ile bire bir ilişki
        public int ProfessorId { get; set; } // Foreign Key
        public required Professor Professor { get; set; } // Navigation Property
    }
}


