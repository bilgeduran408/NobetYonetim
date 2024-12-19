/* using System.ComponentModel.DataAnnotations;

namespace NobetYonetim.ViewModels
{
    public class ProfessorViewModel
    {
        public int ProfessorId { get; set; } // Unique ID

        [Required(ErrorMessage = "Full name is required.")]
        [StringLength(100, ErrorMessage = "Full name cannot exceed 100 characters.")]
        public string FullName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email format.")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Department is required.")]
        public string Department { get; set; } = string.Empty;

        [Required(ErrorMessage = "Specialization is required.")]
        public string Specialization { get; set; } = string.Empty;

        [Required(ErrorMessage = "Admin is required.")]
        public int AdminId { get; set; } // Foreign Key for Admin
        public string? AdminName { get; set; } // To display the admin's name in views

        // Navigation Properties for Related Entities
        public ICollection<int>? AppointmentIds { get; set; } = new List<int>(); // Related Appointment IDs
        public ICollection<int>? DepartmentIds { get; set; } = new List<int>(); // Related Department IDs
        public ICollection<int>? CalendarIds { get; set; } = new List<int>(); // Related Calendar IDs
    }
}
*/
