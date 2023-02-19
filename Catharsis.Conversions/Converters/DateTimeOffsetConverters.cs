using Catharsis.Extensions;

namespace Catharsis.Conversions;

/// <summary>
///   <para>Set of converters for <see cref="DateTimeOffset"/> type.</para>
/// </summary>
/// <seealso cref="DateTimeOffset"/>
public static class DateTimeOffsetConverters
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static DateTime DateTime(this IConversion<DateTimeOffset> conversion, string error = null) => conversion.To(date => date.ToDateTime(), error);

#if NET7_0_OR_GREATER
/// <summary>
///   <para></para>
/// </summary>
/// <param name="conversion"></param>
/// <param name="error"></param>
/// <returns></returns>
/// <exception cref="ArgumentNullException"></exception>
public static DateOnly DateOnly(this IConversion<DateTimeOffset> conversion, string error = null) => conversion.To(date => date.ToDateOnly(), error);

/// <summary>
///   <para></para>
/// </summary>
/// <param name="conversion"></param>
/// <param name="error"></param>
/// <returns></returns>
/// <exception cref="ArgumentNullException"></exception>
public static TimeOnly TimeOnly(this IConversion<DateTimeOffset> conversion, string error = null) => conversion.To(date => date.ToTimeOnly(), error);
#endif
}