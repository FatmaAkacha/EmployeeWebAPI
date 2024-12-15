using Microsoft.AspNetCore.Mvc;
using Models;

namespace EmployeeWebAPI.Repository
{
    public interface IDepartmentRepository
    {
        Task<ActionResult<Department>> GetDepartment(int id);
        Task<IEnumerable<Department>> GetDepartments();
        Task<Department> GetDepartmentsById(int departmentId);
    }
}
