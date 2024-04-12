using CaseStudy.Application.Repositories;
using CaseStudy.Domain.Entities;
using CaseStudy.Persistence.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CaseStudy.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        readonly private IProductReadRepository _productReadRepository;
        readonly private IProductWriteRepository _productWriteRepository;

        public ProductsController(IProductWriteRepository productWriteRepository , IProductReadRepository productReadRepository)
        {
            _productWriteRepository = productWriteRepository;
            _productReadRepository = productReadRepository;
        }

        [HttpGet]
        public async Task Get()
        {
            await _productWriteRepository.AddAsync(new Product { Name = "Test" });
            await _productWriteRepository.SaveAsync();
        }
        [HttpGet("GetAll")]
        public List<Product> GetAll()
        {
            List<Product> _getAll = _productReadRepository.GetAll().ToList();
            return _getAll;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            Product product = await _productReadRepository.GetByIdAsync(id);
            product.Name = "Test-42";
            await _productWriteRepository.SaveAsync();
            return Ok(product);
        }

    }
}
