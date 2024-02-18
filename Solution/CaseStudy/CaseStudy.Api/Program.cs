using CaseStudy.Persistence;
using CaseStudy.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddPersistenceServices();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

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

app.UseAuthorization();

app.MapControllers();




using var scope = app.Services.CreateScope();
await using var dbContext = scope.ServiceProvider.GetRequiredService<CaseStudyDbContext>();
await dbContext.Database.MigrateAsync();


app.Run();
