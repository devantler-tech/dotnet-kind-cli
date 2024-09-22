namespace Devantler.KindCLI.Tests.KindTests;

/// <summary>
/// Tests for all methods in the <see cref="Kind"/> class.
/// </summary>
public class AllMethodsTests
{
  /// <summary>
  /// Test to verify that all methods in the <see cref="Kind"/> class work as expected.
  /// </summary>
  /// <returns></returns>
  [Fact]
  public async Task AllMethods_WithValidParameters_Succeeds()
  {
    // Arrange
    string clusterName = "test-cluster";
    string configPath = $"{AppContext.BaseDirectory}assets/Kind-config.yaml";

    // Act
    var createClusterException = await Record.ExceptionAsync(async () => await Kind.CreateClusterAsync(clusterName, configPath, CancellationToken.None).ConfigureAwait(false));
    string[] clusters = await Kind.ListClustersAsync(CancellationToken.None);
    bool clusterExists = await Kind.GetClusterAsync(clusterName, CancellationToken.None);
    var stopClusterException = await Record.ExceptionAsync(async () => await Kind.StopClusterAsync(clusterName, CancellationToken.None).ConfigureAwait(false));
    var startClusterException = await Record.ExceptionAsync(async () => await Kind.StartClusterAsync(clusterName, CancellationToken.None).ConfigureAwait(false));

    // Assert
    Assert.Null(createClusterException);
    string expectedClusterName = Assert.Single(clusters);
    Assert.Equal(clusterName, expectedClusterName);
    Assert.True(clusterExists);
    Assert.Null(stopClusterException);
    Assert.Null(startClusterException);

    // Cleanup
    await Kind.DeleteClusterAsync(clusterName, CancellationToken.None);
  }

  /// <summary>
  /// Test to verify that all methods in the <see cref="Kind"/> class fail as expected.
  /// </summary>
  /// <returns></returns>
  [Fact]
  public async Task WithInvalidParameters_Fails()
  {
    // Arrange
    string clusterName = "test-cluster";
    string configPath = $"{AppContext.BaseDirectory}assets/invalid-config.yaml";

    // Act
    var createClusterException = await Record.ExceptionAsync(async () => await Kind.CreateClusterAsync(clusterName, configPath, CancellationToken.None).ConfigureAwait(false));

    // Assert
    Assert.NotNull(createClusterException);
  }
}
