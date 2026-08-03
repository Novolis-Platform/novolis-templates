<!-- novolis-pkg-brand:start -->
<p align="center">
  <a href="https://github.com/Novolis-Platform/novolis-templates">
    <img src="https://raw.githubusercontent.com/Novolis-Platform/.github/main/brand/logo-icon.svg" width="72" alt="Novolis"/>
  </a>
</p>
<!-- novolis-pkg-brand:end -->

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

## Install

```bash
dotnet add package Novolis.Templates.NoXaml.Avalonia.Solution.App
```

**Prerequisites:** [.NET 10 SDK](https://dotnet.microsoft.com/download) (`net10.0`).


