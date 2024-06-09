using Microsoft.EntityFrameworkCore.Storage;

namespace Payroll_System_DAL.UnitOfWorks
{
    public interface IPayrollUnitOfWork
    {
        Task<int> SaveChanges();
        Task<IDbContextTransaction> BeginTransaction();
    }
}
