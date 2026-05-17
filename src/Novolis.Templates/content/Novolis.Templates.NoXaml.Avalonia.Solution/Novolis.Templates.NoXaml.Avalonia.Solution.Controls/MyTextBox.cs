using Avalonia.Controls;

namespace Novolis.Templates.NoXaml.Avalonia.Solution.Controls;

public class MyTextBox : GroupBox
{
    private readonly TextBox _textBox;

    public MyTextBox(string header, EventHandler<TextChangedEventArgs>? textChanged, string defaultText = "")
    {
        Header = header;
        _textBox = new TextBox { Text = defaultText };
        if (textChanged is not null)
        {
            _textBox.TextChanged += textChanged;
        }

        Content = _textBox;
    }

    public string Text => _textBox.Text ?? string.Empty;
}
