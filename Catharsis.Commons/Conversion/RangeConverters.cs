using Catharsis.Extensions;

namespace Catharsis.Conversions;

/// <summary>
///   <para>Set of converters for <see cref="Range"/> type.</para>
/// </summary>
/// <seealso cref="Range"/>
public static class RangeConverters
{
  /// <summary>
  ///   <para>Converts given <see cref="Range"/> instance to the instance of <see cref="IEnumerable{int}"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="RangeExtensions.ToEnumerable(Range)"/>
  public static IEnumerable<int> Enumerable(this IConversion<Range> conversion, string error = null) => conversion.To(range => range.ToEnumerable(), error);
}