using eManager.Web.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Data.Entity;
using System.Linq;

namespace eManager.Web.Infrastructure
{
    public class DepartmentDb : IdentityDbContext<ApplicationUser>, IDepartmentDataSource
    {
        public DepartmentDb()
            : base("eManager.Db", throwIfV1Schema: false)
        {
        }

        public static DepartmentDb Create()
        {
            return new DepartmentDb();
        }


        public DbSet<Employee> Employees { get; set; }

        public DbSet<Department> Departments { get; set; }

        IQueryable<Employee> IDepartmentDataSource.Employees
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        IQueryable<Department> IDepartmentDataSource.Departments
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}