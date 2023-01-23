using Catharsis.Extensions;

namespace Catharsis.Conversions;

/// <summary>
///   <para></para>
/// </summary>
public static class DirectoryInfoConverters
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="pattern"></param>
  /// <param name="recursive"></param>
  /// <returns></returns>
  public static IEnumerable<FileSystemInfo> Enumerable(this IConversion<DirectoryInfo> conversion, string pattern = null, bool recursive = false) => conversion.To(directory => directory.ToEnumerable(pattern, recursive));
}