﻿#if NET7_0_OR_GREATER
using System.Text.RegularExpressions;
using Catharsis.Extensions;

namespace Catharsis.Conversions;

/// <summary>
///   <para>Set of converters for <see cref="Match"/> type.</para>
/// </summary>
/// <seealso cref="Match"/>
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
#endif