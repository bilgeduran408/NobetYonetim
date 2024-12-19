/* using NobetYonetim.Models;
using System.ComponentModel.DataAnnotations;

namespace NobetYonetim.ViewModels
{
    public class AdminViewModel
    {
        public AdminViewModel()
        {
            FullName = string.Empty; // Varsayılan bir değer atandı
            Email = string.Empty;
            Password = string.Empty;
            DepartmentName = string.Empty;
            Assistant = new List<int>();
            Patient = new List<int>();
            AppointmentIds = new List<int>();
            ShiftIds = new List<int>();
        }

        public int AdminId { get; set; }

        [Required(ErrorMessage = "Full name is required.")]
        [StringLength(100, ErrorMessage = "Full name cannot exceed 100 characters.")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [MinLength(6, ErrorMessage = "Password must be at least 6 characters.")]
        public string Password { get; set; }

        // Foreign Key for Department
        [Required(ErrorMessage = "Department is required.")]
        public int DepartmentId { get; set; } // Foreign Key for Department
        public string DepartmentName { get; set; } // To show the name of the department
        public List<int> Assistant { get; }
        public List<int> Patient { get; }

        // İlişkili olduğu diğer tablolar için sadece id'leri veya kısa bilgileri ekleyebilirsiniz
        public ICollection<int> AssistantIds { get; set; } = new List<int>(); // Only Assistant Ids
        public ICollection<int> PatientIds { get; set; } = new List<int>(); // Only Patient Ids
        public ICollection<int> AppointmentIds { get; set; } = new List<int>(); // Only Appointment Ids
        public ICollection<int> ShiftIds { get; set; } = new List<int>(); // Only Shift Ids

        // Calendar ile ilişki - Takvim bilgisini de ekleyebilirsiniz
        public int? CalendarId { get; set; } // Admin'in takvimi varsa
     

    }
}
*/
