namespace Payroll_System_DTO.Models
{
    public class Base
    {
        public int ID { get; set; }

        public required string CreatedBy { get; set; }

        public DateTime CreatedOn { get; set; }

        public string? UpdatedBy { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public bool IsActive { get; set; }
    }
}
