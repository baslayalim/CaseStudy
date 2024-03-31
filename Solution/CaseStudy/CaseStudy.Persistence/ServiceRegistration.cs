using Microsoft.EntityFrameworkCore;
using CaseStudy.Persistence.Contexts;
using Microsoft.Extensions.DependencyInjection;
using CaseStudy.Application.Repositories;
using CaseStudy.Persistence.Repositories;

namespace CaseStudy.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<CaseStudyDbContext>(options => options.UseSqlServer(Application.AppSettings.AppSettings.ConnectionString));
            services.AddScoped<ICustomerReadRepository, CustomerReadRepository>();
            services.AddScoped<ICustomerWriteRepository, CustomerWriteRepository>();
            services.AddScoped<IOrderReadRepository, OrderReadRepository>();
            services.AddScoped<IOrderWriteRepository, OrderWriteRepository>();
            services.AddScoped<IProductReadRepository, ProductReadRepository>();
            services.AddScoped<IProductWriteRepository, ProductWriteRepository>();
 
            
            //  Update-Database
            //  add-migration mig-0
            //  remove-migration
            //  services.AddSingleton<IProductService, ProductService>();

        }
    }
}
