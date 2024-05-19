using System.ComponentModel.DataAnnotations;

namespace Payroll_System_DAL.Entities
{
    public class Position : Base
    {
        [Required(ErrorMessage = "This is a required field")]
        public required string PositionName { get; set; }
    }
}
