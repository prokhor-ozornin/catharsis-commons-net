using Catharsis.Extensions;

namespace Catharsis.Conversions;

/// <summary>
///   <para>Set of converters for <see cref="IReadOnlyDictionary{TKey, TValue}"/> types.</para>
/// </summary>
/// <seealso cref="IReadOnlyDictionary{TKey, TValue}"/>
public static class IReadOnlyDictionaryConverters
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
  public static IEnumerable<(TKey Key, TValue Value)> ValueTuple<TKey, TValue>(this IConversion<IReadOnlyDictionary<TKey, TValue>> conversion, IComparer<TKey> comparer = null) where TKey : notnull => conversion.To(dictionary => dictionary.ToValueTuple(comparer));
}