#if NET7_0_OR_GREATER
using Catharsis.Extensions;

namespace Catharsis.Commons;

/// <summary>
///   <para>Set of converters for <see cref="TimeOnly"/> type.</para>
/// </summary>
/// <seealso cref="TimeOnly"/>
public static class TimeOnlyConverters
{
  /// <summary>
  ///   <para>Converts given <see cref="TimeOnly"/> instance to the instance of <see cref="System.DateTime"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="TimeOnlyExtensions.ToDateTime(TimeOnly)"/>
  public static DateTime DateTime(this IConversion<TimeOnly> conversion, string error = null) => conversion.To(time => time.ToDateTime(), error);

  /// <summary>
  ///   <para>Converts given <see cref="TimeOnly"/> instance to the instance of <see cref="System.DateTimeOffset"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="TimeOnlyExtensions.ToDateTimeOffset(TimeOnly)"/>
  public static DateTimeOffset DateTimeOffset(this IConversion<TimeOnly> conversion, string error = null) => conversion.To(time => time.ToDateTimeOffset(), error);
}
#endif