using Microsoft.EntityFrameworkCore.Storage;

namespace Payroll_System_DAL.UnitOfWorks
{
    public class PayrollUnitOfWork : IPayrollUnitOfWork
    {
        #region Variables
        private readonly PayrollSystemDbContext _context;
        #endregion

        #region Constructor
        public PayrollUnitOfWork(PayrollSystemDbContext context)
        {
            _context = context;
        }
        #endregion

        public async Task<IDbContextTransaction> BeginTransaction()
        {
            return await _context.Database.BeginTransactionAsync();
        }

        public async Task<int> SaveChanges()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
