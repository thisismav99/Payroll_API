using Microsoft.EntityFrameworkCore;
using Payroll_System_DAL.Entities;

namespace Payroll_System_DAL.Seeds
{
    public static class DivisionSeed
    {
        /**
         * <summary>
         *  Auto generated data to be inserted on Divisions Table on PayrollSystemDB
         * </summary>
         * **/
        public static void SeedData(ModelBuilder builder)
        {
            builder.Entity<Division>().HasData(
                new Division
                {
                    ID = 1,
                    DivisionName = "HIGHEST",
                    CreatedBy = "SYSTEM",
                    CreatedOn = DateTime.Now,
                    IsActive = true
                },
                new Division
                {
                    ID = 2,
                    DivisionName = "MID",
                    CreatedBy = "SYSTEM",
                    CreatedOn = DateTime.Now,
                    IsActive = true
                },
                new Division
                {
                    ID = 3,
                    DivisionName = "LOWEST",
                    CreatedBy = "SYSTEM",
                    CreatedOn = DateTime.Now,
                    IsActive = true
                }
            );
        }
    }
}
