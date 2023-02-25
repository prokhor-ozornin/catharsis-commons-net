using Catharsis.Extensions;

namespace Catharsis.Conversions;

/// <summary>
///   <para>Set of converters for <see cref="DirectoryInfo"/> type.</para>
/// </summary>
/// <seealso cref="DirectoryInfo"/>
public static class DirectoryInfoConverters
{
  /// <summary>
  ///   <para>Converts given <see cref="DirectoryInfo"/> instance to the instance of <see cref="IEnumerable{FileSystemInfo}"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="pattern">Files/directories search pattern.</param>
  /// <param name="recursive">Whether to search recursively in subdirectories as well.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="DirectoryInfoExtensions.ToEnumerable(DirectoryInfo, string, bool)"/>
  public static IEnumerable<FileSystemInfo> Enumerable(this IConversion<DirectoryInfo> conversion, string pattern = null, bool recursive = false, string error = null) => conversion.To(directory => directory.ToEnumerable(pattern, recursive), error);
}