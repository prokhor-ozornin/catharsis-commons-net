using Catharsis.Extensions;

namespace Catharsis.Conversions;

/// <summary>
///   <para></para>
/// </summary>
public static class DateTimeConverters
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <returns></returns>
  public static DateTimeOffset DateTimeOffset(this IConversion<DateTime> conversion) => conversion.To(date => date.ToDateTimeOffset());

#if NET7_0
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <returns></returns>
  public static DateOnly DateOnly(this IConversion<DateTime> conversion) => conversion.To(date => date.ToDateOnly());

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <returns></returns>
  public static TimeOnly TimeOnly(this IConversion<DateTime> conversion) => conversion.To(date => date.ToTimeOnly());
#endif
}