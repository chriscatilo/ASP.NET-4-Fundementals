using System.Linq;

namespace eManager
{
    interface IDepartmentDataSource
    {
        IQueryable<Employee> Employees { get; }

        IQueryable<Department> Departments { get; }
    }
}