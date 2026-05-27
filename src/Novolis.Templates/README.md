# Novolis.Templates

`dotnet new` template packs for Novolis solutions and projects.

## Install

```bash
dotnet new install Novolis.Templates
```

Local development:

```bash
dotnet pack src/Novolis.Templates/Novolis.Templates.csproj -c Release -o ./artifacts
dotnet new install ./artifacts/Novolis.Templates.*.nupkg
```

**Prerequisites:** [.NET 10 SDK](https://dotnet.microsoft.com/download) (`net10.0`).

## Quick start

```bash
dotnet new novolismicroservice -n Invoicing
dotnet new novolis-githubsln -n MyLibrary
dotnet new novolis-noxaml-avalonia-sln -n MyDesktopApp
```

## Templates

| Short name | Description |
| --- | --- |
| `novolismicroservice` | Distributed service (Api, Core, Models, Client, Data, Migrations, Tests) |
| `novolis-githubsln` | GitHub-oriented library or tool repository |
| `novolis-noxaml-avalonia-app` | Single-project Avalonia app (code-only UI) |
| `novolis-noxaml-avalonia-sln` | Layered Avalonia solution (code-only UI) |
| `novolismonogame` | MonoGame project (Windows SDK for full build) |

## Governance

- Distributed services: [architectural guideline](https://github.com/Novolis-Platform/novolis-governance/blob/main/docs/architectural-ideals/distributed-services-architectural-guideline.md)
- Repositories and docs: [repository-policy.md](https://github.com/Novolis-Platform/novolis-governance/blob/main/docs/repository-policy.md)
- Gaming scaffolds: [gaming-layer-policy.md](https://github.com/Novolis-Platform/novolis-governance/blob/main/docs/gaming-layer-policy.md)

## More documentation

- [Getting started](https://github.com/Novolis-Platform/novolis-templates/blob/main/docs/getting-started.md)
- [Design](https://github.com/Novolis-Platform/novolis-templates/blob/main/docs/design.md)
- [Documentation policy](https://github.com/Novolis-Platform/novolis-governance/blob/main/docs/documentation-policy.md)
