using Catharsis.Extensions;

namespace Catharsis.Commons;

/// <summary>
///   <para></para>
/// </summary>
public class TempDirectory : IDisposable
{
  protected bool disposed;

  /// <summary>
  ///   <para></para>
  /// </summary>
  public DirectoryInfo Directory { get; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  public TempDirectory() : this(new Random().Directory())
  {
  }

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="path"></param>
  public TempDirectory(string path) : this(path.ToDirectory())
  {
  }

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="directory"></param>
  /// <exception cref="ArgumentNullException"></exception>
  public TempDirectory(DirectoryInfo directory) => Directory = directory ?? throw new ArgumentNullException(nameof(directory));

  /// <summary>
  ///   <para></para>
  /// </summary>
  public void Dispose()
  {
    if (disposed)
    {
      return;
    }

    Directory.Delete();

    disposed = true;
  }
}