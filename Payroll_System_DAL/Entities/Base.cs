using System.ComponentModel.DataAnnotations;

namespace Payroll_System_DAL.Entities
{
    public class Base
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "This is a required field")]
        public required string CreatedBy { get; set; }

        [Required(ErrorMessage = "This is a required field")]
        public DateTime CreatedOn { get; set; }

        public string? UpdatedBy { get; set; }

        public DateTime? UpdatedOn { get; set; }

        [Required(ErrorMessage = "This is a required field")]
        public bool IsActive { get; set; }
    }
}
