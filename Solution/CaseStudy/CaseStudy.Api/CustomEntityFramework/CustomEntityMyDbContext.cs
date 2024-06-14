using CaseStudy.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CaseStudy.Api.CustomEntityFramework
{
    public class CustomEntityMyDbContext : DbContext
    {
        public CustomEntityMyDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Customer> Customers { get; set; }
    }
}