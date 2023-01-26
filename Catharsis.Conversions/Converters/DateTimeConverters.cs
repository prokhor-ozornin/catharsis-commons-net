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
  /// <exception cref="ArgumentNullException"></exception>
  public static DateTimeOffset DateTimeOffset(this IConversion<DateTime> conversion) => conversion.To(date => date.ToDateTimeOffset());

#if NET7_0_OR_GREATER
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static DateOnly DateOnly(this IConversion<DateTime> conversion) => conversion.To(date => date.ToDateOnly());

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static TimeOnly TimeOnly(this IConversion<DateTime> conversion) => conversion.To(date => date.ToTimeOnly());
#endif
}