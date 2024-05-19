using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Payroll_System_DAL.Entities
{
    public class Deduction : Base
    {
        [Required(ErrorMessage = "This is a required field")]
        public decimal TotalDeduction { get; set; }

        public decimal? GovContribution { get; set; }

        public decimal? Loan { get; set; }

        [Required(ErrorMessage = "This is a required field")]
        public int SalaryID { get; set; }

        [ForeignKey("SalaryID")]
        public virtual required Salary Salary { get; set; }
    }
}
