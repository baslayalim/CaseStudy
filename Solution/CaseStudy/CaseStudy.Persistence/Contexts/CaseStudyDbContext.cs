using CaseStudy.Domain.Entities;
using CaseStudy.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore; 

namespace CaseStudy.Persistence.Contexts
{
    public class CaseStudyDbContext : DbContext
    {
        public CaseStudyDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Parameter> Parameters { get; set; }
        public DbSet<ServiceIntegration> ServiceIntegrations { get; set; }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var datas = ChangeTracker.Entries<BaseEntity>();

            foreach (var data in datas)
            {
                _ = data.State switch
                {
                    EntityState.Added => data.Entity.CreatedDate = DateTime.UtcNow,
                    EntityState.Modified => data.Entity.UpdatedDate = DateTime.UtcNow,
                    _ => DateTime.UtcNow
                };
            }

            return await base.SaveChangesAsync(cancellationToken);
        }

        // Add-Migration mig-0 -context CaseStudyDbContext

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(new Customer { Id = new Guid("3d3dbd9c-da30-4914-a799-afba1d0bdc3b"), Name = "Pamir", SurName = "Giresun" });

            modelBuilder.Entity<Product>().HasData(new Product { Id = new Guid("0abdbf8b-7b6e-483f-ab1f-945fac61e05b"),  Name = "Bebek Pijaması" , Product_Description= "3 - 6 Ay Kullanım" , Price = 480 , Stock = 5  });
            modelBuilder.Entity<Product>().HasData(new Product { Id = new Guid("98e78074-8ecc-4828-91aa-5b9b8a941c11"), Name = "Emzik", Product_Description = "1 Yaş Kullanım", Price = 220, Stock = 15 });
            modelBuilder.Entity<Product>().HasData(new Product { Id = new Guid("c1d0ccc0-4393-4a4b-8350-d8ba373f60af"), Name = "Bebek Bezi", Product_Description = "3 Numara Bebek Bezi", Price = 360, Stock = 500 });
            modelBuilder.Entity<Product>().HasData(new Product { Id = new Guid("d0d0eab3-1864-4a23-9460-53f843b980f1"), Name = "Bebek Maması Milupa", Product_Description = "Yeni Doğan Maması", Price = 50, Stock = 50 });
            base.OnModelCreating(modelBuilder);

        }
    }
}
