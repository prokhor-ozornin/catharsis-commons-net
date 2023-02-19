using Catharsis.Extensions;

namespace Catharsis.Conversions;

/// <summary>
///   <para>Set of converters for <see cref="DirectoryInfo"/> type.</para>
/// </summary>
/// <seealso cref="DirectoryInfo"/>
public static class DirectoryInfoConverters
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="pattern"></param>
  /// <param name="recursive"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static IEnumerable<FileSystemInfo> Enumerable(this IConversion<DirectoryInfo> conversion, string pattern = null, bool recursive = false, string error = null) => conversion.To(directory => directory.ToEnumerable(pattern, recursive), error);
}