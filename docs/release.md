# Release

This repository publishes with the org CalVer scheme (`2026.1.*`) via `merge.yml` to GitHub Packages when packages are packable.

See [release-policy](https://github.com/Novolis-Platform/novolis-governance/blob/main/docs/release-policy.md).

Published docs: [https://novolis-platform.github.io/.github/novolis-templates/](https://novolis-platform.github.io/.github/novolis-templates/)

## Packages

- `Novolis.Templates`
- `Novolis.Templates.Microservice.Client`
- `Novolis.Templates.Microservice.Models`
- `Novolis.Templates.MonoGame`
- `Novolis.Templates.NoXaml.Avalonia.App`
- `Novolis.Templates.NoXaml.Avalonia.Solution.App`
- `Novolis.Templates.NoXaml.Avalonia.Solution.Controls`
- `Novolis.Templates.NoXaml.Avalonia.Solution.Core`
- `Novolis.Templates.NoXaml.Avalonia.Solution.Models`

## Consumers

Restore from nuget.org + `https://nuget.pkg.github.com/Novolis-Platform/index.json` only.

Local multi-repo iteration: open `d:\novolis\Novolis.Platform.slnx` (ProjectReference mode) — do not add a local feed.
