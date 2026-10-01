<!-- novolis-pkg-brand:start -->
[![Novolis](https://raw.githubusercontent.com/Novolis-Platform/.github/main/brand/logo-icon.png)](https://novolis-platform.github.io/.github/novolis-templates/)

[Novolis](https://github.com/Novolis-Platform) · [Docs](https://novolis-platform.github.io/.github/novolis-templates/) · [Source](https://github.com/Novolis-Platform/novolis-templates)
<!-- novolis-pkg-brand:end -->

# Game

MonoGame entry project — **Generic Host** + `GameHost` background service.

## Structure

| Area | Contents |
|------|----------|
| `Program.cs` | `Host.CreateDefaultBuilder` → `AddGame` → `GameHost` |
| `GameHost.cs` | Starts `IGameWindow`, manages `GraphicsDeviceManager` |
| `GameWindow.cs` | MonoGame `Game` subclass (update/draw loop) |
| `Extensions/` | DI registration, viewport/shape helpers |
| `Models/` | Sample shapes, physics, game options |

## Run

```bash
dotnet run --project Novolis.Templates.MonoGame
```

Configure gameplay via `appsettings.json` (`GameOptions`, `PlayerOptions`).

## Packable library

If you publish this project as a NuGet package, replace this README with package-specific install/API docs per [documentation policy](https://github.com/Novolis-Platform/novolis-governance/blob/main/docs/documentation-policy.md).

```bash
dotnet add package Your.PackageId
```

**Prerequisites:** [.NET 10 SDK](https://dotnet.microsoft.com/download) (`net10.0`), MonoGame platform workload.

## Install

```bash
dotnet add package Novolis.Templates.MonoGame
```

**Prerequisites:** [.NET 10 SDK](https://dotnet.microsoft.com/download) (`net10.0`).


