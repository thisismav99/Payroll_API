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
        #endregion

        #region Constructor
        public EmployeeController(IEmployee employeeService, 
                                  Employee employee)
        {
            _employeeService = employeeService;
            _employee = employee;
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
        [Route("CreateEmployee")]
        public async Task<IActionResult> CreateEmployee([FromBody] EmployeeRequest request)
        {
            try
            {
                // Convert EmployeeRequest to Employee Entities
                _employee.FirstName = request.FirstName;
                _employee.MiddleName = request.MiddleName;
                _employee.LastName = request.LastName;
                _employee.PositionID = request.PositionID;
                _employee.DivisionID = request.DivisionID;
                _employee.CreatedBy = request.CreatedBy;
                _employee.CreatedOn = request.CreatedOn;
                _employee.IsActive = request.IsActive;
                // end

                var result = await _employeeService.CreateEmployee(_employee);

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
