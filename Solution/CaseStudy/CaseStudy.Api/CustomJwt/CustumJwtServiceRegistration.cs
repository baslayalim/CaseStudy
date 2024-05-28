using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Security.Authentication;
using System.Text;

namespace CaseStudy.Api.CustomJwt
{ 

    public static class CustumJwtServiceRegistration
    {
        public static void AddJwtServices(this IServiceCollection Services)
        {
            Services.AddHttpContextAccessor();
            Services.AddHttpClient();
            Services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            })
                            .AddJwtBearer(options =>
                            {
                                options.TokenValidationParameters = new TokenValidationParameters
                                {
                                    ValidateIssuer = true,
                                    ValidateAudience = true,
                                    ValidateLifetime = true,
                                    ValidIssuer = CustomJwtHelper.Issuer,
                                    ValidAudience = CustomJwtHelper.Audience,
                                    ValidateIssuerSigningKey = true,
                                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(CustomJwtHelper.SecurityKey)),
                                    LifetimeValidator = (notBefore, expires, securityToken, validationParameters) => expires != null ? expires > DateTime.UtcNow : false
                                };
                            });
            Services.AddSingleton<ICustomJwtHelper, CustomJwtHelper>();
            Services.AddScoped<ICustomActiveUser, CustomActiveUser>((sp) =>
            {
                var context = sp.GetService<IHttpContextAccessor>();
                if (context is null || context.HttpContext is null || !context.HttpContext.User.Identity.IsAuthenticated)
                    throw new AuthenticationException("There is no authentication.");

                var userData = CustomJwtHelper.JwtDataLoad((System.Security.Claims.ClaimsIdentity)context.HttpContext.User.Identity);
                return new CustomActiveUser(userData);
            });

            Services.AddEndpointsApiExplorer();
            Services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "WebAPI", Version = "v1" });

                OpenApiSecurityScheme securityDefinition = new OpenApiSecurityScheme()
                {
                    Name = "Bearer",
                    BearerFormat = "JWT",
                    Scheme = "bearer",
                    Description = "Specify the authorization token.",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.Http,
                };
                c.AddSecurityDefinition("CaseStudyToken", securityDefinition);

                OpenApiSecurityScheme securityScheme = new OpenApiSecurityScheme()
                {
                    Reference = new OpenApiReference()
                    {
                        Id = "CaseStudyToken",
                        Type = ReferenceType.SecurityScheme
                    }
                };
                OpenApiSecurityRequirement securityRequirements = new OpenApiSecurityRequirement()
                {
                    {securityScheme, new string[] { }},
                };
                c.AddSecurityRequirement(securityRequirements);

                c.CustomSchemaIds(type => type.ToString());
            });

        }
    }
}
