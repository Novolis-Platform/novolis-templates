namespace Novolis.Templates.Microservice.Models;

/// <summary>Transport contract for listing companies.</summary>
public sealed class CompanyListDto
{
    public required IReadOnlyList<CompanyDto> Items { get; init; }
}
