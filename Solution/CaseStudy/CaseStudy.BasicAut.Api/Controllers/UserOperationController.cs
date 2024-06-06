using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CaseStudy.BasicAut.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserOperationController : ControllerBase
    {
        [HttpGet]
        public Task<IActionResult> Get()
        {
            return Task.FromResult<IActionResult>(Ok("UserOperationGet"));
        }
    }
}
