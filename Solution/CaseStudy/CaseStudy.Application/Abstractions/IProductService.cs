using CaseStudy.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy.Application.Abstractions
{
    public interface IProductService
    {
        List<Product> GetProducts();
    }
}
