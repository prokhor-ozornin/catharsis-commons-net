using System.Security;
using Catharsis.Extensions;

namespace Catharsis.Commons.Tests;

/// <summary>
///   <para></para>
/// </summary>
public abstract class UnitTest : IDisposable
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected const string ShellCommand = "cmd.exe";

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected CancellationToken Cancellation { get; } = new(true);

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected Uri LocalHost { get; } = "https://localhost".ToUri();

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected Random Randomizer { get; } = new();

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected byte[] RandomBytes => new Random().ByteSequence(short.MaxValue).AsArray();

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected string RandomString => new Random().Letters(short.MaxValue);

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected SecureString EmptySecureString { get; } = new SecureString().AsReadOnly();

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected string RandomName => new Random().Letters(25);

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected static FileInfo RandomFakeFile => new Random().FilePath().ToFile();

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected FileInfo RandomEmptyFile => new Random().File();

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected FileInfo RandomNonEmptyFile => new Random().TextFileAsync(short.MaxValue).Await();

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected DirectoryInfo RandomDirectory => new Random().Directory();

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected DirectoryInfo RandomFakeDirectory => new Random().DirectoryPath().ToDirectory();

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected MemoryStream RandomStream => new Random().MemoryStreamAsync(short.MaxValue).Await();

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected SecureString RandomSecureString => new Random().SecureString(short.MaxValue);

  /// <summary>
  ///   <para></para>
  /// </summary>
  public virtual void Dispose()
  {
    EmptySecureString.Dispose();
  }
}