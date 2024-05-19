namespace Payroll_System_DTO.Models
{
    public class Deduction : Base
    {
        public decimal TotalDeduction { get; set; }

        public decimal? GovContribution { get; set; }

        public decimal? Loan { get; set; }

        public int SalaryID { get; set; }

        public virtual required Salary Salary { get; set; }
    }
}
