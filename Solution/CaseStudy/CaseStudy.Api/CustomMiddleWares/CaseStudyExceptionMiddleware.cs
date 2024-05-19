namespace CaseStudy.Api.CustomMiddleWares
{
    public class CaseStudyExceptionMiddleware
    {
        private readonly RequestDelegate next;

        public CaseStudyExceptionMiddleware(RequestDelegate Next)
        {
            next = Next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            if (httpContext.Request.Path.ToString() == "/api/Products/TestMiddleWare")
                await httpContext.Response.WriteAsync("TestMiddleWare Hello !");

            try
            {
                await next.Invoke(httpContext);
            }
            catch (Exception ex)
            {
                //Error Code
            }
            finally
            {
               //await httpContext.Response.WriteAsync("Statistic !");
            }
        }
    }
}