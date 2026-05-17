# novolis-templates

`dotnet new` template packs for Novolis (`Novolis.Templates`).

## Status

Wave 6 migration from Frank.Templates complete (7 packs; NugetSolution excluded). See [wave-6-templates.md](../novolis-governance/docs/extraction-briefs/wave-6-templates.md).

**CI:** default workflow builds the repo; template pack smoke runs via `Novolis.Templates.SmokeTests`. WPF and MonoGame templates are Windows-only for full `dotnet build`.

## Local validation

```bash
dotnet pack src/Novolis.Templates/Novolis.Templates.csproj -c Release -o ./artifacts
dotnet test Novolis.Templates.slnx
```

## Documentation

- [Getting started](docs/getting-started.md)
- [Design](docs/design.md)
- [Release](docs/release.md)
