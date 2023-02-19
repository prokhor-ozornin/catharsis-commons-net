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
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="comparer"></param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  public static IEnumerable<(TKey Key, TValue Value)> ValueTuple<TKey, TValue>(this IConversion<IReadOnlyDictionary<TKey, TValue>> conversion, IComparer<TKey> comparer = null, string error = null) where TKey : notnull => conversion.To(dictionary => dictionary.ToValueTuple(comparer), error);
}