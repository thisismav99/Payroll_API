using Microsoft.EntityFrameworkCore;
using Payroll_System_DAL.Entities;
using Payroll_System_DAL.Seeds;

namespace Payroll_System_DAL
{
    /**
     * <summary>
     *  Database context for PayrollSystemDB to be used by Entity Framework Core
     * </summary>
     * **/
    public class PayrollSystemDbContext : DbContext
    {
        #region DbSet
        public DbSet<Employee> Employees { get; set; }

        public DbSet<Salary> Salaries { get; set; }

        public DbSet<Deduction> Deductions { get; set; }

        public DbSet<Position> Positions { get; set; }

        public DbSet<Division> Divisions { get; set; }
        #endregion

        #region Constructor
        public PayrollSystemDbContext(DbContextOptions<PayrollSystemDbContext> options) 
            : base(options)
        {
            
        }
        #endregion

        #region Method
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            PositionSeed.SeedData(builder);
            DivisionSeed.SeedData(builder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }
        #endregion
    }
}
