namespace NobetYonetim.Models
{
    public class Appointment
    {
        public int AppointmentId { get; set; }
        public DateTime AppointmentDate { get; set; }

        // Foreign Keys
        public int AssistantId { get; set; }
        public required Assistant Assistant { get; set; }
        // Foreign Key ile Admin'e bağlı
        public int AdminId { get; set; }
        public required Admin Admin { get; set; }
        public int ProfessorId { get; set; }
        public required Professor Professor { get; set; }
    }

}
