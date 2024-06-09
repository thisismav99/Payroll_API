namespace Payroll_System_WebAPI.Models.ViewModels
{
    public class EmployeeViewModel
    {
        public required EmployeeModel Employee { get; set; }

        public required SalaryModel Salary { get; set; }

        public required DeductionModel Deduction { get; set; }
    }
}
