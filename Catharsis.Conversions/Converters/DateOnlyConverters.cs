#if NET7_0
using Catharsis.Extensions;

namespace Catharsis.Conversions;

/// <summary>
///   <para></para>
/// </summary>
public static class DateOnlyConverters
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <returns></returns>
  public static DateTime DateTime(this IConversion<DateOnly> conversion) => conversion.To(date => date.ToDateTime());

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <returns></returns>
  public static DateTimeOffset DateTimeOffset(this IConversion<DateOnly> conversion) => conversion.To(date => date.ToDateTimeOffset());
}
#endif