using Avalonia;
using Avalonia.Controls;
using Avalonia.Layout;

namespace Novolis.Templates.NoXaml.Avalonia.App;

internal static class MessageDialog
{
    public static async Task ShowAsync(Window owner, string message)
    {
        var dialog = new Window
        {
            Title = "Message",
            Width = 360,
            Height = 140,
            WindowStartupLocation = WindowStartupLocation.CenterOwner,
            CanResize = false,
        };

        var ok = new Button { Content = "OK", HorizontalAlignment = HorizontalAlignment.Center };
        ok.Click += (_, _) => dialog.Close();

        dialog.Content = new StackPanel
        {
            Margin = new Thickness(16),
            Spacing = 12,
            Children =
            {
                new TextBlock { Text = message, TextWrapping = Avalonia.Media.TextWrapping.Wrap },
                ok,
            },
        };

        await dialog.ShowDialog(owner);
    }
}
