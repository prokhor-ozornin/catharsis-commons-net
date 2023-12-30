using System.Security;
using Catharsis.Extensions;

namespace Catharsis.Commons.Tests;

/// <summary>
///   <para></para>
/// </summary>
public static class ICommonsTestAttributesExtensions
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="attributes"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static string ShellCommand(this ITestAttributes attributes) => attributes is not null ? attributes.Retrieve(nameof(ShellCommand), "cmd.exe") : throw new ArgumentNullException(nameof(attributes));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="attributes"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static Uri LocalHost(this ITestAttributes attributes) => attributes is not null ? attributes.Retrieve(nameof(LocalHost), "https://localhost".ToUri()) : throw new ArgumentNullException(nameof(attributes));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="attributes"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static byte[] RandomBytes(this ITestAttributes attributes) => attributes is not null ? attributes.Retrieve(nameof(RandomBytes), new Random().ByteSequence(short.MaxValue).AsArray()) : throw new ArgumentNullException(nameof(attributes));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="attributes"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static string RandomString(this ITestAttributes attributes) => attributes is not null ? attributes.Retrieve(nameof(RandomString), new Random().Letters(short.MaxValue)) : throw new ArgumentNullException(nameof(attributes));
  
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="attributes"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static SecureString EmptySecureString(this ITestAttributes attributes) => attributes is not null ? attributes.Retrieve(nameof(EmptySecureString), new SecureString().AsReadOnly()) : throw new ArgumentNullException(nameof(attributes));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="attributes"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static string RandomName(this ITestAttributes attributes) => attributes is not null ? attributes.Retrieve(nameof(RandomName), new Random().Letters(25)) : throw new ArgumentNullException(nameof(attributes));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="attributes"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static FileInfo RandomFakeFile(this ITestAttributes attributes) => attributes is not null ? attributes.Retrieve(nameof(RandomFakeFile), new Random().FilePath().ToFile()) : throw new ArgumentNullException(nameof(attributes));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="attributes"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static FileInfo RandomEmptyFile(this ITestAttributes attributes) => attributes is not null ? attributes.Retrieve(nameof(RandomEmptyFile), new Random().File()) : throw new ArgumentNullException(nameof(attributes));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="attributes"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static FileInfo RandomNonEmptyFile(this ITestAttributes attributes) => attributes is not null ? attributes.Retrieve(nameof(RandomNonEmptyFile), new Random().TextFileAsync(short.MaxValue).Await()) : throw new ArgumentNullException(nameof(attributes));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="attributes"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static DirectoryInfo RandomDirectory(this ITestAttributes attributes) => attributes is not null ? attributes.Retrieve(nameof(RandomDirectory), new Random().Directory()) : throw new ArgumentNullException(nameof(attributes));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="attributes"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static DirectoryInfo RandomFakeDirectory(this ITestAttributes attributes) => attributes is not null ? attributes.Retrieve(nameof(RandomFakeDirectory), new Random().DirectoryPath().ToDirectory()) : throw new ArgumentNullException(nameof(attributes));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="attributes"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static MemoryStream RandomStream(this ITestAttributes attributes) => attributes is not null ? attributes.Retrieve(nameof(RandomStream), new Random().MemoryStreamAsync(short.MaxValue).Await()) : throw new ArgumentNullException(nameof(attributes));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="attributes"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static SecureString RandomSecureString(this ITestAttributes attributes) => attributes is not null ? attributes.Retrieve(nameof(RandomSecureString), new Random().SecureString(short.MaxValue)) : throw new ArgumentNullException(nameof(attributes));
}