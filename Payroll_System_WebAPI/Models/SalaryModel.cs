namespace Payroll_System_WebAPI.Models
{
    public class SalaryModel : BaseModel
    {
        public decimal TotalSalary { get; set; }

        public decimal SemiMonthlySalary { get; set; }

        public decimal MonthlySalary { get; set; }
    }
}
