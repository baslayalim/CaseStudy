using System.Net.Http.Headers;
using System.Text;

namespace CaseStudy.BasicAut.Api.Model
{
    public class BasicAuthMiddleware
    {
        private readonly RequestDelegate _next;

        public BasicAuthMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context, IUserService userService)
        {
            try
            {
                string authorization = context.Request.Headers["Authorization"];

                if (authorization != null)
                {
                    var authHeader = AuthenticationHeaderValue.Parse(authorization);
                    var credentialBytes = Convert.FromBase64String(authHeader.Parameter);
                    var credentials = Encoding.UTF8.GetString(credentialBytes).Split(':', 2);
                    var username = credentials[0];
                    var password = credentials[1];

                    context.Items["User"] = userService.Login(username, password);
                }
                else
                {
                    context.Response.StatusCode = 401;
                }
            }
            catch
            {
                context.Response.StatusCode = 500;
            }

            await _next(context);
        }

    }
}
