# Distributed service solution

Scaffold aligned with the [Distributed Services Architectural Guideline](https://github.com/Novolis-Platform/novolis-governance/blob/main/docs/architectural-ideals/distributed-services-architectural-guideline.md).

## Projects

| Project | Role |
| --- | --- |
| `Novolis.<Service>` | Core — feature slices (`Features/`) |
| `Novolis.<Service>.Api` | HTTP host and composition root |
| `Novolis.<Service>.Models` | Public transport contracts |
| `Novolis.<Service>.Client` | Typed consumer SDK |
| `Novolis.<Service>.Data` | EF Core persistence (owned store) |
| `Novolis.<Service>.Data.Migrations` | EF migrations |
| `Novolis.<Service>.Tests` | TUnit tests |

## Next steps

1. Rename `Novolis.Templates.Microservice` to your service name (`dotnet new` does this via `-n`).
2. Add `docs/getting-started.md`, `docs/design.md`, and `docs/release.md` per [repository policy](https://github.com/Novolis-Platform/novolis-governance/blob/main/docs/repository-policy.md).
3. Replace the sample `Companies` feature and SQLite demo with your domain and production database provider.
