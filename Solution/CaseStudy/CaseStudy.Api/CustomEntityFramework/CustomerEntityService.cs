using CaseStudy.Domain.Entities;
using CaseStudy.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
 
namespace CaseStudy.Api.CustomEntityFramework
{
    public class CustomerEntityService
    {
        private readonly DbContextOptions _options;
        public CustomerEntityService(DbContextOptions options)
        {
            _options = options;
        }
        public void AddCustomer(Customer customer)
        {
            using (var context = new CustomEntityMyDbContext(_options))
            {
                context.Customers.Add(customer);
                context.SaveChanges();
            }
        }
        public List<Customer> GetCustomers()
        {
            using (var context = new CustomEntityMyDbContext(_options))
            {
                return context.Customers.ToList();
            }
        }
        public void UpdateCustomer(Customer customer)
        {
            using (var context = new CustomEntityMyDbContext(_options))
            {
                context.Entry(customer).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void DeleteCustomer(Guid id)
        {
            using (var context = new CustomEntityMyDbContext(_options))
            {
                var customer = context.Customers.Find(id);
                context.Customers.Remove(customer);
                context.SaveChanges();
            }
        }
    }
}