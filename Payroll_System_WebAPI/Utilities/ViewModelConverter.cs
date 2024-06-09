using Payroll_System_DAL.Entities;
using Payroll_System_WebAPI.Models;

namespace Payroll_System_WebAPI.Utilities
{
    public static class ViewModelConverter
    {
        #region Variables
        private static Employee _employee;
        private static Salary _salary;
        private static Deduction _deduction;
        #endregion

        #region Constructor
        static ViewModelConverter()
        {
            _employee = new Employee()
            {
                CreatedBy = string.Empty,
                FirstName = string.Empty,
                LastName = string.Empty
            };

            _salary = new Salary()
            {
                CreatedBy = string.Empty,
            };

            _deduction = new Deduction()
            {
                CreatedBy = string.Empty,
            };
        }
        #endregion

        #region Methods
        public static Employee EmployeeConverter(EmployeeModel employeeModel)
        {
            _employee.ID = 0;
            _employee.FirstName = employeeModel.FirstName;
            _employee.MiddleName = employeeModel.MiddleName;
            _employee.LastName = employeeModel.LastName;
            _employee.PositionID = employeeModel.PositionID;
            _employee.DivisionID = employeeModel.DivisionID;
            _employee.CreatedBy = employeeModel.CreatedBy;
            _employee.CreatedOn = employeeModel.CreatedOn;
            _employee.UpdatedBy = employeeModel.UpdatedBy;
            _employee.UpdatedOn = employeeModel.UpdatedOn;
            _employee.IsActive = employeeModel.IsActive;

            return _employee;
        }

        public static Salary SalaryConverter(SalaryModel salaryModel)
        {
            _salary.ID = 0;
            _salary.TotalSalary = salaryModel.TotalSalary;
            _salary.SemiMonthlySalary = salaryModel.SemiMonthlySalary;
            _salary.CreatedBy = salaryModel.CreatedBy;
            _salary.CreatedOn = salaryModel.CreatedOn;
            _salary.UpdatedBy = salaryModel.UpdatedBy;
            _salary.UpdatedOn = salaryModel.UpdatedOn;
            _salary.IsActive = salaryModel.IsActive;

            return _salary;
        }

        public static Deduction DeductionConverter(DeductionModel deductionModel)
        {
            _deduction.ID = 0;
            _deduction.TotalDeduction = (decimal)(deductionModel.GovContribution + deductionModel.Loan)!;
            _deduction.GovContribution = deductionModel.GovContribution;
            _deduction.Loan = deductionModel.Loan;
            _deduction.CreatedBy = deductionModel.CreatedBy;
            _deduction.CreatedOn = deductionModel.CreatedOn;
            _deduction.UpdatedBy = deductionModel.UpdatedBy;
            _deduction.UpdatedOn = deductionModel.UpdatedOn;
            _deduction.IsActive = deductionModel.IsActive;

            return _deduction;
        }
        #endregion
    }
}
