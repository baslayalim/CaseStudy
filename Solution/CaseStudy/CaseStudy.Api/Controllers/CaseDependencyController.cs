using CaseStudy.Api.CustomDependencyInjection;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace CaseStudy.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CaseDependencyController : ControllerBase
    {
        readonly ICaseCategoryRepository _categoryRepository;

        public CaseDependencyController(ICaseCategoryRepository caseCategoryRepository)
        {
            _categoryRepository = caseCategoryRepository;
        }

        [HttpGet]
        public string Get([Required] string CategoryName)
        {
            return _categoryRepository.AddCategory($"{CategoryName} => ");
        }
        
    }
}
