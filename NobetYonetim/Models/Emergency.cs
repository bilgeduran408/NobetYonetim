namespace NobetYonetim.Models
{
    public class Emergency
    {
        public int Id { get; set; }
        public required string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        // Foreign Key ile Admin'e bağlı
        public int AdminId { get; set; }
        public required Admin Admin { get; set; }

    }
}
