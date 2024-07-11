using CaseStudy.Api.CustomJwt;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CaseStudy.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomJwtController : ControllerBase
    { 
        [HttpGet]
        public Task<CustomJwtAccessToken> Get()
        {
            CustomJwtHelper customJwtHelper = new CustomJwtHelper();

            Guid userGuid = Guid.Parse("976f89e8-b69d-44f1-b299-76ec240450a7");

            CustomJwtAccessToken CustomJwtAccessToken = customJwtHelper.CreateToken(new CustomJwtData
            {
                Id = userGuid,
                Description = "Test",
                Email = "case@study.com",
                Name = "Case Study",
                UserName = "UserCaseStudy",
                RefreshToken = customJwtHelper.CreateRefreshToken(),
                Roles = { "GET.Reading.RoleBasedActivities", "Personnel" },
                RefreshTokenEndDate = DateTime.UtcNow.AddMinutes(customJwtHelper.RefreshTokenExpiration),
            });

            return Task.FromResult(CustomJwtAccessToken);
        }


        [Authorize]
        [HttpGet("GetList")]
        public Task<string> GetList()
        {
            return Task.FromResult("Get List True");
        }

        [Authorize(Roles = "AdminPlus")]
        [HttpGet("GetAdminManager")]
        public Task<string> GetAdminManager()
        {
            return Task.FromResult("Admin Success True");
        }

        [Authorize(Roles = "Personnel")]
        [HttpGet("GetPersonnel")]
        public Task<string> GetPersonnel()
        {
            return Task.FromResult("Personnel Success True");
        }

        [AllowAnonymous]
        [HttpGet("GetFree")]
        public Task<string> GetFree()
        {
            return Task.FromResult("Free Success True");
        }

    }
}
