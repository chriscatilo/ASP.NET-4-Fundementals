namespace eManager.Web.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<eManager.Web.Infrastructure.DepartmentDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(eManager.Web.Infrastructure.DepartmentDb context)
        {
            context.Departments.AddOrUpdate(d => d.Name,
                new Department {Name = "Engineering"},
                new Department {Name = "Sales"},
                new Department {Name = "Shipping"},
                new Department {Name = "Human Resources"}
                );
        }
    }
}
