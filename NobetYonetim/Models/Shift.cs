namespace NobetYonetim.Models
{
    public class Shift
    {
        public int ShiftId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        // Foreign Keys
        public int AssistantId { get; set; }
        public required Assistant Assistant { get; set; }

        public int DepartmentId { get; set; }
        public required Department Department { get; set; }

        // Birden fazla asistanın bir vardiyayı tutabilmesi için Assistants koleksiyonunu ekliyoruz
        public required ICollection<Assistant> Assistants { get; set; }

    }
}
