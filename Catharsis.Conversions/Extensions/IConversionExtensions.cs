﻿namespace Catharsis.Conversions;

/// <summary>
///   <para></para>
/// </summary>
/// <seealso cref="IConversion{TSource}"/>
public static class IConversionExtensions
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <typeparam name="TSource"></typeparam>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <exception cref="ArgumentNullException"></exception>
  public static IConversion<TSource> To<TSource>(this IConversion<TSource> conversion) => conversion ?? throw new ArgumentNullException(nameof(conversion));
}