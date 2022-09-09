using Microsoft.EntityFrameworkCore;

namespace Employee.DAL.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Entities.Models.Employee> Employees { get; set; }
    }
}
