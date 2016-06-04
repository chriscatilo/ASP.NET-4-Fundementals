using System.Linq;

namespace eManager
{
    public interface IDepartmentDataSource
    {
        IQueryable<Employee> Employees { get; }

        IQueryable<Department> Departments { get; }
    }
}