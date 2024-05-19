using Payroll_System_BLL.Interfaces;
using Payroll_System_DAL.Entities;
using Payroll_System_DAL.Repositories;

namespace Payroll_System_BLL.Services
{
    public class EmployeeService : IEmployee
    {
        #region Variables
        private readonly IRepository<Employee> _employeeRepository;
        #endregion

        #region Constructor
        public EmployeeService(IRepository<Employee> employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        #endregion

        #region Method
        public async Task<int> CreateEmployee(Employee employee)
        {
            if (employee is null)
                return 0;
            else
                return await _employeeRepository.Add(employee);
        }

        public async Task<int> DeleteEmployeeByID(int id)
        {
            var employee = await _employeeRepository.GetByID(id);

            if (employee is null)
                return 0;
            else
                return await _employeeRepository.Delete(employee);
        }

        public async Task<List<Employee>> GetAllEmployees()
        {
            return await _employeeRepository.GetAll();
        }

        public async Task<Employee?> GetEmployeeByID(int id)
        {
            var employee = await _employeeRepository.GetByID(id);

            if (employee is null)
                return null;
            else
                return employee;
        }

        public async Task<int> UpdateEmployee(Employee employee)
        {
            var updateEmployee = await _employeeRepository.Update(employee);

            if(updateEmployee == 0)
                return 0;
            else
                return updateEmployee;
        }
        #endregion
    }
}
