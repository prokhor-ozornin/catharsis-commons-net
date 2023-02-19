#if NET7_0_OR_GREATER
using Catharsis.Extensions;

namespace Catharsis.Conversions;

/// <summary>
///   <para>Set of converters for <see cref="DateOnly"/> type.</para>
/// </summary>
/// <seealso cref="DateOnly"/>
public static class DateOnlyConverters
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static DateTime DateTime(this IConversion<DateOnly> conversion, string error = null) => conversion.To(date => date.ToDateTime(), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static DateTimeOffset DateTimeOffset(this IConversion<DateOnly> conversion, string error = null) => conversion.To(date => date.ToDateTimeOffset(), error);
}
#endif