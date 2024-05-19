using Microsoft.EntityFrameworkCore;
using Payroll_System_DAL.Entities;

namespace Payroll_System_DAL.Seeds
{
    public static class PositionSeed
    {
        /**
         * <summary>
         *  Auto generated data to be inserted on Positions Table on PayrollSystemDB
         * </summary>
         * **/
        public static void SeedData(ModelBuilder builder)
        {
            builder.Entity<Position>().HasData(
                new Position
                {
                    ID = 1,
                    PositionName = "CEO",
                    CreatedBy = "SYSTEM",
                    CreatedOn = DateTime.Now,
                    IsActive = true
                },
                new Position
                {
                    ID = 2,
                    PositionName = "SALES MANAGER",
                    CreatedBy = "SYSTEM",
                    CreatedOn = DateTime.Now,
                    IsActive = true
                },
                new Position
                {
                    ID = 3,
                    PositionName = "SALES ASSISTANT",
                    CreatedBy = "SYSTEM",
                    CreatedOn = DateTime.Now,
                    IsActive = true
                },
                new Position
                {
                    ID = 4,
                    PositionName = "HR MANAGER",
                    CreatedBy = "SYSTEM",
                    CreatedOn = DateTime.Now,
                    IsActive = true
                },
                new Position
                {
                    ID = 5,
                    PositionName = "HR ASSISTANT",
                    CreatedBy = "SYSTEM",
                    CreatedOn = DateTime.Now,
                    IsActive = true
                },
                new Position
                {
                    ID = 6,
                    PositionName = "PROGRAMMER III",
                    CreatedBy = "SYSTEM",
                    CreatedOn = DateTime.Now,
                    IsActive = true
                },
                new Position
                {
                    ID = 7,
                    PositionName = "PROGRAMMER II",
                    CreatedBy = "SYSTEM",
                    CreatedOn = DateTime.Now,
                    IsActive = true
                },
                new Position
                {
                    ID = 8,
                    PositionName = "PROGRAMMER I",
                    CreatedBy = "SYSTEM",
                    CreatedOn = DateTime.Now,
                    IsActive = true
                },
                new Position
                {
                    ID = 9,
                    PositionName = "JANITOR",
                    CreatedBy = "SYSTEM",
                    CreatedOn = DateTime.Now,
                    IsActive = true
                }
            );
        }
    }
}
