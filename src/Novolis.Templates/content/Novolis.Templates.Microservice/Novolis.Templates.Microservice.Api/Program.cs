using Microsoft.EntityFrameworkCore;
using Novolis.Templates.Microservice.Data;
using Novolis.Templates.Microservice.Data.Entities;
using Novolis.Templates.Microservice.Features.Companies;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = builder.Configuration.GetConnectionString("Default")
    ?? "Data Source=microservice.db";

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite(connectionString));

builder.Services.AddScoped<ListCompaniesHandler>();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    await db.Database.EnsureCreatedAsync();

    if (!await db.Companies.AnyAsync())
    {
        db.Companies.AddRange(
            new CompanyEntity { Id = Guid.Parse("11111111-1111-1111-1111-111111111101"), Name = "Novolis Example AS" },
            new CompanyEntity { Id = Guid.Parse("11111111-1111-1111-1111-111111111102"), Name = "Sample Partner AB" });
        await db.SaveChangesAsync();
    }
}

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();
await app.RunAsync();
