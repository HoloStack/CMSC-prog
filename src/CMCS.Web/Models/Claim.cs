using System.ComponentModel.DataAnnotations;

namespace CMCS.Web.Models
{
    public class Claim
    {
        [Key]
        public int ClaimId { get; set; }
        
        [Required]
        public string LecturerId { get; set; } = string.Empty;
        
        [Required]
        [Range(0.1, 1000, ErrorMessage = "Hours worked must be between 0.1 and 1000")]
        public decimal HoursWorked { get; set; }
        
        [Required]
        [Range(0.01, 10000, ErrorMessage = "Hourly rate must be between 0.01 and 10000")]
        public decimal HourlyRate { get; set; }
        
        [Required]
        public decimal TotalAmount { get; set; }
        
        public string? AdditionalNotes { get; set; }
        
        [Required]
        public string Status { get; set; } = "Pending";
        
        [Required]
        public DateTime SubmissionDate { get; set; }
        
        [Required]
        public DateTime MonthWorked { get; set; }

        // Navigation Properties
        public virtual ApplicationUser Lecturer { get; set; } = null!;
        public virtual ICollection<ClaimDocument> Documents { get; set; } = new List<ClaimDocument>();
        public virtual ICollection<ClaimApproval> Approvals { get; set; } = new List<ClaimApproval>();
    }
}