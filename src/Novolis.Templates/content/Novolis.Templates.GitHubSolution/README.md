# Solution

GitHub-oriented repository scaffold for a **packable .NET library or tool** (`dotnet new novolis-githubsln -n MyLibrary`).

## What you get

| Item | Purpose |
|------|---------|
| `Novolis.Templates.GitHubSolution.sln` | Empty solution (add projects next) |
| `Directory.Build.props` / `.targets` | `net10.0`, packable defaults, artifacts layout, SourceLink |
| `build/version.json` + `version.props` | CalVer package versioning |
| `build/Novolis.Documentation.props` | README + XML doc policy for packable projects |
| `nuget.config` | nuget.org + GitHub Packages (`Novolis.*`) |
| `.github/workflows/` | PR, merge, and release CI |

## Quick start

```bash
dotnet new novolis-githubsln -n Acme.Widgets
cd Acme.Widgets
dotnet new classlib -n Acme.Widgets.Core -o src/Acme.Widgets.Core
dotnet sln add src/Acme.Widgets.Core/Acme.Widgets.Core.csproj
dotnet build
```

## Next steps

1. Add `docs/getting-started.md`, `docs/design.md`, and `docs/release.md` per [repository policy](https://github.com/Novolis-Platform/novolis-governance/blob/main/docs/repository-policy.md).
2. Add a `README.md` next to each packable `.csproj` and set `PackageReadmeFile`.
3. Document public API with XML comments before removing transitional `CS1591` suppressions — see [documentation policy](https://github.com/Novolis-Platform/novolis-governance/blob/main/docs/documentation-policy.md).

Packages restore from **nuget.org** and **GitHub Packages** only (`Novolis.*` at `2026.1.*`).
