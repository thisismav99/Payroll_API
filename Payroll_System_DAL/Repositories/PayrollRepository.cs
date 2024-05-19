using Microsoft.EntityFrameworkCore;

namespace Payroll_System_DAL.Repositories
{
    /**
     * <summary>
     *  A generic repository for PayrollSystemDB that implements IRepository including the constraint
     * </summary>
     * **/
    public class PayrollRepository<T> : IRepository<T> where T : class
    {
        #region Variables
        private readonly PayrollSystemDbContext _context;
        #endregion

        #region Constructor
        public PayrollRepository(PayrollSystemDbContext context)
        {
            _context = context;
        }
        #endregion

        #region Method
        public async Task<int> Add(T entity)
        {
            await _context.Set<T>().AddAsync(entity);

            return await _context.SaveChangesAsync();
        }

        public async Task<int> Delete(T entity)
        {
            _context.Set<T>().Remove(entity);

            return await _context.SaveChangesAsync();
        }

        public async Task<T?> GetByID(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<List<T>> GetAll()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<int> Update(T entity)
        {
            _context.Set<T>().Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;

            return await _context.SaveChangesAsync();
        }
        #endregion
    }
}
