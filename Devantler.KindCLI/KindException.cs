namespace Devantler.KindCLI;

/// <summary>
/// A custom exception for Kind CLI errors.
/// </summary>
[Serializable]
public class KindException : Exception
{
  /// <inheritdoc />
  public KindException()
  {
  }

  /// <inheritdoc />
  public KindException(string? message) : base(message)
  {
  }

  /// <inheritdoc />
  public KindException(string? message, Exception? innerException) : base(message, innerException)
  {
  }
}
