using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Payroll_System_DAL.Entities
{
    public class Salary : Base
    {
        [Required(ErrorMessage = "This is a required field")]
        public decimal TotalSalary { get; set; }

        [Required(ErrorMessage = "This is a required field")]
        public decimal SemiMonthlySalary { get; set; }

        [Required(ErrorMessage = "This is a required field")]
        public decimal MonthlySalary { get; set; }

        [Required(ErrorMessage = "This is a required field")]
        public int EmployeeID { get; set; }

        [ForeignKey("EmployeeID")]
        public virtual required Employee Employee { get; set; }
    }
}
