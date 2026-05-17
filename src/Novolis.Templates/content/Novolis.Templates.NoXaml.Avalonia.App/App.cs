using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Styling;
using Avalonia.Themes.Fluent;
using Microsoft.Extensions.DependencyInjection;

namespace Novolis.Templates.NoXaml.Avalonia.App;

public class App : Application
{
    public override void Initialize()
    {
        Styles.Add(new FluentTheme());
        RequestedThemeVariant = ThemeVariant.Dark;
    }

    public override void OnFrameworkInitializationCompleted()
    {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            desktop.MainWindow = Program.ApplicationHost.Services.GetRequiredService<MainWindow>();
            desktop.ShutdownRequested += (_, _) =>
            {
                if (OperatingSystem.IsWindows())
                {
                    NativeConsole.Free();
                }
            };
        }

        base.OnFrameworkInitializationCompleted();
    }
}
