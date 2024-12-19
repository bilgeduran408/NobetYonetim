/* using NobetYonetim.Models;
using System.ComponentModel.DataAnnotations;


namespace NobetYonetim.ViewModels
{
    public class DepartmentViewModel
    {
        public DepartmentViewModel()
        {
            Name = string.Empty;
            ProfessorName = string.Empty;
            AdminName = string.Empty;
        }

        public int DepartmentId { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [StringLength(100, ErrorMessage = "Name cannot exceed 100 characters.")]
        public string Name { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Available beds must be a non-negative number.")]
        public int AvailableBeds { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Occupied beds must be a non-negative number.")]
        public int OccupiedBeds { get; set; }

        // Professor ilişkisi
        [Required(ErrorMessage = "Professor is required.")]
        public int ProfessorId { get; set; }

        public string ProfessorName { get; set; }

        // Admin ilişkisi
        [Required(ErrorMessage = "Admin is required.")]
        public int AdminId { get; set; }

        public string AdminName { get; set; }

        // Shift ve Patient ID'leri
        public ICollection<int> ShiftIds { get; set; } = new List<int>();
        public ICollection<int> PatientIds { get; set; } = new List<int>();
    }
}
*/
