namespace NobetYonetim.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public required string FullName { get; set; }
        public int Rating { get; set; }

        // Foreign Keys
        public int DepartmentId { get; set; }
        public required Department Department { get; set; }

        public int? AdminId { get; set; } // Nullable Foreign Key
        public required Admin Admin { get; set; }
        public int AssistantId { get; set; }
        public required Assistant Assistant { get; set; }
    }
}
