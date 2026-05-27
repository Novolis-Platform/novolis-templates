using Novolis.Templates.Microservice.Models;

namespace Novolis.Templates.Microservice.Client;

public interface IMicroserviceClient
{
    Task<CompanyListDto> ListCompaniesAsync(CancellationToken cancellationToken = default);
}
