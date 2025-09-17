using System.ComponentModel.DataAnnotations;

namespace CMCS.Web.Models
{
    public class ClaimApproval
    {
        [Key]
        public int ApprovalId { get; set; }
        
        [Required]
        public int ClaimId { get; set; }
        
        [Required]
        public string ApproverId { get; set; } = string.Empty;
        
        [Required]
        [StringLength(50)]
        public string Action { get; set; } = string.Empty; // Approve, Reject, Request Info
        
        [StringLength(1000)]
        public string? Comments { get; set; }
        
        [Required]
        public DateTime ApprovalDate { get; set; }
        
        [Required]
        [StringLength(100)]
        public string ApprovalLevel { get; set; } = string.Empty; // Coordinator, Manager

        // Navigation Properties
        public virtual Claim Claim { get; set; } = null!;
        public virtual ApplicationUser Approver { get; set; } = null!;
    }
}