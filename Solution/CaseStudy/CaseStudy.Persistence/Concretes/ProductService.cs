using CaseStudy.Application.Abstractions;
using CaseStudy.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy.Persistence.Concretes
{
    public class ProductService : IProductService
    {
        public List<Product> GetProducts()
            => new()
            {
                new()
                {
                     Id = Guid.NewGuid(),
                     Name = "Name1",
                     CreatedDate = DateTime.Now,
                     Price = 11,
                     Stock = 22,
                },
                new()
                {
                     Id = Guid.NewGuid(),
                     Name = "Name2",
                     CreatedDate = DateTime.Now.AddDays(1),
                     Price = 33,
                     Stock = 44,
                },
                new()
                {
                     Id = Guid.NewGuid(),
                     Name = "Name3",
                     CreatedDate = DateTime.Now.AddDays(2),
                     Price = 55,
                     Stock = 66,
                },
            };
    }
}
