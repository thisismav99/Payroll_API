using Payroll_System_DAL.Entities;
using Payroll_System_WebAPI.Models;

namespace Payroll_System_WebAPI.Utilities
{
    public static class ViewModelConverter
    {
        #region Variables
        private static Employee _employee;
        private static Salary _salary;
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
        }
        #endregion

        #region Method
        public static Employee EmployeeConverter(EmployeeModel employeeModel)
        {
            _employee.FirstName = employeeModel.FirstName;
            _employee.MiddleName = employeeModel.MiddleName;
            _employee.LastName = employeeModel.LastName;
            _employee.PositionID = employeeModel.PositionID;
            _employee.DivisionID = employeeModel.DivisionID;
            _employee.CreatedBy = employeeModel.CreatedBy;
            _employee.CreatedOn = employeeModel.CreatedOn;
            _employee.IsActive = employeeModel.IsActive;

            return _employee;
        }

        public static Salary SalaryConverter(SalaryModel salaryModel)
        {
            _salary.TotalSalary = salaryModel.TotalSalary;
            _salary.SemiMonthlySalary = salaryModel.SemiMonthlySalary;
            _salary.MonthlySalary = salaryModel.MonthlySalary;
            _salary.CreatedBy = salaryModel.CreatedBy;
            _salary.CreatedOn = salaryModel.CreatedOn;
            _salary.IsActive = salaryModel.IsActive;

            return _salary;
        }
        #endregion
    }
}
