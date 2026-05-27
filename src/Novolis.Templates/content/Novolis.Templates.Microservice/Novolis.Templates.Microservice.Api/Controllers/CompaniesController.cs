using Microsoft.AspNetCore.Mvc;
using Novolis.Templates.Microservice.Features.Companies;
using Novolis.Templates.Microservice.Models;

namespace Novolis.Templates.Microservice.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public sealed class CompaniesController(ListCompaniesHandler listCompanies) : ControllerBase
{
    [HttpGet]
    [ProducesResponseType(typeof(CompanyListDto), StatusCodes.Status200OK)]
    public async Task<ActionResult<CompanyListDto>> ListAsync(CancellationToken cancellationToken)
    {
        var companies = await listCompanies.ExecuteAsync(cancellationToken);

        return Ok(new CompanyListDto
        {
            Items = companies
                .Select(company => new CompanyDto(company.Id, company.Name))
                .ToList(),
        });
    }
}
