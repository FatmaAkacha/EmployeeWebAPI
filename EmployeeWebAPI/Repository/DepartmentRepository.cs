using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models;

namespace EmployeeWebAPI.Repository
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly AppDbContext appDbContext;

        public DepartmentRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public Task<ActionResult<Department>> GetDepartment(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Department> GetDepartmentAsync(int departmentId)
        {
            return await appDbContext.Departments.FirstOrDefaultAsync(d => d.DepartmentId == departmentId);
        }
        public async Task<IEnumerable<Department>>GetDepartments()
        {
            return await appDbContext.Departments.ToListAsync();
        }

        public Department GetDepartmentsById(int departmentId)
        {
            throw new NotImplementedException();
        }

        Task<Department> IDepartmentRepository.GetDepartmentsById(int departmentId)
        {
            throw new NotImplementedException();
        }
    }
}
