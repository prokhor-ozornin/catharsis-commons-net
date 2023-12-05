using Catharsis.Extensions;

namespace Catharsis.Commons;

/// <summary>
///   <para>Set of converters for <see cref="IReadOnlyDictionary{TKey, TValue}"/> types.</para>
/// </summary>
/// <seealso cref="IReadOnlyDictionary{TKey, TValue}"/>
public static class IReadOnlyDictionaryConverters
{
  /// <summary>
  ///   <para>Converts given <see cref="IReadOnlyDictionary{TKey, TValue}"/> instance to the instance of <see cref="IEnumerable{(TKey, TValue)}"/> type.</para>
  /// </summary>
  /// <typeparam name="TKey">Type of dictionary keys.</typeparam>
  /// <typeparam name="TValue">Type of dictionary values.</typeparam>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="comparer">Comparer to perform comparison of objects.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="IReadOnlyDictionaryExtensions.ToValueTuple{TKey, TValue}(IReadOnlyDictionary{TKey, TValue}, IComparer{TKey})"/>
  public static IEnumerable<(TKey Key, TValue Value)> ValueTuple<TKey, TValue>(this IConversion<IReadOnlyDictionary<TKey, TValue>> conversion, IComparer<TKey> comparer = null, string error = null) where TKey : notnull => conversion.To(dictionary => dictionary.ToValueTuple(comparer), error);
}