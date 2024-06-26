﻿namespace Payroll_System_DTO.Models
{
    public class Employee : Base
    {
        public required string FirstName { get; set; }

        public string? MiddleName { get; set; }

        public required string LastName { get; set; }

        public int PositionID { get; set; }

        public int DivisionID { get; set; }

        public virtual required Position Position  { get; set; }

        public virtual required Division Division { get; set; }
    }
}
