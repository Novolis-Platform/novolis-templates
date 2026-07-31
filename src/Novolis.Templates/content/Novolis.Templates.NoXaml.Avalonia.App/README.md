# Application

Single-project **No-XAML Avalonia** desktop app (`dotnet new novolis-noxaml-avalonia-app -n MyApp`).

UI is code-only: `MainWindow`, custom `MyTextBox`, and `MessageDialog` — no `.axaml` files. Uses **Generic Host** with a `Worker` background service.

## Run

```bash
dotnet run --project Novolis.Templates.NoXaml.Avalonia.App
```

On Windows, `NativeConsole.Alloc()` enables host logging beside the Avalonia window.

## What the sample does

1. Shows a text box (`MyTextBox`)
2. On text change, opens a modal dialog (`MessageDialog`)
3. `Worker` logs heartbeat messages to the console

## Next steps

1. Split into a layered solution (`dotnet new novolis-noxaml-avalonia-sln`) as the app grows.
2. Add `docs/getting-started.md` if this becomes a product repository.
3. For packable libraries extracted from this app, add Install/API README sections per [documentation policy](https://github.com/Novolis-Platform/novolis-governance/blob/main/docs/documentation-policy.md).

Packages restore from **nuget.org** and **GitHub Packages** only.
