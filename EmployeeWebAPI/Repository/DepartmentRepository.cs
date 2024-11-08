﻿using Models;

namespace EmployeeWebAPI.Repository
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly AppDbContext appDbContext;

        public DepartmentRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public Department GetDepartment(int departmentId)
        {
            return appDbContext.Departments.FirstOrDefault(d => d.DepartmentId == departmentId);
        }

        public IEnumerable<Department> GetDepartments()
        {
            return appDbContext.Departments;
        }

        public Department GetDepartmentsById(int departmentId)
        {
            throw new NotImplementedException();
        }
    }
}
