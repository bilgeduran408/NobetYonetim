using System.ComponentModel.DataAnnotations.Schema;

namespace NobetYonetim.Models
{
    public class Log
    {
        public int LogId { get; set; }  // Log ID
        public int AdminId { get; set; }  // Admin ile ilişki
        public DateTime OperationDate { get; set; }  // İşlem tarihi
        public required string OperationName { get; set; }  // İşlem adı

        [ForeignKey("AdminId")]
        public required Admin Admin { get; set; }  // Admin ilişkisi

    }
}
