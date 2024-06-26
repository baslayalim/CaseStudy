﻿using CaseStudy.Api.CustomDependencyInjection;
using CaseStudy.Api.CustomEntityFramework;
using CaseStudy.Api.CustomFolder;
using CaseStudy.Api.CustomJwt;
using CaseStudy.Api.CustomMiddleWares;
using CaseStudy.Application.AppSettings;
using CaseStudy.Persistence;
using CaseStudy.Persistence.Contexts;
using Microsoft.AspNetCore.Mvc.ModelBinding.Metadata;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static System.Net.Mime.MediaTypeNames;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
AppSettings.Loading(builder.Configuration);

builder.Services.AddCors(options => options.AddDefaultPolicy(policy =>
    policy.WithOrigins("https://localhost:7259").AllowAnyHeader().AllowAnyMethod().AllowCredentials().WithExposedHeaders("Content-Disposition")
));

builder.Services.AddControllers(options =>
{
    options.ModelMetadataDetailsProviders.Add(new SystemTextJsonValidationMetadataProvider());
});

//builder.Services.AddScoped<ICaseStudyStorage, CaseStudyLocalStorage>();
builder.Services.AddScoped<ICaseStudyStorage, CaseStudyAzureStorage>();

builder.Services.AddDbContext<CustomEntityMyDbContext>(o => o.UseSqlServer(AppSettings.ConnectionString));

builder.Services.AddJwtServices();
builder.Services.AddScoped<ICaseCategoryRepository, CategoryRepository>();

builder.Services.AddPersistenceServices();

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

app.UseHttpsRedirection();
app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.UseCors();

using var scope = app.Services.CreateScope();
await using var dbContext = scope.ServiceProvider.GetRequiredService<CaseStudyDbContext>();
await dbContext.Database.MigrateAsync();

app.UseMiddleware<CaseStudyExceptionMiddleware>();

app.Run();