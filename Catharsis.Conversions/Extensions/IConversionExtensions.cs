﻿namespace Catharsis.Conversions;

/// <summary>
///   <para></para>
/// </summary>
public static class IConversionExtensions
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <typeparam name="TSource"></typeparam>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static IConversion<TSource> To<TSource>(this IConversion<TSource> conversion) => conversion ?? throw new ArgumentNullException(nameof(conversion));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="TSource"></typeparam>
  /// <typeparam name="TResult"></typeparam>
  /// <param name="conversion"></param>
  /// <param name="converter"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static TResult To<TSource, TResult>(this IConversion<TSource> conversion, Func<TSource, TResult> converter)
  {
    if (conversion is null) throw new ArgumentNullException(nameof(conversion));
    if (converter is null) throw new ArgumentNullException(nameof(converter));

    return converter(conversion.Source);
  }
}