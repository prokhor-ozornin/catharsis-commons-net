using Catharsis.Extensions;

namespace Catharsis.Commons;

/// <summary>
///   <para></para>
/// </summary>
public class TempFile : IDisposable
{
  protected bool disposed;

  /// <summary>
  ///   <para></para>
  /// </summary>
  public FileInfo File { get; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  public TempFile() : this(new Random().File())
  {
  }

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="path"></param>
  public TempFile(string path) : this(path.ToFile())
  {
  }

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="file"></param>
  /// <exception cref="ArgumentNullException"></exception>
  public TempFile(FileInfo file) => File = file ?? throw new ArgumentNullException(nameof(file));

  /// <summary>
  ///   <para></para>
  /// </summary>
  public void Dispose()
  {
    if (disposed)
    {
      return;
    }

    File.IsReadOnly = false;
    File.Delete();

    disposed = true;
  }
}