using CaseStudy.Api.CustomJwt;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CaseStudy.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class FullJwtTestController : ControllerBase
    {
        readonly private ICustomActiveUser _customActiveUser;

        public FullJwtTestController(ICustomActiveUser customActiveUser)
        {
            _customActiveUser = customActiveUser;
        }

        [HttpGet("Control")]
        public Task<string> Control()
        {
            return Task.FromResult("Name : " + _customActiveUser.Name + Environment.NewLine + "User Name : " + _customActiveUser.UserName + Environment.NewLine +
               "Description : " + _customActiveUser.Description + Environment.NewLine + "Email : " + _customActiveUser.Email);
        }

        [Authorize(Roles = "Personnel")]
        [HttpGet("Personnel")]
        public Task<string> Personnel()
        {
            return Task.FromResult("Personnel");
        }

        [Authorize(Roles = "AdminPlus")]
        [HttpGet("AdminPlus")]
        public Task<string> AdminPlus()
        {
            return Task.FromResult("AdminPlus");
        }
    }
}
