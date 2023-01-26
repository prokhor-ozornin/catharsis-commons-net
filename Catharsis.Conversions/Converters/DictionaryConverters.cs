using Catharsis.Extensions;

namespace Catharsis.Conversions;

/// <summary>
///   <para></para>
/// </summary>
public static class DictionaryConverters
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="TKey"></typeparam>
  /// <typeparam name="TValue"></typeparam>
  /// <param name="conversion"></param>
  /// <param name="comparer"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static SortedList<TKey, TValue> SortedList<TKey, TValue>(this IConversion<IDictionary<TKey, TValue>> conversion, IComparer<TKey> comparer = null) where TKey : notnull => conversion.To(dictionary => dictionary.ToSortedList(comparer));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="TKey"></typeparam>
  /// <typeparam name="TValue"></typeparam>
  /// <param name="conversion"></param>
  /// <param name="comparer"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static SortedDictionary<TKey, TValue> SortedDictionary<TKey, TValue>(this IConversion<IDictionary<TKey, TValue>> conversion, IComparer<TKey> comparer = null) where TKey : notnull => conversion.To(dictionary => dictionary.ToSortedDictionary(comparer));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="TKey"></typeparam>
  /// <typeparam name="TValue"></typeparam>
  /// <param name="conversion"></param>
  /// <param name="comparer"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static IEnumerable<(TKey Key, TValue Value)> ValueTuple<TKey, TValue>(this IConversion<IReadOnlyDictionary<TKey, TValue>> conversion, IComparer<TKey> comparer = null) where TKey : notnull => conversion.To(dictionary => dictionary.ToValueTuple(comparer));
}