using Microsoft.AspNetCore.Mvc;
using Payroll_System_BLL.Interfaces;
using Payroll_System_WebAPI.Models.Request;
using Payroll_System_WebAPI.Models.ViewModels;
using Payroll_System_WebAPI.Utilities;

namespace Payroll_System_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : BaseController
    {
        #region Variables
        private readonly IEmployee _employeeService;
        #endregion

        #region Constructor
        public EmployeeController(IEmployee employeeService)
        {
            _employeeService = employeeService;
        }
        #endregion

        #region Methods
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
        public async Task<IActionResult> AddEmployee([FromBody] EmployeeViewModel request)
        {
            try
            {
                // Convert EmployeeRequest to Employee and Salary Entities
                var _employee = ViewModelConverter.EmployeeConverter(request.Employee);
                var _salary = ViewModelConverter.SalaryConverter(request.Salary);
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
        public async Task<IActionResult> UpdateEmployee([FromBody] EmployeeViewModel request)
        {
            try
            {
                // Convert EmployeeRequest to Employee Entities
                var _employee = ViewModelConverter.EmployeeConverter(request.Employee);
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
