# Novolis.Templates

`dotnet new` template packs for the Novolis ecosystem.

## Install

```bash
dotnet new install Novolis.Templates::0.1.0-preview.1
```

Local development:

```bash
dotnet pack src/Novolis.Templates/Novolis.Templates.csproj -c Release -o ./artifacts
dotnet new install ./artifacts/Novolis.Templates.*.nupkg
```

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

## CI and platform notes

- Linux CI runs `dotnet pack` and smoke tests (`novolismicroservice` build + `novolis-testcontainers-module` instantiate).
- **MonoGame** templates require the Windows SDK and are not built in default Linux CI; verify locally on Windows.
- **NoXaml Avalonia** templates cross-compile on Linux CI (`dotnet build`); run the app locally to verify UI.
- **Semantic Kernel** template is a starter with intentional `TODO` placeholders and is not part of automated build smoke.

## Uninstall

```bash
dotnet new uninstall Novolis.Templates
```
