using System.ComponentModel.DataAnnotations;

namespace CMCS.Web.Models
{
    public class ClaimDocument
    {
        [Key]
        public int DocumentId { get; set; }
        
        [Required]
        public int ClaimId { get; set; }
        
        [Required]
        [StringLength(255)]
        public string FileName { get; set; } = string.Empty;
        
        [Required]
        [StringLength(500)]
        public string FilePath { get; set; } = string.Empty;
        
        [Required]
        public long FileSize { get; set; }
        
        [Required]
        [StringLength(100)]
        public string ContentType { get; set; } = string.Empty;
        
        [Required]
        public DateTime UploadDate { get; set; }

        // Navigation Properties
        public virtual Claim Claim { get; set; } = null!;
    }
}