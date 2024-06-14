using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace CaseStudy.Api.CustomFilter
{ 
    public class SupervisorFilter : Attribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            if (context.HttpContext.User.Identity.IsAuthenticated)
            {
                IEnumerable<Claim> Claims = context.HttpContext.User.Claims;

                string NameIdentifier = context.HttpContext.User.Claims.First(z => z.Type == ClaimTypes.NameIdentifier).Value;
                //if (NameIdentifier == "976f89e8-b69d-44f1-b299-76ec240450a7")

                if (NameIdentifier == "X976f89e8-b69d-44f1-b299-76ec240450a7")
                    return;
                else
                    context.Result = new BadRequestObjectResult(new { success = false, message = "Not Supervisor" });
            }
        }
    }
}
