using Models;

namespace EmployeeWebAPI.Repository
{
    public interface IDepartmentRepository
    {
        IEnumerable<Department> GetDepartments();
        Department GetDepartmentsById(int departmentId);
    }
}
