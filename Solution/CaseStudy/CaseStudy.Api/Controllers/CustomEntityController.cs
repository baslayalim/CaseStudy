using CaseStudy.Api.CustomEntityFramework;
using CaseStudy.Domain.Entities;
using CaseStudy.Persistence.Contexts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace CaseStudy.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomEntityController : ControllerBase
    {
        [HttpGet]
        public Task<IActionResult> Get()
        {
            //var options = new DbContextOptionsBuilder<CustomEntityMyDbContext>().UseSqlServer(Application.AppSettings.AppSettings.ConnectionString).Options;
            //var customerService = new CustomerEntityService(options);
            var customerService = new CustomerEntityService();


            // Müşteri ekleme
            var newCustomer = new Customer
            {    
                Name = "Beyza",
                SurName = "HANOĞLU",
                Phone = "541 242 43 44"
            };
            customerService.AddCustomer(newCustomer);


            // Müşteri güncelleme 
            var customerToUpdate = customerService.GetCustomers().FirstOrDefault();
            if (customerToUpdate != null)
            {
                customerToUpdate.SurName = "Feyza";
                customerService.UpdateCustomer(customerToUpdate);
            }


            // Müşteri listeleme
            var customers = customerService.GetCustomers();
            foreach (var customer in customers)
            {
                Console.WriteLine($"{customer.Id} - {customer.Name} {customer.SurName} ({customer.Phone})");
            }


            // Müşteri silme
            var customerToDelete = customerService.GetCustomers().FirstOrDefault();
            if (customerToDelete != null)
            {
                customerService.DeleteCustomer(customerToDelete.Id);
            }




            return Task.FromResult<IActionResult>(Ok("Success"));
        }
    }
}
