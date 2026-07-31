# App

Avalonia **WinExe** entry point for the No-XAML solution.

- `Program.cs` — Generic Host + `BuildAvaloniaApp().StartWithClassicDesktopLifetime`
- `MainWindow.cs` — sample UI wiring Core services and Controls
- `Worker.cs` — `BackgroundService` heartbeat logging
- `Extensions/ServicesCollectionExtensions.cs` — DI registration

## Run

```bash
dotnet run --project Novolis.Templates.NoXaml.Avalonia.Solution.App
```

References: `.Core`, `.Controls`, `.Models`.
