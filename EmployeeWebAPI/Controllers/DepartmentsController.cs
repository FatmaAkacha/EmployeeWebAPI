using EmployeeWebAPI.Repository;
using Microsoft.AspNetCore.Mvc;
using Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EmployeeWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        private readonly IDepartmentRepository departmentRepository;
        public DepartmentsController(IDepartmentRepository departmentRepository)
        {
            this.departmentRepository = departmentRepository;
        }
        [HttpGet]

        public async Task<ActionResult> GetDepartments()

        {
            try
            {

                return Ok(await departmentRepository.GetDepartments());

            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,

                "Error retrieving data from the database");

            }
        }
        [HttpGet("{id:int}")]

        public async Task<ActionResult<Department>> GetDepartment(int id)

        {
            try
            {

                var result = await departmentRepository.GetDepartment(id);

                if (result == null)
                {
                    return NotFound();
                }
                return result;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,

                "Error retrieving data from the database");

            }
        }
    }
}
