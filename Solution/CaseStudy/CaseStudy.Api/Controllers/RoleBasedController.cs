using CaseStudy.Api.CustomRoleBasedAttributes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CaseStudy.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleBasedController : ControllerBase
    {
        [HttpGet]
        public List<Menu> Get()
        {
            return RoleBasedHelper.GetRoleBasedHelpernEndpoints(typeof(Program));
        }


        [HttpGet("GetList")]
        [AuthorizeRoleBased(Menu = AuthorizeDefinition.RoleBased, ActionType = ActionType.Reading, Definition = "Role Based Activities", AppType = AppType.Finance)]
        public Task<string> GetList()
        {
            return Task.FromResult("Get List True");
        }
    }
}
