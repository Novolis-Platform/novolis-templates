<!-- novolis-marketing:start -->
<p align="center">
  <a href="https://github.com/Novolis-Platform">
    <img src="https://raw.githubusercontent.com/Novolis-Platform/.github/main/brand/logo-brand-transparent.svg" width="360" alt="Novolis"/>
  </a>
</p>

<p align="center">
  <img src="https://raw.githubusercontent.com/Novolis-Platform/.github/main/brand/banners/novolis-templates.svg" width="100%" alt="novolis-templates"/>
</p>

<p align="center">
  <strong>dotnet new templates</strong><br/>
  dotnet new templates for Novolis apps and libraries.
</p>

<p align="center">
  <a href="https://novolis-platform.github.io/.github/novolis-templates/"><img src="https://img.shields.io/badge/docs-portfolio-0a7ea3" alt="docs"/></a>
  <a href="https://github.com/Novolis-Platform/novolis-templates/actions"><img src="https://img.shields.io/github/actions/workflow/status/Novolis-Platform/novolis-templates/merge.yml?branch=main&label=merge&logo=github" alt="merge"/></a>
  <a href="https://github.com/orgs/Novolis-Platform/packages?repo_name=novolis-templates"><img src="https://img.shields.io/badge/packages-GitHub%20Packages-0a7ea3?logo=nuget" alt="packages"/></a>
  <a href="https://github.com/Novolis-Platform"><img src="https://img.shields.io/badge/org-Novolis--Platform-111827" alt="org"/></a>
</p>

<p align="center">
  <a href="https://novolis-platform.github.io/.github/novolis-templates/">Docs</a>
  ·
  <a href="https://nuget.pkg.github.com/Novolis-Platform/index.json"><code>https://nuget.pkg.github.com/Novolis-Platform/index.json</code></a>
  ·
  <a href="https://github.com/Novolis-Platform/.github/blob/main/profile/README.md">Org landing</a>
  ·
  <a href="https://github.com/Novolis-Platform/novolis-governance">Governance</a>
</p>

---
<!-- novolis-marketing:end -->
<!-- novolis-package-index:start -->
> **GitHub Packages shows this repository README on every package page** (upstream limitation).
> Open the **package README** for install and quick start — embedded in each .nupkg and linked below.

## Published packages

| Package | Install | Package README |
|---------|---------|----------------|
| `Novolis.Templates` | `dotnet add package Novolis.Templates` | [README](https://github.com/Novolis-Platform/novolis-templates/blob/main/src/Novolis.Templates/README.md) |
| `Novolis.Templates.Microservice.Client` | `dotnet add package Novolis.Templates.Microservice.Client` | [README](https://github.com/Novolis-Platform/novolis-templates/blob/main/src/Novolis.Templates/content/Novolis.Templates.Microservice/Novolis.Templates.Microservice.Client/README.md) |
| `Novolis.Templates.Microservice.Models` | `dotnet add package Novolis.Templates.Microservice.Models` | [README](https://github.com/Novolis-Platform/novolis-templates/blob/main/src/Novolis.Templates/content/Novolis.Templates.Microservice/Novolis.Templates.Microservice.Models/README.md) |
| `Novolis.Templates.MonoGame` | `dotnet add package Novolis.Templates.MonoGame` | [README](https://github.com/Novolis-Platform/novolis-templates/blob/main/src/Novolis.Templates/content/Novolis.Templates.MonoGame/Novolis.Templates.MonoGame/README.md) |
| `Novolis.Templates.NoXaml.Avalonia.App` | `dotnet add package Novolis.Templates.NoXaml.Avalonia.App` | [README](https://github.com/Novolis-Platform/novolis-templates/blob/main/src/Novolis.Templates/content/Novolis.Templates.NoXaml.Avalonia.App/README.md) |
| `Novolis.Templates.NoXaml.Avalonia.Solution.App` | `dotnet add package Novolis.Templates.NoXaml.Avalonia.Solution.App` | [README](https://github.com/Novolis-Platform/novolis-templates/blob/main/src/Novolis.Templates/content/Novolis.Templates.NoXaml.Avalonia.Solution/Novolis.Templates.NoXaml.Avalonia.Solution.App/README.md) |
| `Novolis.Templates.NoXaml.Avalonia.Solution.Controls` | `dotnet add package Novolis.Templates.NoXaml.Avalonia.Solution.Controls` | [README](https://github.com/Novolis-Platform/novolis-templates/blob/main/src/Novolis.Templates/content/Novolis.Templates.NoXaml.Avalonia.Solution/Novolis.Templates.NoXaml.Avalonia.Solution.Controls/README.md) |
| `Novolis.Templates.NoXaml.Avalonia.Solution.Core` | `dotnet add package Novolis.Templates.NoXaml.Avalonia.Solution.Core` | [README](https://github.com/Novolis-Platform/novolis-templates/blob/main/src/Novolis.Templates/content/Novolis.Templates.NoXaml.Avalonia.Solution/Novolis.Templates.NoXaml.Avalonia.Solution.Core/README.md) |
| `Novolis.Templates.NoXaml.Avalonia.Solution.Models` | `dotnet add package Novolis.Templates.NoXaml.Avalonia.Solution.Models` | [README](https://github.com/Novolis-Platform/novolis-templates/blob/main/src/Novolis.Templates/content/Novolis.Templates.NoXaml.Avalonia.Solution/Novolis.Templates.NoXaml.Avalonia.Solution.Models/README.md) |

For NuGet.org and Visual Studio, the **embedded** README.md inside each package is authoritative.

<!-- novolis-package-index:end -->
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

