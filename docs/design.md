# Design

`Novolis.Templates` ships `dotnet new` scaffolds for Novolis repositories. Each template is self-contained under `src/Novolis.Templates/content/`.

## Template catalog

| Short name | Type | Purpose |
| --- | --- | --- |
| `novolismicroservice` | Solution | Distributed service per [distributed-services-architectural-guideline](https://github.com/Novolis-Platform/novolis-governance/blob/main/docs/architectural-ideals/distributed-services-architectural-guideline.md) |
| `novolis-githubsln` | Solution | Library or tool repo with governance doc placeholders |
| `novolis-noxaml-avalonia-app` | Project | Desktop app (code-only Avalonia UI) |
| `novolis-noxaml-avalonia-sln` | Solution | Layered desktop app |
| `novolismonogame` | Solution | MonoGame sample (see [gaming-layer-policy](https://github.com/Novolis-Platform/novolis-governance/blob/main/docs/gaming-layer-policy.md)) |

Removed from the pack (not aligned with platform scope): Semantic Kernel playground, upstream Testcontainers module contributor scaffold.

## Microservice layout

```text
Novolis.<Service>/
  Novolis.<Service>/              # Core (Features/)
  Novolis.<Service>.Api/
  Novolis.<Service>.Models/
  Novolis.<Service>.Client/
  Novolis.<Service>.Data/
  Novolis.<Service>.Data.Migrations/
  Novolis.<Service>.Tests/        # TUnit only
```

Generated solutions include `nuget.config` with nuget.org + GitHub Packages mapping for `Novolis.*`.

## Validation

`Novolis.Templates.SmokeTests` packs the template nupkg, installs it, instantiates `novolismicroservice` and `novolis-noxaml-avalonia-sln`, then builds (and tests the microservice solution).
