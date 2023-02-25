using Catharsis.Extensions;

namespace Catharsis.Conversions;

/// <summary>
///   <para>Set of converters for <see cref="IDictionary{TKey, TValue}"/> types.</para>
/// </summary>
/// <seealso cref="IDictionary{TKey, TValue}"/>
public static class IDictionaryConverters
{
  /// <summary>
  ///   <para>Converts given <see cref="IDictionary{TKey, TValue}"/> instance to the instance of <see cref="System.Collections.Generic.SortedList{TKey, TValue}"/> type.</para>
  /// </summary>
  /// <typeparam name="TKey">Type of dictionary keys.</typeparam>
  /// <typeparam name="TValue">Type of dictionary values.</typeparam>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="comparer">Comparer to perform comparison of objects.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="IDictionaryExtensions.ToSortedList{TKey, TValue}(IDictionary{TKey, TValue}, IComparer{TKey})"/>
  public static SortedList<TKey, TValue> SortedList<TKey, TValue>(this IConversion<IDictionary<TKey, TValue>> conversion, IComparer<TKey> comparer = null, string error = null) where TKey : notnull => conversion.To(dictionary => dictionary.ToSortedList(comparer), error);

  /// <summary>
  ///   <para>Converts given <see cref="IDictionary{TKey, TValue}"/> instance to the instance of <see cref="System.Collections.Generic.SortedDictionary{TKey, TValue}"/> type.</para>
  /// </summary>
  /// <typeparam name="TKey">Type of dictionary keys.</typeparam>
  /// <typeparam name="TValue">Type of dictionary values.</typeparam>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="comparer">Comparer to perform comparison of objects.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="IDictionaryExtensions.ToSortedDictionary{TKey, TValue}(IDictionary{TKey, TValue}, IComparer{TKey})"/>
  public static SortedDictionary<TKey, TValue> SortedDictionary<TKey, TValue>(this IConversion<IDictionary<TKey, TValue>> conversion, IComparer<TKey> comparer = null, string error = null) where TKey : notnull => conversion.To(dictionary => dictionary.ToSortedDictionary(comparer), error);
}