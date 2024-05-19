using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Payroll_System_DAL.Entities
{
    public class Employee : Base
    {
        [Required(ErrorMessage = "This is a required field")]
        public required string FirstName { get; set; }

        public string? MiddleName { get; set; }

        [Required(ErrorMessage = "This is a required field")]
        public required string LastName { get; set; }

        [Required(ErrorMessage = "This is a required field")]
        public int PositionID { get; set; }

        [Required(ErrorMessage = "This is a required field")]
        public int DivisionID { get; set; }

        [ForeignKey("PositionID")]
        public virtual required Position Position  { get; set; }

        [ForeignKey("DivisionID")]
        public virtual required Division Division { get; set; }
    }
}
