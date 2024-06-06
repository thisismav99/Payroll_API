namespace Payroll_System_WebAPI.Models.Request
{
    public class SalaryRequest : BaseRequest
    {
        public decimal TotalSalary { get; set; }

        public decimal SemiMonthlySalary { get; set; }

        public decimal MonthlySalary { get; set; }

        public int EmployeeID { get; set; }
    }
}
