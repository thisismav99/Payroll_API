using Payroll_System_BLL.Interfaces;
using Payroll_System_DAL.Entities;
using Payroll_System_DAL.Repositories;
using Payroll_System_DAL.UnitOfWorks;

namespace Payroll_System_BLL.Services
{
    public class EmployeeService : IEmployeeService
    {
        #region Variables
        private readonly IPayrollRepository<Employee> _employeeRepository;
        private readonly IPayrollRepository<Salary> _salaryRepository;
        private readonly IPayrollRepository<Deduction> _deductionRepository;
        private readonly IPayrollUnitOfWork _unitOfWork;
        #endregion

        #region Constructor
        public EmployeeService(IPayrollRepository<Employee> employeeRepository,
                               IPayrollRepository<Salary> salaryRepository,
                               IPayrollRepository<Deduction> deductionRepository,
                               IPayrollUnitOfWork unitOfWork)
        {
            _employeeRepository = employeeRepository;
            _salaryRepository = salaryRepository;
            _deductionRepository = deductionRepository;
            _unitOfWork = unitOfWork;
        }
        #endregion

        #region Methods
        public async Task<int> AddEmployee(Employee employee, Salary salary, Deduction deduction)
        {
            var transaction = await _unitOfWork.BeginTransaction();

            try
            {
                if (employee is null)
                    return 0;
                else
                {
                    _employeeRepository.Add(employee);
                    await _unitOfWork.SaveChanges();

                    _salaryRepository.Add(salary);
                    await _unitOfWork.SaveChanges();

                    _deductionRepository.Add(deduction);
                    await _unitOfWork.SaveChanges();
                    
                    await transaction.CommitAsync();

                    return 1;
                }
            }
            catch(Exception ex)
            {
                await transaction.RollbackAsync();
                return 0;
            }
        }

        public async Task<int> DeleteEmployeeByID(int id)
        {
            var transaction = await _unitOfWork.BeginTransaction();

            try
            {
                var employee = await _employeeRepository.GetByID(id);

                if (employee is null)
                    return 0;
                else
                {
                    _employeeRepository.Delete(employee);
                    await _unitOfWork.SaveChanges();

                    await transaction.CommitAsync();

                    return 1;
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
            var transaction = await _unitOfWork.BeginTransaction();

            try 
            { 
                _employeeRepository.Update(employee);
                await _unitOfWork.SaveChanges();

                await transaction.CommitAsync();

                return 1;
            }
            catch
            {
                await transaction.RollbackAsync();
                return 0;
            }
        }

        public async Task<int> UpdateEmployeePartial(Employee employee)
        {
            var transaction = await _unitOfWork.BeginTransaction();

            try
            {
                _employeeRepository.Update(employee);
                await _unitOfWork.SaveChanges();

                await transaction.CommitAsync();

                return 1;
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
