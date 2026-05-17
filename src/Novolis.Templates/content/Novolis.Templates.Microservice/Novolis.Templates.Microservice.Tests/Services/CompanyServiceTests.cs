using FluentAssertions;
using Novolis.Templates.Microservice.Services;

namespace Novolis.Templates.Microservice.Tests.Services;

public class CompanyServiceTests
{
    [Test]
    [Skip("Integration test — requires external Brønnøysund API.")]
    public async Task GetCompanyAsyncTest()
    {
        TestContext.Current?.OutputWriter.WriteLine("Starting test");

        var service = new CompanyService();
        var result = await service.GetCompanyAsync(996967158);

        TestContext.Current?.OutputWriter.WriteLine(result.Content);
        result.Should().NotBeNull();
    }

    [Test]
    [Skip("Integration test — requires external Brønnøysund API.")]
    public async Task SearchForLegalEntityAsyncTest()
    {
        TestContext.Current?.OutputWriter.WriteLine("Starting test");

        var service = new CompanyService();
        var result = await service.SearchForLegalEntityAsync("NRK");

        TestContext.Current?.OutputWriter.WriteLine(result.Content);
        result.Should().NotBeNull();
    }
}
