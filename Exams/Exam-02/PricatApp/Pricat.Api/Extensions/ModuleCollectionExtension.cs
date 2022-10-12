using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.SecurityTokenService;
using PricatApp.Application.Services;
using PricatApp.Application.Interfaces;
using PricatApp.Domain.Interfaces.Repositories;
using PricatApp.Infrastructure.Repositories;

namespace PricatApp.Api.Extensions
{
    public static class ModuleCollectionExtension
    {

     

        public static IServiceCollection AddCoreModules(this IServiceCollection services)
        {
            // Services / Use Cases
            services.AddScoped<IProductService, ProductService>();

            return services;
        }

        public static IServiceCollection AddInfrastructureModules(this IServiceCollection services)
        {
            // Repositories
            services.AddScoped<IProductRepository, ProductRepository>();


            return services;
        }
    }
}
