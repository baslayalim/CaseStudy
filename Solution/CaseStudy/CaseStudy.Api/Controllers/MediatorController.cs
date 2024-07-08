using CaseStudy.Api.CustomCqrsMediator.Features.Commands.Product.CreateProduct;
using CaseStudy.Api.CustomCqrsMediator.Features.Queries.Product.GetAllProduct;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CaseStudy.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MediatorController : ControllerBase
    {
        readonly IMediator _mediator; 
        readonly IHttpContextAccessor _httpContextAccessor;

        public MediatorController(IMediator mediator , IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetCreate([FromQuery] CreateProductCommandRequest createProductCommandRequest)
        {
            CreateProductCommandResponse response = await _mediator.Send(createProductCommandRequest);
            return Ok(response);
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll([FromQuery] GetAllProductQueryRequest getAllProductQueryRequest)
        {
            GetAllProductQueryResponse response = await _mediator.Send(getAllProductQueryRequest);
            return Ok(response);
        }


        [HttpGet("ContextControl")]
        public string GetContextControl()
        {
            var username = _httpContextAccessor?.HttpContext?.User?.Identity?.Name;
            return username;
        }

    }
}
