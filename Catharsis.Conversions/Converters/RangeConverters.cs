using Catharsis.Extensions;

namespace Catharsis.Conversions;

/// <summary>
///   <para>Set of converters for <see cref="Range"/> type.</para>
/// </summary>
/// <seealso cref="Range"/>
public static class RangeConverters
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static IEnumerable<int> Enumerable(this IConversion<Range> conversion, string error = null) => conversion.To(range => range.ToEnumerable(), error);
}