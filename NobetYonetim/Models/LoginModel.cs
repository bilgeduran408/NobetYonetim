namespace NobetYonetim.Models
{
    public class LoginModel
    {
        public required string Email { get; set; }

        public required string Password { get; set; }
        // Foreign Key ile Admin'e bağlı
        public int AdminId { get; set; }
        public required Admin Admin { get; set; }

    }
}
