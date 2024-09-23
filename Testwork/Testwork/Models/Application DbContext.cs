using Microsoft.EntityFrameworkCore;

namespace Testwork.Models
{
    public class Application_DbContext:DbContext
    {
        public Application_DbContext(DbContextOptions<Application_DbContext>options):base (options) { }

        public DbSet<Employee> Employees { get; set; }
    }
   
}
