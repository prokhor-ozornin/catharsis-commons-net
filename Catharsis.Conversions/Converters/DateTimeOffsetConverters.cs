using Catharsis.Extensions;

namespace Catharsis.Conversions;

/// <summary>
///   <para></para>
/// </summary>
public static class DateTimeOffsetConverters
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <returns></returns>
  public static DateTime DateTime(this IConversion<DateTimeOffset> conversion) => conversion.To(date => date.ToDateTime());

#if NET7_0
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <returns></returns>
  public static DateOnly DateOnly(this IConversion<DateTimeOffset> conversion) => conversion.To(date => date.ToDateOnly());

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <returns></returns>
  public static TimeOnly TimeOnly(this IConversion<DateTimeOffset> conversion) => conversion.To(date => date.ToTimeOnly());
#endif
}