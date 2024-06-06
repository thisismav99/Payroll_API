using Microsoft.AspNetCore.Mvc;
using Payroll_System_BLL.Interfaces;
using Payroll_System_DAL.Entities;
using Payroll_System_WebAPI.Models.Request;

namespace Payroll_System_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        #region Variables
        private readonly IEmployee _employeeService;
        private readonly Employee _employee;
        private readonly Salary _salary;
        #endregion

        #region Constructor
        public EmployeeController(IEmployee employeeService, 
                                  Employee employee,
                                  Salary salary)
        {
            _employeeService = employeeService;
            _employee = employee;
            _salary = salary;

        }
        #endregion

        #region Method
        [HttpGet]
        [Route("GetEmployeeByID")]
        public async Task<IActionResult> GetEmployeeByID([FromQuery] IDRequest request)
        {
            try
            {
                var result = await _employeeService.GetEmployeeByID(request.ID);

                return StatusCode(StatusCodes.Status200OK, result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("GetAllEmployees")]
        public async Task<IActionResult> GetAllEmployees()
        {
            try
            {
                var result = await _employeeService.GetAllEmployees();

                return StatusCode(StatusCodes.Status200OK, result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [Route("AddEmployee")]
        public async Task<IActionResult> AddEmployee([FromBody] EmployeeRequest request)
        {
            try
            {
                // Convert EmployeeRequest to Employee and Salary Entities
                _employee.FirstName = request.FirstName;
                _employee.MiddleName = request.MiddleName;
                _employee.LastName = request.LastName;
                _employee.PositionID = request.PositionID;
                _employee.DivisionID = request.DivisionID;
                _employee.CreatedBy = request.CreatedBy;
                _employee.CreatedOn = request.CreatedOn;
                _employee.IsActive = request.IsActive;

                _salary.TotalSalary = request.SalaryRequest.TotalSalary;
                _salary.SemiMonthlySalary = request.SalaryRequest.SemiMonthlySalary;
                _salary.MonthlySalary = request.SalaryRequest.MonthlySalary;
                _salary.CreatedBy = request.CreatedBy;
                _salary.CreatedOn = request.CreatedOn;
                _salary.IsActive = request.IsActive;
                _salary.Employee = _employee;
                // end

                var result = await _employeeService.AddEmployee(_employee, _salary);

                return StatusCode(StatusCodes.Status200OK, result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [Route("UpdateEmployee")]
        public async Task<IActionResult> UpdateEmployee([FromBody] EmployeeRequest request)
        {
            try
            {
                // Convert EmployeeRequest to Employee Entities
                _employee.ID = (int)request.ID!;
                _employee.FirstName = request.FirstName;
                _employee.MiddleName = request.MiddleName;
                _employee.LastName = request.LastName;
                _employee.PositionID = request.PositionID;
                _employee.DivisionID = request.DivisionID;
                _employee.CreatedBy = request.CreatedBy;
                _employee.CreatedOn = request.CreatedOn;
                _employee.UpdatedBy = request.UpdatedBy;
                _employee.UpdatedOn = request.UpdatedOn;
                _employee.IsActive = request.IsActive;
                // end

                var result = await _employeeService.UpdateEmployee(_employee);

                return StatusCode(StatusCodes.Status200OK, result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [Route("DeleteEmployeeByID")]
        public async Task<IActionResult> DeleteEmployeeByID([FromBody] IDRequest request)
        {
            try
            {
                var result = await _employeeService.DeleteEmployeeByID(request.ID);

                return StatusCode(StatusCodes.Status200OK, result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
        #endregion
    }
}
