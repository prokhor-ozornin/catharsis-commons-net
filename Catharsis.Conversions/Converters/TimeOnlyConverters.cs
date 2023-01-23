#if NET7_0
using Catharsis.Extensions;

namespace Catharsis.Conversions;

/// <summary>
///   <para></para>
/// </summary>
public static class TimeOnlyConverters
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <returns></returns>
  public static DateTime DateTime(this IConversion<TimeOnly> conversion) => conversion.To(time => time.ToDateTime());

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <returns></returns>
  public static DateTimeOffset DateTimeOffset(this IConversion<TimeOnly> conversion) => conversion.To(time => time.ToDateTime());
}
#endif