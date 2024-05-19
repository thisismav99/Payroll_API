namespace Payroll_System_WebAPI.Models.Request
{
    public class EmployeeRequest : BaseRequest
    {
        public required string FirstName { get; set; }

        public string? MiddleName { get; set; }

        public required string LastName { get; set; }

        public int PositionID { get; set; }

        public int DivisionID { get; set; }
    }
}
