using System.Net;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using static CaseStudy.Api.Helper.ExceptionHelper;

namespace CaseStudy.Api.CustomMiddleWares
{
    public class CaseStudyExceptionMiddleware
    {
        private readonly RequestDelegate next;
        private readonly JsonSerializerOptions _jsonOption = new JsonSerializerOptions();
        private readonly IWebHostEnvironment _env;

        public CaseStudyExceptionMiddleware(RequestDelegate Next, IWebHostEnvironment env)
        {
            next = Next;
            _env = env;
        }

        public async Task Invoke(HttpContext httpContext)
        {

            if (httpContext.Request.Path.ToString() == "/api/Products/TestMiddleWare")
                httpContext.Response.OnStarting(() =>
                {
                    httpContext.Response.WriteAsync("TestMiddleWare Hello !");
                    return Task.CompletedTask;
                });

            try
            {
                await next.Invoke(httpContext);
            }
            catch (CaseStudyException exception)
            {
                httpContext.Response.ContentType = "application/json";
                httpContext.Response.StatusCode = (int)HttpStatusCode.BadRequest;

                if (_env.EnvironmentName == "Development")
                    await httpContext.Response.WriteAsync(JsonSerializer.Serialize(new APIErrorResult
                    {
                        ErrorType = "CaseStudyException",
                        ErrorTypeDescription = "CaseStudyException",
                        Message = GetMessage(exception),
                        StackTrace = GetStackTrace(exception),
                    }, _jsonOption));
                else
                    await httpContext.Response.WriteAsync(JsonSerializer.Serialize(new APIErrorResult
                    {
                        ErrorType = "Exception",
                        ErrorTypeDescription = "Exception",
                        Message = GetMessage(exception),
                    }, _jsonOption));
            }
            catch (AuthenticationException exception)
            {
                httpContext.Response.ContentType = "application/json";
                httpContext.Response.StatusCode = (int)HttpStatusCode.Unauthorized;

                if (_env.EnvironmentName == "Development")
                    await httpContext.Response.WriteAsync(JsonSerializer.Serialize(new APIErrorResult
                    {
                        ErrorType = "AuthenticationException",
                        ErrorTypeDescription = "AuthenticationException",
                        Message = GetMessage(exception),
                        StackTrace = GetStackTrace(exception),
                    }, _jsonOption));
                else
                    await httpContext.Response.WriteAsync(JsonSerializer.Serialize(new APIErrorResult
                    {
                        ErrorType = "Exception",
                        ErrorTypeDescription = "Exception",
                        Message = GetMessage(exception),
                    }, _jsonOption));
            }
            catch (Exception exception)
            {
                httpContext.Response.ContentType = "application/json";
                httpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

                if (_env.EnvironmentName == "Development")
                    await httpContext.Response.WriteAsync(JsonSerializer.Serialize(new APIErrorResult
                    {
                        ErrorType = "Exception",
                        ErrorTypeDescription = "Exception",
                        Message = GetMessage(exception),
                        StackTrace = GetStackTrace(exception),
                    }, _jsonOption));
                else
                    await httpContext.Response.WriteAsync(JsonSerializer.Serialize(new APIErrorResult
                    {
                        ErrorType = "Exception",
                        ErrorTypeDescription = "Exception",
                        Message = GetMessage(exception),
                    }, _jsonOption));

            }
        }

        public class APIErrorResult
        {
            public string? ErrorType { get; set; }
            public string? ErrorTypeDescription { get; set; }

            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public string? Message { get; set; }

            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public string? StackTrace { get; set; }

            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public Dictionary<string, IEnumerable<string>>? ValidationErrors { get; set; }

            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public object? Data { get; set; }
        }
        private string GetMessage(Exception exception)
        {
            var sb = new StringBuilder();
            sb.AppendLine(exception.Message);

            if (exception.InnerException is not null)
            {
                sb.AppendLine("--------------------------------------------------");
                sb.AppendLine(GetMessage(exception.InnerException));
            }

            return sb.ToString();
        }

        private string GetStackTrace(Exception exception)
        {
            var sb = new StringBuilder();
            sb.AppendLine(exception.StackTrace);

            if (exception.InnerException is not null)
            {
                sb.AppendLine("--------------------------------------------------");
                sb.AppendLine(GetMessage(exception.InnerException));
            }

            return sb.ToString();
        }
    }
}