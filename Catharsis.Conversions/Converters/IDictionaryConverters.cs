﻿using Catharsis.Extensions;

namespace Catharsis.Conversions;

/// <summary>
///   <para>Set of converters for <see cref="IDictionary{TKey, TValue}"/> types.</para>
/// </summary>
/// <seealso cref="IDictionary{TKey, TValue}"/>
public static class IDictionaryConverters
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="TKey"></typeparam>
  /// <typeparam name="TValue"></typeparam>
  /// <param name="conversion"></param>
  /// <param name="comparer"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static SortedList<TKey, TValue> SortedList<TKey, TValue>(this IConversion<IDictionary<TKey, TValue>> conversion, IComparer<TKey> comparer = null, string error = null) where TKey : notnull => conversion.To(dictionary => dictionary.ToSortedList(comparer), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="TKey"></typeparam>
  /// <typeparam name="TValue"></typeparam>
  /// <param name="conversion"></param>
  /// <param name="comparer"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static SortedDictionary<TKey, TValue> SortedDictionary<TKey, TValue>(this IConversion<IDictionary<TKey, TValue>> conversion, IComparer<TKey> comparer = null, string error = null) where TKey : notnull => conversion.To(dictionary => dictionary.ToSortedDictionary(comparer), error);
}