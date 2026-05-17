using System.Diagnostics;
using FluentAssertions;

namespace Novolis.Templates.SmokeTests;

public class TemplatePackSmokeTests
{
    private static readonly string RepoRoot = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "..", ".."));
    private static readonly string PackProject = Path.Combine(RepoRoot, "src", "Novolis.Templates", "Novolis.Templates.csproj");
    private static readonly string ArtifactsDir = Path.Combine(Path.GetTempPath(), "novolis-templates-smoke");

    [Test]
    public async Task Pack_install_microservice_and_testcontainers_build()
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

            var tcDir = Path.Combine(ArtifactsDir, "testcontainers");
            await RunDotnet($"new novolis-testcontainers-module -n SmokeModule -o \"{tcDir}\" --force", RepoRoot);
            File.Exists(Path.Combine(tcDir, "SmokeModule.csproj")).Should().BeTrue(
                "testcontainers template is a scaffold; instantiate smoke only");
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

        process.ExitCode.Should().Be(0, $"dotnet {arguments} failed");
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
