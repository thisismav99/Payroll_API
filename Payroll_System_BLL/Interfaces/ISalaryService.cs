using Payroll_System_DAL.Entities;

namespace Payroll_System_BLL.Interfaces
{
    public interface ISalaryService
    {
        Task<int> AddSalary(Salary salary);
    }
}
