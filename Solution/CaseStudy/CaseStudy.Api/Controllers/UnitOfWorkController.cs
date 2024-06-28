using CaseStudy.Api.UnitOfWork;
using CaseStudy.Domain.Entities;
using CaseStudy.Persistence.Contexts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace CaseStudy.Api.Controllers
{ 

    [ApiController]
    [Route("api/[controller]")]
    public class UnitOfWorkController : Repository<Product>
    {
        public UnitOfWorkController(CaseStudyDbContext companyContext) : base(companyContext)
        { }

        [HttpGet("DatabaseProcess")]
        public bool DatabaseBusiness()
        {
            Add(new Parameter
            {
                Description = "1. Numaralı Siparis"
            });
            Add(new Parameter
            {
                Description = "2. Numaralı Siparis"
            });

            Add(new Product { Id=new Guid(), Name = "CivCiv Pijama Çocuk 4 Yaş" , Product_Description = "CivCiv Pijama Çocuk 4 Yaş CivCiv Pijama Çocuk 4 Yaş CivCiv Pijama Çocuk 4 Yaş CivCiv Pijama Çocuk 4 Yaş CivCiv Pijama Çocuk 4 Yaş", Stock= 5 });
            Add(new Product { Id = new Guid(), Name = "Tavşan Diş Fırçası", Product_Description = ".", Stock = 5 });
            Add(new Product { Id = new Guid(), Name = "Samsung Tv", Product_Description = ".", Stock = 5 });

            Add(new Product { Id = new Guid(), Name = "Mevlana Şekeri", Product_Description = ".", Stock = 5 });
            Add(new Product { Id = new Guid(), Name = "Samsung Yazıcı", Product_Description = ".", Stock = 5 });


            Add(new Customer { Id = new Guid(), Name = "Feyza", SurName = "HANOĞLU"  , Hobi = "Yüzmek , Koşmak , Uçmak , Zıplamak , Yürümek , Hareket Etmek" });

            Commit();

            return true;
        }
    }
}
