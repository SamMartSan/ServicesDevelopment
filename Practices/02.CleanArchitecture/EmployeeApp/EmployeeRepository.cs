using Employee.Domain.Entities;
using Employee.Domain.Interfaces.Repositories;
using Employee.Infrastructure.Common;
using Employee.Infrastructure.Context;

namespace Employee.Infrastructure.Repositories
{
    public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}