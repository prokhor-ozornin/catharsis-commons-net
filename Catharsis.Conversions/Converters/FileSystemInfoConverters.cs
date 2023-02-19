using Catharsis.Extensions;

namespace Catharsis.Conversions;

/// <summary>
///   <para>Set of converters for <see cref="FileSystemInfo"/> type.</para>
/// </summary>
/// <seealso cref="FileSystemInfo"/>
public static class FileSystemInfoConverters
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static Uri Uri(this IConversion<FileSystemInfo> conversion, string error = null) => conversion.To(info => info.ToUri(), error);
}