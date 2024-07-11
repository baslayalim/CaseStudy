using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using CaseStudy.Api.CustomJwt;
using System.Security.Claims;

namespace CaseStudy.Api.CustomRoleBasedAttributes
{
    public class RolePermissionFilter : IAsyncActionFilter
    {
        //ICustomActiveUser _customActiveUser;
        //public RolePermissionFilter(ICustomActiveUser customActiveUser) 
        //{
        //    _customActiveUser = customActiveUser;
        //}

        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            var name = context.HttpContext.User.Identity?.Name;
            if (!string.IsNullOrEmpty(name) && name != "CaseStudy") // is admin kontrolü eklenecek case study
            {
                var descriptor = context.ActionDescriptor as ControllerActionDescriptor;
                var attribute = descriptor.MethodInfo.GetCustomAttribute(typeof(AuthorizeRoleBasedAttribute)) as AuthorizeRoleBasedAttribute;

                var httpAttribute = descriptor.MethodInfo.GetCustomAttribute(typeof(HttpMethodAttribute)) as HttpMethodAttribute;

                var code = $"{(httpAttribute != null ? httpAttribute.HttpMethods.First() : HttpMethods.Get)}.{attribute.ActionType}.{attribute.Definition.Replace(" ", "")}";
                
                var rolex = context.HttpContext.User.Claims.Where(z => z.Type == ClaimTypes.Role).Select(z => z.Value).ToList();
                var hasRole = rolex.Where(x => x.Equals(code)).FirstOrDefault() != null ? true : false;

                if (!hasRole)
                    context.Result = new UnauthorizedResult();
                else
                    await next();
            }
            else
                await next();
        }
    }
}
