using Catharsis.Extensions;

namespace Catharsis.Conversions;

/// <summary>
///   <para>Set of converters for <see cref="DateTimeOffset"/> type.</para>
/// </summary>
/// <seealso cref="DateTimeOffset"/>
public static class DateTimeOffsetConverters
{
  /// <summary>
  ///   <para>Converts given <see cref="DateTimeOffset"/> instance to the instance of <see cref="System.DateTime"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="DateTimeOffsetExtensions.ToDateTime(DateTimeOffset)"/>
  public static DateTime DateTime(this IConversion<DateTimeOffset> conversion, string error = null) => conversion.To(date => date.ToDateTime(), error);

#if NET7_0_OR_GREATER
/// <summary>
///   <para>Converts given <see cref="DateTimeOffset"/> instance to the instance of <see cref="System.DateOnly"/> type.</para>
/// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="DateTimeOffsetExtensions.ToDateOnly(DateTimeOffset)"/>
  public static DateOnly DateOnly(this IConversion<DateTimeOffset> conversion, string error = null) => conversion.To(date => date.ToDateOnly(), error);

/// <summary>
///   <para>Converts given <see cref="DateTimeOffset"/> instance to the instance of <see cref="System.TimeOnly"/> type.</para>
/// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="DateTimeOffsetExtensions.ToTimeOnly(DateTimeOffset)"/>
  public static TimeOnly TimeOnly(this IConversion<DateTimeOffset> conversion, string error = null) => conversion.To(date => date.ToTimeOnly(), error);
#endif
}