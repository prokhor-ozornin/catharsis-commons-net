#if NET7_0_OR_GREATER
using Catharsis.Extensions;

namespace Catharsis.Conversions;

/// <summary>
///   <para>Set of converters for <see cref="TimeOnly"/> type.</para>
/// </summary>
/// <seealso cref="TimeOnly"/>
public static class TimeOnlyConverters
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static DateTime DateTime(this IConversion<TimeOnly> conversion, string error = null) => conversion.To(time => time.ToDateTime(), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static DateTimeOffset DateTimeOffset(this IConversion<TimeOnly> conversion, string error = null) => conversion.To(time => time.ToDateTime(), error);
}
#endif