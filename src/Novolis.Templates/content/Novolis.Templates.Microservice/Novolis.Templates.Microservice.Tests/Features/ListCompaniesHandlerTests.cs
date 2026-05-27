using Microsoft.EntityFrameworkCore;
using Novolis.Templates.Microservice.Data;
using Novolis.Templates.Microservice.Data.Entities;
using Novolis.Templates.Microservice.Features.Companies;
using TUnit.Core;

namespace Novolis.Templates.Microservice.Tests.Features;

public sealed class ListCompaniesHandlerTests
{
    [Test]
    public async Task ExecuteAsync_returns_companies_ordered_by_name()
    {
        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase(Guid.NewGuid().ToString())
            .Options;

        await using var db = new AppDbContext(options);
        db.Companies.AddRange(
            new CompanyEntity { Id = Guid.NewGuid(), Name = "Zulu" },
            new CompanyEntity { Id = Guid.NewGuid(), Name = "Alpha" });
        await db.SaveChangesAsync();

        var handler = new ListCompaniesHandler(db);
        var result = await handler.ExecuteAsync();

        await Assert.That(result[0].Name).IsEqualTo("Alpha");
        await Assert.That(result[1].Name).IsEqualTo("Zulu");
    }
}
