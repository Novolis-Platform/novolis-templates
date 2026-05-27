using System.Net.Http.Json;
using Novolis.Templates.Microservice.Models;

namespace Novolis.Templates.Microservice.Client;

public sealed class MicroserviceClient(HttpClient httpClient) : IMicroserviceClient
{
    public Task<CompanyListDto> ListCompaniesAsync(CancellationToken cancellationToken = default) =>
        httpClient.GetFromJsonAsync<CompanyListDto>("api/companies", cancellationToken)!;
}
