using Novolis.Templates.Microservice.Models.Companies;

using RestSharp;

namespace Novolis.Templates.Microservice.Services;

public interface ICompanyService
{
    Task<RestResponse<Company>> GetCompanyAsync(long registrationNumber);
    Task<RestResponse<CompaniesList>> SearchForLegalEntityAsync(string? companyName = null, string? town = null, int currentPage = 0, int pageSize = 20);
}