using Avalonia.Controls;
using Microsoft.Extensions.Logging;
using Novolis.Templates.NoXaml.Avalonia.Solution.Controls;
using Novolis.Templates.NoXaml.Avalonia.Solution.Core;

namespace Novolis.Templates.NoXaml.Avalonia.Solution.App;

internal sealed class MainWindow : Window
{
    private readonly ILogger<MainWindow> _logger;
    private readonly MyTextBox _textBox;

    public MainWindow(ILogger<MainWindow> logger, ITemperatureConverterService converterService)
    {
        _logger = logger;
        _ = converterService;
        _textBox = new MyTextBox(
            "Write something",
            async (_, _) => await MessageDialog.ShowAsync(this, _textBox.Text));

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

    private void OnClosing(object? sender, WindowClosingEventArgs e)
    {
        _logger.LogInformation("Closing");
    }
}
