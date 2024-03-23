using CaseStudy.Application.Abstractions;
using CaseStudy.Application.AppSettings;
using Microsoft.AspNetCore.Mvc;

namespace CaseStudy.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        //private readonly IProductService _productService;

        //public ProductsController(IProductService productService)
        //{
        //    _productService = productService;
        //}

        [HttpGet]
        public IActionResult GetProduts()
        {
            //var products = _productService.GetProducts();
            return Ok(AppSettings.GeneralParameters?.ProjecDescription);
        }


        [HttpGet("ayar")]
        public IActionResult Ayar()
        {
            //var products = _productService.GetProducts();
            return Ok(AppSettings.EmailSetting);
        }


    }
}
