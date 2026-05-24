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

## Templates

| Short name | Description |
|------------|-------------|
| `novolismicroservice` | Microservice solution |
| `novolismonogame` | MonoGame project |
| `novolis-noxaml-avalonia-app` | Avalonia app without AXAML (code-only UI) |
| `novolis-noxaml-avalonia-sln` | Layered Avalonia solution without AXAML |
| `novolis-githubsln` | GitHub-oriented solution |
| `novolis-semantic-kernel` | Semantic Kernel project |
| `novolis-testcontainers-module` | Testcontainers module scaffold |

## Related packages

| Package | When to use |
|---------|-------------|
| *(this package)* | Install template packs via `dotnet new install` |

## More documentation

- [Getting started](https://github.com/Novolis-Platform/novolis-templates/blob/main/docs/getting-started.md)
- [Design](https://github.com/Novolis-Platform/novolis-templates/blob/main/docs/design.md)
- [Documentation policy](https://github.com/Novolis-Platform/novolis-governance/blob/main/docs/documentation-policy.md)

## Support

Template pack for Novolis platform scaffolds. MonoGame templates require Windows SDK for full build; see repo README for CI notes.
