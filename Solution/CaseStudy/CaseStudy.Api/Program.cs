using CaseStudy.Api.CustomCqrsMediator;
using CaseStudy.Api.CustomDependencyInjection;
using CaseStudy.Api.CustomEntityFramework;
using CaseStudy.Api.CustomFolder;
using CaseStudy.Api.CustomJwt;
using CaseStudy.Api.CustomMiddleWares;
using CaseStudy.Api.Extensions;
using CaseStudy.Application.AppSettings;
using CaseStudy.Persistence;
using CaseStudy.Persistence.Contexts;
using Microsoft.AspNetCore.HttpLogging;
using Microsoft.AspNetCore.Mvc.ModelBinding.Metadata;
using Microsoft.EntityFrameworkCore;
using Serilog;
using Serilog.Context;
using Serilog.Core;
using Serilog.Sinks.MSSqlServer;
using System.Collections.ObjectModel;
using System.Data;
using System.Security.Claims;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
AppSettings.Loading(builder.Configuration);

builder.Services.AddCors(options => options.AddDefaultPolicy(policy =>
    policy.WithOrigins("https://localhost:7259").AllowAnyHeader().AllowAnyMethod().AllowCredentials().WithExposedHeaders("Content-Disposition")
));

builder.Services.AddControllers(options =>
{
    options.ModelMetadataDetailsProviders.Add(new SystemTextJsonValidationMetadataProvider());
});



var columnOptions = new ColumnOptions
{
    AdditionalColumns = new Collection<SqlColumn>
    {
        //new SqlColumn
        //    {ColumnName = "EnvironmentUserName", PropertyName = "EnvirUserName", DataType = SqlDbType.NVarChar, DataLength = 64},

        new SqlColumn
            {ColumnName = "UserName", PropertyName = "UserName", DataType = SqlDbType.NVarChar, DataLength = 60},

        //new SqlColumn
        //    {ColumnName = "UserId", DataType = SqlDbType.BigInt/*, NonClusteredIndex = true*/},

        //new SqlColumn
        //    {ColumnName = "RequestUri", DataType = SqlDbType.NVarChar, DataLength = -1/*, AllowNull = false*/},
    }
};

Logger log = new LoggerConfiguration()
    .WriteTo.Console()
    //.WriteTo.File("logs/log.txt")
    .WriteTo.MSSqlServer(builder.Configuration.GetValue<string>("ConnectionString"), new MSSqlServerSinkOptions
    {
        TableName = "CaseStudy.logs",
        AutoCreateSqlTable = true,
    }, columnOptions: columnOptions)
    .Enrich.FromLogContext()
    .MinimumLevel.Error()
    .CreateLogger();


builder.Host.UseSerilog(log);

builder.Services.AddHttpLogging(logging =>
{
    logging.LoggingFields = HttpLoggingFields.All;
    logging.RequestHeaders.Add("sec-ch-ua");
    logging.MediaTypeOptions.AddText("application/javascript");
    logging.RequestBodyLogLimit = 4096;
    logging.ResponseBodyLogLimit = 4096;
});

//builder.Services.AddScoped<ICaseStudyStorage, CaseStudyLocalStorage>();
builder.Services.AddScoped<ICaseStudyStorage, CaseStudyAzureStorage>();

builder.Services.AddDbContext<CustomEntityMyDbContext>(o => o.UseSqlServer(AppSettings.ConnectionString));

builder.Services.AddJwtServices();
builder.Services.AddScoped<ICaseCategoryRepository, CategoryRepository>();

builder.Services.AddPersistenceServices();
builder.Services.AddMediatRServices();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

WebApplication app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

if (app.Environment.IsProduction())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseSerilogRequestLogging();
app.UseHttpLogging();

app.ExceptionExtensionHandler<Program>(app.Services.GetRequiredService<ILogger<Program>>());

app.UseHttpsRedirection();
app.UseAuthentication();

app.UseAuthorization();



app.Use(async (context, next) =>
{
    if (context.User.Identity.IsAuthenticated)
        LogContext.PushProperty("UserName", context.User?.Claims.First(z => z.Type == "UserName").Value);
    else
        LogContext.PushProperty("UserName", "Guest");
    await next();
});


app.MapControllers();

app.UseCors();

using var scope = app.Services.CreateScope();
await using var dbContext = scope.ServiceProvider.GetRequiredService<CaseStudyDbContext>();
await dbContext.Database.MigrateAsync();

//app.UseMiddleware<CaseStudyExceptionMiddleware>();

app.Run();