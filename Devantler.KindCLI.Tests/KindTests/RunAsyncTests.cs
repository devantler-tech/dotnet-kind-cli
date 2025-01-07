using CliWrap;

namespace Devantler.KindCLI.Tests.KindTests;

/// <summary>
/// Tests for the <see cref="Kind.RunAsync(string[], CommandResultValidation, bool, bool, CancellationToken)" /> method.
/// </summary>
public class RunAsyncTests
{
  /// <summary>
  /// Tests that the binary can return the version of the kind CLI command.
  /// </summary>
  /// <returns></returns>
  [Fact]
  public async Task RunAsync_Version_ReturnsVersion()
  {
    // Act
    var (exitCode, message) = await Kind.RunAsync(["--version"]);

    // Assert
    Assert.Equal(0, exitCode);
    Assert.Matches(@"^kind version \d+\.\d+\.\d+$", message.Trim());
  }
}
