using System.ComponentModel.DataAnnotations.Schema;

namespace Payroll_System_DAL.Entities
{
    public class Salary : Base
    {
        public decimal TotalSalary { get; set; }

        public decimal SemiMonthlySalary { get; set; }

        public int EmployeeID { get; set; }

        [ForeignKey("EmployeeID")]
        public virtual Employee? Employee { get; set; }
    }
}
