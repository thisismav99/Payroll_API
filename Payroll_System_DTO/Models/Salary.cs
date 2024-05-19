namespace Payroll_System_DTO.Models
{
    public class Salary : Base
    {
        public decimal TotalSalary { get; set; }

        public decimal SemiMonthlySalary { get; set; }

        public decimal MonthlySalary { get; set; }

        public int EmployeeID { get; set; }

        public virtual required Employee Employee { get; set; }
    }
}
