using System.Text.RegularExpressions;
using Catharsis.Extensions;

namespace Catharsis.Conversions;

/// <summary>
///   <para></para>
/// </summary>
public static class MatchConverters
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static IEnumerable<Capture> Enumerable(this IConversion<Match> conversion) => conversion.To(match => match.ToEnumerable());
}