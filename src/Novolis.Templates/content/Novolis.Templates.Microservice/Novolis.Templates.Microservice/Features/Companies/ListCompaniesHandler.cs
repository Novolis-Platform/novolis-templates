using Microsoft.EntityFrameworkCore;
using Novolis.Templates.Microservice.Data;
using Novolis.Templates.Microservice.Data.Entities;

namespace Novolis.Templates.Microservice.Features.Companies;

public sealed class ListCompaniesHandler(AppDbContext db)
{
    public Task<List<CompanyEntity>> ExecuteAsync(CancellationToken cancellationToken = default) =>
        db.Companies
            .AsNoTracking()
            .OrderBy(company => company.Name)
            .ToListAsync(cancellationToken);
}
