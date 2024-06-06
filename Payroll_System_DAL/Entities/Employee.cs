using System.ComponentModel.DataAnnotations.Schema;

namespace Payroll_System_DAL.Entities
{
    public class Employee : Base
    {
        public required string FirstName { get; set; }

        public string? MiddleName { get; set; }

        public required string LastName { get; set; }

        public int PositionID { get; set; }

        public int DivisionID { get; set; }

        [ForeignKey("PositionID")]
        public virtual Position? Position  { get; set; }

        [ForeignKey("DivisionID")]
        public virtual Division? Division { get; set; }
    }
}
