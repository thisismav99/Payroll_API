using Microsoft.AspNetCore.Mvc;
using Payroll_System_BLL.Interfaces;
using Payroll_System_WebAPI.Models;
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
        private readonly IEmployeeService _employeeService;
        #endregion

        #region Constructor
        public EmployeeController(IEmployeeService employeeService)
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
                // Convert EmployeeViewModel to Employee, Salary and Deduction Entities
                var employee = ViewModelConverter.EmployeeConverter(request.Employee);
                var salary = ViewModelConverter.SalaryConverter(request.Salary);
                salary.Employee = employee;
                var deduction = ViewModelConverter.DeductionConverter(request.Deduction);
                deduction.Salary = salary;
                // end

                var result = await _employeeService.AddEmployee(employee, salary, deduction);

                return StatusCode(StatusCodes.Status200OK, result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPut]
        [Route("UpdateEmployee")]
        public async Task<IActionResult> UpdateEmployee([FromBody] EmployeeModel request)
        {
            try
            {
                // Convert EmployeeViewModel to Employee Entities
                var employee = ViewModelConverter.EmployeeConverter(request);
                // end

                var result = await _employeeService.UpdateEmployee(employee);

                return StatusCode(StatusCodes.Status200OK, result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPatch]
        [Route("UpdateEmployeePartial")]
        public async Task<IActionResult> UpdateEmployeePartial([FromBody] EmployeeModel request)
        {
            try
            {
                // Convert EmployeeViewModel to Employee Entities
                var employee = ViewModelConverter.EmployeeConverter(request);
                // end

                var result = await _employeeService.UpdateEmployeePartial(employee);

                return StatusCode(StatusCodes.Status200OK, result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpDelete]
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
