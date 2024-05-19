using System.ComponentModel.DataAnnotations;

namespace Payroll_System_DAL.Entities
{
    public class Division : Base
    {
        [Required(ErrorMessage = "This is a required field")]
        public required string DivisionName { get; set; }
    }
}
