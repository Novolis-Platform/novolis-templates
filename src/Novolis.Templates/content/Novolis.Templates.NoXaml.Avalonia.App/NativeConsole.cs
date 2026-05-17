using System.Runtime.InteropServices;

namespace Novolis.Templates.NoXaml.Avalonia.App;

internal static class NativeConsole
{
    [DllImport("kernel32")]
    internal static extern bool Alloc();

    [DllImport("kernel32")]
    internal static extern bool Free();
}
