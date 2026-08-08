using System.Diagnostics;
using TUnit.Core;

namespace Novolis.Templates.SmokeTests;

public class TemplatePackSmokeTests
{
    private static readonly string RepoRoot = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "..", ".."));
    private static readonly string PackProject = Path.Combine(RepoRoot, "src", "Novolis.Templates", "Novolis.Templates.csproj");
    private static readonly string ArtifactsDir = Path.Combine(Path.GetTempPath(), "novolis-templates-smoke");

    /// <summary>Keeps the project non-empty for Platform.slnx (pack smoke is Explicit).</summary>
    [Test]
    public async Task Smoke_project_discovers_at_least_one_default_test()
    {
        await Assert.That(File.Exists(PackProject)).IsTrue();
    }

    /// <summary>Pack + install + scaffold build/test (~45s+). Opt-in only so Platform.slnx stays fast.</summary>
    [Test]
    [Explicit]
    public async Task Pack_install_templates_and_build_scaffolds()
    {
        if (Directory.Exists(ArtifactsDir))
        {
            Directory.Delete(ArtifactsDir, true);
        }

        Directory.CreateDirectory(ArtifactsDir);

        var packDir = Path.Combine(ArtifactsDir, "pack");
        Directory.CreateDirectory(packDir);

        await RunDotnet($"pack \"{PackProject}\" -c Release -o \"{packDir}\"", RepoRoot);

        await RunDotnetOptional("new uninstall Novolis.Templates", RepoRoot);
        await RunDotnetOptional("new uninstall Frank.Templates", RepoRoot);

        var nupkg = Directory.GetFiles(packDir, "Novolis.Templates.*.nupkg").Single();
        await RunDotnet($"new install \"{nupkg}\"", RepoRoot);

        try
        {
            var microDir = Path.Combine(ArtifactsDir, "microservice");
            await RunDotnet($"new novolismicroservice -n SmokeMicro -o \"{microDir}\" --force", RepoRoot);
            var microSln = Directory.GetFiles(microDir, "*.sln").Single();
            await RunDotnet($"build \"{microSln}\"", microDir);
            await RunDotnet($"test --solution \"{microSln}\" --no-build", microDir);

            var avaloniaDir = Path.Combine(ArtifactsDir, "noxaml-avalonia");
            await RunDotnet($"new novolis-noxaml-avalonia-sln -n SmokeAvalonia -o \"{avaloniaDir}\" --force", RepoRoot);
            var avaloniaSln = Directory.GetFiles(avaloniaDir, "*.sln").Single();
            await RunDotnet($"build \"{avaloniaSln}\"", avaloniaDir);
        }
        finally
        {
            await RunDotnet("new uninstall Novolis.Templates", RepoRoot);
        }
    }

    private static async Task RunDotnet(string arguments, string workingDirectory)
    {
        var psi = new ProcessStartInfo("dotnet", arguments)
        {
            WorkingDirectory = workingDirectory,
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            UseShellExecute = false,
        };

        using var process = Process.Start(psi)!;
        var stdout = await process.StandardOutput.ReadToEndAsync();
        var stderr = await process.StandardError.ReadToEndAsync();
        await process.WaitForExitAsync();

        TestContext.Current?.OutputWriter.WriteLine($"dotnet {arguments}");
        TestContext.Current?.OutputWriter.WriteLine(stdout);
        if (!string.IsNullOrWhiteSpace(stderr))
        {
            TestContext.Current?.OutputWriter.WriteLine(stderr);
        }

        await Assert.That(process.ExitCode).IsEqualTo(0)
            .Because($"dotnet {arguments} failed");
    }

    private static async Task RunDotnetOptional(string arguments, string workingDirectory)
    {
        var psi = new ProcessStartInfo("dotnet", arguments)
        {
            WorkingDirectory = workingDirectory,
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            UseShellExecute = false,
        };

        using var process = Process.Start(psi)!;
        await process.StandardOutput.ReadToEndAsync();
        await process.StandardError.ReadToEndAsync();
        await process.WaitForExitAsync();
    }
}
