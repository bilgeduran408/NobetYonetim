/* using System.ComponentModel.DataAnnotations;


namespace NobetYonetim.ViewModels
{
    public class AssistantViewModel
    {
            public AssistantViewModel()
            {
                FullName = string.Empty;  // Varsayılan değerler
                Email = string.Empty;
                Password = string.Empty;
                AdminFullName = string.Empty;
                ShiftIds = new List<int>();
                PatientIds = new List<int>();
                AppointmentIds = new List<int>();
            }

            // Assistant için temel bilgiler
            public int AssistantId { get; set; }

            [Required(ErrorMessage = "Full name is required.")]
            [StringLength(100, ErrorMessage = "Full name cannot exceed 100 characters.")]
            public string FullName { get; set; }

            [Required(ErrorMessage = "Email is required.")]
            [EmailAddress(ErrorMessage = "Invalid email address.")]
            public string Email { get; set; }

            [Required(ErrorMessage = "Password is required.")]
            [MinLength(6, ErrorMessage = "Password must be at least 6 characters.")]
            public string Password { get; set; }

            public decimal Salary { get; set; }
            public decimal Bonus { get; set; }

            // İlişkili olduğu admin ile sadece adminin ismi taşınacak
            public string AdminFullName { get; set; }

            // İlişkili olduğu diğer tablolar için sadece id'ler
            public ICollection<int> ShiftIds { get; set; } = new List<int>(); // Shift Ids
            public ICollection<int> PatientIds { get; set; } = new List<int>(); // Patient Ids
            public ICollection<int> AppointmentIds { get; set; } = new List<int>(); // Appointment Ids

            // Takvim bilgisi varsa
            public int? CalendarId { get; set; }
        }
    }
*/



