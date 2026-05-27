namespace Novolis.Templates.Microservice.Data.Entities;

public sealed class CompanyEntity
{
    public Guid Id { get; set; }

    public required string Name { get; set; }
}
