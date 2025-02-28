using System.Runtime.InteropServices;

namespace Devantler.KindCLI.Tests.KindTests;

/// <summary>
/// Tests for the <see cref="Kind.GetCommand(PlatformID?, Architecture?, string?)"/> method.
/// </summary>
public class GetCommandTests
{
  /// <summary>
  /// Test to verify that the command returns the correct binary for MacOS on x64 architecture.
  /// </summary>
  [Theory]
  [InlineData(PlatformID.Unix, Architecture.X64, "osx-x64", "kind-osx-x64")]
  [InlineData(PlatformID.Unix, Architecture.Arm64, "osx-arm64", "kind-osx-arm64")]
  [InlineData(PlatformID.Unix, Architecture.X64, "linux-x64", "kind-linux-x64")]
  [InlineData(PlatformID.Unix, Architecture.Arm64, "linux-arm64", "kind-linux-arm64")]
  [InlineData(PlatformID.Win32NT, Architecture.X64, "win-x64", "kind-win-x64.exe")]
  public void GetCommand_ShouldReturnOSXx64Binary(PlatformID platformID, Architecture architecture, string runtimeIdentifier, string expectedBinary)
  {
    // Act
    string actualBinary = Path.GetFileName(Kind.GetCommand(platformID, architecture, runtimeIdentifier).TargetFilePath);

    // Assert
    Assert.Equal(expectedBinary, actualBinary);
  }

  /// <summary>
  /// Test to verify that the command returns a <see cref="PlatformNotSupportedException"/> when the platform is not supported.
  /// </summary>
  [Fact]
  public void GetCommand_GivenInvaldiPlatform_ShouldThrowPlatformNotSupportedException()
  {
    // Arrange
    var platformID = PlatformID.Other;
    var architecture = Architecture.Wasm;
    string runtimeIdentifier = "wasm";

    // Act
    void Act() => Kind.GetCommand(platformID, architecture, runtimeIdentifier);

    // Assert
    _ = Assert.Throws<PlatformNotSupportedException>(Act);
  }
}
