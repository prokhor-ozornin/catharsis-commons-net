using Catharsis.Extensions;

namespace Catharsis.Conversions;

/// <summary>
///   <para>Set of converters for <see cref="DateTime"/> type.</para>
/// </summary>
/// <seealso cref="DateTime"/>
public static class DateTimeConverters
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static DateTimeOffset DateTimeOffset(this IConversion<DateTime> conversion, string error = null) => conversion.To(date => date.ToDateTimeOffset(), error);

#if NET7_0_OR_GREATER
/// <summary>
///   <para></para>
/// </summary>
/// <param name="conversion"></param>
/// <param name="error"></param>
/// <returns></returns>
/// <exception cref="ArgumentNullException"></exception>
public static DateOnly DateOnly(this IConversion<DateTime> conversion, string error = null) => conversion.To(date => date.ToDateOnly(), error);

/// <summary>
///   <para></para>
/// </summary>
/// <param name="conversion"></param>
/// <param name="error"></param>
/// <returns></returns>
/// <exception cref="ArgumentNullException"></exception>
public static TimeOnly TimeOnly(this IConversion<DateTime> conversion, string error = null) => conversion.To(date => date.ToTimeOnly(), error);
#endif
}