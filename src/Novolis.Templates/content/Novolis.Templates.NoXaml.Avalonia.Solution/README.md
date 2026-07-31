# Solution

Layered **No-XAML Avalonia** desktop solution with Generic Host and background services (`dotnet new novolis-noxaml-avalonia-sln -n MyDesktopApp`).

Project names become `MyDesktopApp.App`, `MyDesktopApp.Core`, etc. UI is built entirely in C# — no `.axaml` files.

## Projects

| Project | Role |
|---------|------|
| `Novolis.Templates.NoXaml.Avalonia.Solution.App` | WinExe — `Program`, `MainWindow`, `Worker` hosted service |
| `Novolis.Templates.NoXaml.Avalonia.Solution.Core` | Domain services (sample: temperature converter) |
| `Novolis.Templates.NoXaml.Avalonia.Solution.Controls` | Reusable Avalonia controls |
| `Novolis.Templates.NoXaml.Avalonia.Solution.Models` | Shared DTOs / view models |
| `Novolis.Templates.NoXaml.Avalonia.Solution.Tests` | TUnit tests |

## Run

```bash
dotnet run --project Novolis.Templates.NoXaml.Avalonia.Solution.App
```

On Windows, a native console is allocated for host logging alongside the Avalonia window.

## Test

```bash
dotnet test
```

## Next steps

1. Move UI into `Controls/`, business logic into `Core/`, and wire DI in `App` extensions.
2. Add `docs/getting-started.md`, `docs/design.md`, and `docs/release.md` per [repository policy](https://github.com/Novolis-Platform/novolis-governance/blob/main/docs/repository-policy.md).
3. For packable control libraries, add project READMEs with Install/API sections.

Packages restore from **nuget.org** and **GitHub Packages** only.
