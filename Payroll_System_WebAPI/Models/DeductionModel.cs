namespace Payroll_System_WebAPI.Models
{
    public class DeductionModel : BaseModel
    {
        public decimal? GovContribution { get; set; }

        public decimal? Loan { get; set; }
    }
}
