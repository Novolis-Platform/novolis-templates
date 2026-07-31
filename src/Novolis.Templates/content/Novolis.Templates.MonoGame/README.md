# Solution

MonoGame game scaffold with **Generic Host** integration (`dotnet new novolismonogame -n MyGame`).

Project names become `MyGame`, `MyGame.Tests`, etc.

## What you get

| Project | Role |
|---------|------|
| `Novolis.Templates.MonoGame` | Game loop, input, drawing helpers, DI extensions |
| `Novolis.Templates.MonoGame.Tests` | TUnit sample |

The game runs as a `BackgroundService` (`GameHost`) that owns `GraphicsDeviceManager` and drives `IGameWindow.Run()`.

## Run

```bash
dotnet run --project Novolis.Templates.MonoGame
```

**Note:** full build may require the **Windows SDK** (DirectX / MonoGame content pipeline).

## Test

```bash
dotnet test
```

## Next steps

1. Replace placeholder shapes/physics with your game content.
2. Add `docs/getting-started.md`, `docs/design.md`, and `docs/release.md` per [repository policy](https://github.com/Novolis-Platform/novolis-governance/blob/main/docs/repository-policy.md).
3. Follow [gaming-layer-policy](https://github.com/Novolis-Platform/novolis-governance/blob/main/docs/gaming-layer-policy.md) for Novolis gaming packages.

Packages restore from **nuget.org** and **GitHub Packages** only.
