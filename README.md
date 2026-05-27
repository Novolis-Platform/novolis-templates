# novolis-templates

`dotnet new` template packs for Novolis (`Novolis.Templates`).

## Status

Template pack aligned with Novolis governance: distributed service scaffold, GitHub library solution, Avalonia desktop, and MonoGame (gaming).

**CI:** `Novolis.Templates.SmokeTests` packs templates, instantiates key scaffolds, and runs `dotnet build` (microservice also runs `dotnet test`). MonoGame full build may require the Windows SDK.

## Templates

| Short name | Description |
| --- | --- |
| `novolismicroservice` | Distributed service solution |
| `novolis-githubsln` | GitHub-oriented library or tool repository |
| `novolis-noxaml-avalonia-app` | Avalonia app without AXAML |
| `novolis-noxaml-avalonia-sln` | Layered Avalonia solution |
| `novolismonogame` | MonoGame project |

See [docs/design.md](docs/design.md) for layout and governance links.

## Local validation

```bash
dotnet pack src/Novolis.Templates/Novolis.Templates.csproj -c Release -o ./artifacts
dotnet test Novolis.Templates.slnx
```

## Documentation

- [Getting started](docs/getting-started.md)
- [Design](docs/design.md)
- [Release](docs/release.md)
- [Distributed services guideline](https://github.com/Novolis-Platform/novolis-governance/blob/main/docs/architectural-ideals/distributed-services-architectural-guideline.md)
