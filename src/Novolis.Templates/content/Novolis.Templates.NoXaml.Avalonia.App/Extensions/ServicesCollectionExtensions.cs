using Microsoft.Extensions.Hosting;

namespace Novolis.Templates.NoXaml.Avalonia.App.Extensions;

internal static class ServicesCollectionExtensions
{
    /// <summary>
    /// Sets the content root path to be the same as the EXE directory.
    /// </summary>
    public static DirectoryInfo SetContentPathToApplicationDirectory(this HostBuilderContext context)
    {
        context.HostingEnvironment.ContentRootPath = AppContext.BaseDirectory;
        return new DirectoryInfo(context.HostingEnvironment.ContentRootPath);
    }
}
