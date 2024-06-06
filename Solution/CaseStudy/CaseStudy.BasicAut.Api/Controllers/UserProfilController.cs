using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CaseStudy.BasicAut.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserProfilController : ControllerBase
    {
        [HttpGet]
        public Task<IActionResult> GetProfil()
        {
            return Task.FromResult<IActionResult>(Ok("UserProfil"));
        }

        [HttpGet("Detail")]
        public Task<IActionResult> GetDetail()
        {
            return Task.FromResult<IActionResult>(Ok("UserProfilDetail"));
        }
    }
}
