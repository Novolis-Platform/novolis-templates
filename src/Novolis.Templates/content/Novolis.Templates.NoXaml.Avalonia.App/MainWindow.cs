using Avalonia.Controls;
using Microsoft.Extensions.Logging;

namespace Novolis.Templates.NoXaml.Avalonia.App;

internal sealed class MainWindow : Window
{
    private readonly ILogger<MainWindow> _logger;
    private readonly MyTextBox _textBox;

    public MainWindow(ILogger<MainWindow> logger)
    {
        _logger = logger;
        _textBox = new MyTextBox("Write something", OnTextChanged);

        ConfigureWindow();
        Content = _textBox;
        Closing += OnClosing;
    }

    private void ConfigureWindow()
    {
        Title = "Novolis NoXaml Avalonia";
        MinWidth = 512;
        MinHeight = 256;
        SizeToContent = SizeToContent.WidthAndHeight;
        WindowStartupLocation = WindowStartupLocation.CenterScreen;
    }

    private async void OnTextChanged(object? sender, TextChangedEventArgs e)
    {
        await MessageDialog.ShowAsync(this, _textBox.Text);
    }

    private void OnClosing(object? sender, WindowClosingEventArgs e)
    {
        _logger.LogInformation("Closing");
    }
}
