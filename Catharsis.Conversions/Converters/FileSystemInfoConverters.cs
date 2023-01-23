using Catharsis.Extensions;

namespace Catharsis.Conversions;

/// <summary>
///   <para></para>
/// </summary>
public static class FileSystemInfoConverters
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <returns></returns>
  public static Uri Uri(this IConversion<FileSystemInfo> conversion) => conversion.To(info => info.ToUri());
}