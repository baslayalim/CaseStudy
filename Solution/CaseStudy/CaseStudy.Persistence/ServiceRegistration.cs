using Microsoft.EntityFrameworkCore;
using CaseStudy.Persistence.Contexts;
using Microsoft.Extensions.DependencyInjection;

namespace CaseStudy.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<CaseStudyDbContext>(options => options.UseSqlServer(Application.AppSettings.AppSettings.ConnectionString));

            //  Update-Database
            //  add-migration mig-0
            //  remove-migration
            //  services.AddSingleton<IProductService, ProductService>();

        }
    }
}
