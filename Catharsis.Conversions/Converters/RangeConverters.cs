using Catharsis.Extensions;

namespace Catharsis.Conversions;

/// <summary>
///   <para></para>
/// </summary>
/// <seealso cref="Range"/>
public static class RangeConverters
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static IEnumerable<int> Enumerable(this IConversion<Range> conversion) => conversion.To(range => range.ToEnumerable());
}