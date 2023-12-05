#if NET7_0_OR_GREATER
using System.Text.RegularExpressions;
using Catharsis.Extensions;

namespace Catharsis.Commons;

/// <summary>
///   <para>Set of converters for <see cref="Match"/> type.</para>
/// </summary>
/// <seealso cref="Match"/>
public static class MatchConverters
{
  /// <summary>
  ///   <para>Converts given <see cref="Match"/> instance to the instance of <see cref="IEnumerable{Capture}"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="MatchExtensions.ToEnumerable(Match)"/>
  public static IEnumerable<Capture> Enumerable(this IConversion<Match> conversion, string error = null) => conversion.To(match => match.ToEnumerable(), error);
}
#endif