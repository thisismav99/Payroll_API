using Payroll_System_BLL.Interfaces;
using Payroll_System_DAL.Entities;
using Payroll_System_DAL.Repositories;
using Payroll_System_DAL.UnitOfWorks;

namespace Payroll_System_BLL.Services
{
    public class EmployeeService : IEmployee
    {
        #region Variables
        private readonly IPayrollRepository<Employee> _employeeRepository;
        private readonly IPayrollUnitOfWork<Employee> _employeeUnitOfWork;
        #endregion

        #region Constructor
        public EmployeeService(IPayrollRepository<Employee> employeeRepository,
                               IPayrollUnitOfWork<Employee> employeeUnitOfWork)
        {
            _employeeRepository = employeeRepository;
            _employeeUnitOfWork = employeeUnitOfWork;
        }
        #endregion

        #region Method
        public async Task<int> AddEmployee(Employee employee)
        {
            var transaction = await _employeeUnitOfWork.BeginTransaction();

            try
            {
                if (employee is null)
                    return 0;
                else
                {
                    _employeeRepository.Add(employee);
                    var result = await _employeeUnitOfWork.SaveChanges();

                    await transaction.CommitAsync();

                    return result;
                }
            }
            catch
            {
                await transaction.RollbackAsync();
                return 0;
            }
        }

        public async Task<int> DeleteEmployeeByID(int id)
        {
            var transaction = await _employeeUnitOfWork.BeginTransaction();

            try
            {
                var employee = await _employeeRepository.GetByID(id);

                if (employee is null)
                    return 0;
                else
                {
                    _employeeRepository.Delete(employee);
                    var result = await _employeeUnitOfWork.SaveChanges();

                    await transaction.CommitAsync();

                    return result;
                }

            }
            catch
            {
                await transaction.RollbackAsync();
                return 0;
            }
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
            var transaction = await _employeeUnitOfWork.BeginTransaction();

            try 
            { 
                _employeeRepository.Update(employee);
                var result = await _employeeUnitOfWork.SaveChanges();

                await transaction.CommitAsync();

                return result;
            }
            catch
            {
                await transaction.RollbackAsync();
                return 0;
            }
        }
        #endregion
    }
}
