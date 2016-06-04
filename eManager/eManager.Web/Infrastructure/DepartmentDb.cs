using eManager.Domain;
using eManager.Web.Models;
using Microsoft.AspNet.Identity.EntityFramework;
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

        void IDepartmentDataSource.Save()
        {
            SaveChanges();
        }

        IQueryable<Employee> IDepartmentDataSource.Employees => Employees;

        IQueryable<Department> IDepartmentDataSource.Departments => Departments;
    }
}