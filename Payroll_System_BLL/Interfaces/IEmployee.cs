using Payroll_System_DAL.Entities;

namespace Payroll_System_BLL.Interfaces
{
    public interface IEmployee
    {
        Task<Employee?> GetEmployeeByID(int id);
        Task<List<Employee>> GetAllEmployees();
        Task<int> AddEmployee(Employee employee);
        Task<int> UpdateEmployee(Employee employee);
        Task<int> DeleteEmployeeByID(int id);
    }
}
