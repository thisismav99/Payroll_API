using System.ComponentModel.DataAnnotations;

namespace Payroll_System_DAL.Entities
{
    public class Base
    {
        [Key]
        public int ID { get; set; }

        public required string CreatedBy { get; set; }

        public DateTime CreatedOn { get; set; }

        public string? UpdatedBy { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public bool IsActive { get; set; }
    }
}
