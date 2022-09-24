using Microsoft.Extensions.DependencyInjection;
using EmployeeApp.Application.Interfaces;
using EmployeeApp.Application.Services;
using EmployeeApp.Domain.Common;
using Employee.Domain.Entities;
using Employee.Domain.Interfaces.Repositories;
using Employee.Infrastructure.Common;
using Employee.Infrastructure.Repositories;

namespace Employee.Api.Extensions
{
    public static class ModuleCollectionExtension
    {
        public static IServiceCollection AddCoreModules(this IServiceCollection services)
        {
            // Services / Use Cases
            services.AddScoped<IemployeeService, EmployeeService>();

            return services;
        }

        public static IServiceCollection AddInfrastructureModules(this IServiceCollection services)
        {
            // Repositories
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();


            return services;
        }
    }
}