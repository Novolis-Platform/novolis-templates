# Distributed service solution

Scaffold aligned with the [Distributed Services Architectural Guideline](https://github.com/Novolis-Platform/novolis-governance/blob/main/docs/architectural-ideals/distributed-services-architectural-guideline.md).

Created with:

```bash
dotnet new novolismicroservice -n Invoicing
```

Project names become `Novolis.Invoicing`, `Novolis.Invoicing.Api`, etc.

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

## Run

```bash
dotnet run --project Novolis.<Service>.Api
```

Development Swagger UI is enabled. The sample **Companies** feature seeds SQLite (`microservice.db`) on first run.

## Test

```bash
dotnet test
```

## Next steps

1. Replace the sample `Companies` feature and SQLite demo with your domain and production database provider.
2. Add `docs/getting-started.md`, `docs/design.md`, and `docs/release.md` per [repository policy](https://github.com/Novolis-Platform/novolis-governance/blob/main/docs/repository-policy.md).
3. Keep `.Models` free of other `Novolis.*` references; `.Core` references `.Data` only — not `.Models`.

Packages restore from **nuget.org** and **GitHub Packages** only.
