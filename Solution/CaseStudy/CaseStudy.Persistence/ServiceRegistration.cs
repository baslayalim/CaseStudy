using Microsoft.EntityFrameworkCore;
using CaseStudy.Persistence.Contexts;
using Microsoft.Extensions.DependencyInjection;

namespace CaseStudy.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<CaseStudyDbContext>(options => options.UseSqlServer("Server=GNB028;Database=CaseStudyDb_7;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true;"));

            //  Update-Database
            //  add-migration mig-0
            //  remove-migration
            //  services.AddSingleton<IProductService, ProductService>();

        }
    }
}
