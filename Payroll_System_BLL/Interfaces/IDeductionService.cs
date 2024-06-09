using Payroll_System_DAL.Entities;

namespace Payroll_System_BLL.Interfaces
{
    public interface IDeductionService
    {
        Task<int> AddDeduction(Deduction deduction);
    }
}
